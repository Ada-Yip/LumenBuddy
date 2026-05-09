using AxWMPLib;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//using WMPLib;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AI_Project
{
    public partial class Form1 : Form
    {

        string username = "whoiam";
        string password = "";
        int catAniS = 0;
        int catAniN = 0;
        int catToMoveX = 0;
        int catToMoveY = 0;
        int catIdleTime = 0;
        bool inputPassword = false;
        string responseMesg;
        string[] Nwords = { "unhappy", "not happy", "sad", "angry", "disappoint", "depress", "upset", "heart broken", "unluck", "not luck" };
        string[] Pwords = { "happy", "excit", "joy", "glad", "luck" };
        int todayRec = 0;
        int score = 3;
        int responseStep;
        string todayDate;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private async Task StartRequest(string question)
        {
            string apiUrl = "http://localhost:4891/v1/chat/completions";

            var requestData = new
            {
                model = "Llama 3.2 1B Instruct",
                max_tokens = 2048,
                messages = new[]
                {
                new { role = "system", content = "You are an AI assistant." },
                new { role = "user", content = question }
            },
            };

            using var client = new HttpClient();
            var response = await client.PostAsJsonAsync(apiUrl, requestData);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var parsedJson = responseBody;
            int pS = parsedJson.IndexOf("{\"content\":");
            int pE = parsedJson.IndexOf("\"role\":");
            responseMesg = parsedJson.Substring(pS + 12, pE - pS - 14);
            int p;
            while ((p = responseMesg.IndexOf("\\r")) >= 0)
            {
                responseMesg = responseMesg.Substring(0, p) + responseMesg.Substring(p + 2);
            }
            while ((p = responseMesg.IndexOf("\\n")) >= 0)
            {
                responseMesg = responseMesg.Substring(0, p) + "\n" + responseMesg.Substring(p + 2);
            }
            timerResponse.Enabled = true;
        }

        private void chatbot_Response()
        {
            switch (responseStep)
            {
                case 0: StartRequest(txtQuestion.Text); break;
                case 1:
                    rTxtResponse.Text = responseMesg;

                    /*
                    StartRequest(txtQuestion.Text + " Please use happy or unhappy to determine my mood, without any explaination.");
                    break;
                case 2:
                    */

                    score = 0;
                    string r = responseMesg.ToLower();
                    string q = txtQuestion.Text.ToLower();
                    if (r.IndexOf("sorry") >= 0) score = -1;
                    else if (r.IndexOf("sad") >= 0) score = -1;
                    else if (r.IndexOf("not feeling well") >= 0) score = -1;
                    else
                    {
                        foreach (string w in Nwords)
                            if (q.IndexOf(w) >= 0) score = -1;
                        if (score == 0)
                        {
                            foreach (string w in Pwords)
                                if (q.IndexOf(w) >= 0) score = 1;
                        }
                    }
                    if (q.IndexOf(" very ") >= 0 || q.IndexOf(" so ") >= 0 || q.IndexOf(" really ") >= 0) score *= 2;
                    score += 3;
                    btnPlayGame.Visible = true;
                    //rTxtHistory.Text += "(" + score + ")\n\n";
                    rTxtHistory.Text += "\nAI Chatbot: " + responseMesg + "\n\n";

                    StreamWriter sw = new StreamWriter("records.dat", true);
                    if (todayRec++ == 0)
                    {
                        sw.WriteLine(encryptRecord("`^" + todayDate));
                    }
                    sw.WriteLine(encryptRecord(username + ": " + txtQuestion.Text));
                    sw.WriteLine(encryptRecord("`|" + score));
                    sw.WriteLine(encryptRecord("Chatbot: " + rTxtResponse.Text));
                    sw.Close();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            todayDate = today.Date.ToString("dd-MM-yyyy");
            txtDate.Text = todayDate;

            try
            {
                StreamReader sr = new StreamReader("system.dat");
                string s = decrypt(sr.ReadLine());
                if (s.Length > 0) username = s;
                s = decrypt(sr.ReadLine());
                if (s.Length > 0)
                {
                    password = s;
                    openInputPanel("Input your password", true);
                }
                sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception)
            {
            }

            int sW = Screen.PrimaryScreen.WorkingArea.Width;
            int sH = Screen.PrimaryScreen.WorkingArea.Height;
            if (this.Width > sW) this.Width = sW;
            if (this.Height > sH) this.Height = sH;
            Form1_Resize(sender, e);

            if (password.Length == 0)
            {
                panelInput.Visible = false;
                //panelInput.Left = 0;
                //panelInput.Top = 45;
                panelForm.Top = 35;
                panelForm.Visible = true;
                menuStrip1.Enabled = true;
            }
            rTxtHistory.Text = "Chatbot: Hi " + username + "!\n\n";
            string[] fileList = Directory.GetFiles("Music\\");
            foreach (string fname in fileList)
            {
                string fn = fname.Substring(6);
                int n = fn.Length;
                if (n > 3 && fn.Substring(n - 4).ToLower().Equals(".mp3"))
                {
                    lbxMusic.Items.Add(fn.Substring(0, n - 4));
                }
            }
        }

        private void openInputPanel(string msg, bool passwordMode)
        {
            //txtInputMsg.Text = Convert.ToInt32( txtInputMsg.PasswordChar ).ToString();
            lblInput.Text = msg + ":";
            if (passwordMode) txtInput.Text = "";
            txtInput.PasswordChar = (passwordMode ? '*' : Convert.ToChar(0));
            inputPassword = passwordMode;
            panelInput.Visible = true;
        }

        private string encrypt(string s)
        {
            int i;
            string retS = Convert.ToChar(33 + s.Length).ToString();
            for (i = 0; i < s.Length; i++)
            {
                char c = s[i];
                int code = 158 - (((c & 3) * 4) | ((c & 12) / 4) | (c & 240));
                retS += Convert.ToChar(code);
            }
            for (i = s.Length; i < 20; i++)
                retS += Convert.ToChar(rand.Next(32, 127));
            return (retS);
        }

        private string decrypt(string s)
        {
            int i, n = s[0] - 33;
            string retS = "";
            for (i = 1; i <= n; i++)
            {
                char c = s[i];
                int code = 158 - c;
                code = ((code & 3) * 4) | ((code & 12) / 4) | (code & 240);
                retS += Convert.ToChar(code);
            }
            return (retS);
        }

        private string encryptRecord(string s)
        {
            int i;
            string retS = "";
            for (i = 0; i < s.Length; i++)
            {
                char c = s[i];
                int code = 158 - (((c & 3) * 4) | ((c & 12) / 4) | (c & 240));
                retS += Convert.ToChar(code);
            }
            return (retS);
        }

        private string decryptRecord(string s)
        {
            int i;
            string retS = "";
            for (i = 0; i < s.Length; i++)
            {
                char c = s[i];
                int code = 158 - c;
                code = ((code & 3) * 4) | ((code & 12) / 4) | (code & 240);
                retS += Convert.ToChar(code);
            }
            return (retS);
        }

        private void StripMenu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInputOK_Click(object sender, EventArgs e)
        {
            if (inputPassword)
            {
                if (lblInput.Text.Equals("Password:"))
                    password = txtInput.Text;
                else if (lblInput.Text.Substring(0, 10).Equals("To confirm") && password.Equals(txtInput.Text))
                {
                    System.IO.File.Delete("records.dat");
                }
                else
                {
                    if (txtInput.Text != password)
                        txtInput.Text = "";
                    else
                    {
                        panelInput.Visible = false;
                        //panelInput.Left = 0;
                        //panelInput.Top = 45;
                        menuStrip1.Enabled = true;
                        panelForm.Top = 38;
                        panelForm.Visible = true;
                        this.BackgroundImage = null;
                        txtQuestion.Focus();
                    }
                    return;
                }
            }
            else
                username = txtInput.Text;
            if (lblInput.Text.Equals("Your Name:") || lblInput.Text.Equals("Password:"))
            {
                //rTxtHistory.Text += "Hi " + decrypt(encrypt(username)) + ", your password is " + decrypt(encrypt(password)) + ".\n\n";
                try
                {
                    StreamWriter sw = new StreamWriter("system.dat");
                    sw.WriteLine(encrypt(username));
                    sw.WriteLine(encrypt(password));
                    sw.Close();
                }
                catch (Exception)
                {
                    rTxtHistory.Text += "Chatbot: Hi " + username + ", I cannot save your data.";
                }
            }
            panelInput.Visible = false;
        }

        private void btnInputCancel_Click(object sender, EventArgs e)
        {
            if (lblInput.Text.Length > 10)
            {
                string s = lblInput.Text.Substring(0, 10);
                if (lblInput.Text.Substring(0, 10).Equals("Input your"))
                    Application.Exit();
            }
            panelInput.Visible = false;
        }

        private void StripMenu_Password_Click(object sender, EventArgs e)
        {
            openInputPanel("Password", true);
        }

        private void StripMenu_Name_Click(object sender, EventArgs e)
        {
            txtInput.Text = username;
            openInputPanel("Your Name", false);
        }

        private void StripMenu_Remove_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msgButton = MessageBoxButtons.YesNo;
            DialogResult Answer = MessageBox.Show("Are you sure you want to remove all records", "Confirm", msgButton);
            if (Answer == DialogResult.Yes)
            {
                openInputPanel("To confirm, please enter your password", true);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            rTxtResponse.Text = "Thinking ...";
            responseStep = 0;
            chatbot_Response();
            panelCat.Width = 32;
            panelCat.Height = 30;
            panelCat.Visible = true;
            timerCatMove.Enabled = true;
            timerCatPic.Enabled = true;
            btnPlayMusic.Visible = true;
            rTxtHistory.Text += "\n" + username + ": " + txtQuestion.Text + "\n";
            txtQuestion.Focus();
        }

        private void timerCatPic_Tick(object sender, EventArgs e)
        {
            int oldAni = catAniS;
            if (catToMoveX > 0 && catToMoveY >= 0) catAniS = 6;
            else if (catToMoveX < 0 && catToMoveY >= 0) catAniS = 8;
            else if (catToMoveX < 0 && catToMoveY < 0) catAniS = 10;
            else if (catToMoveX > 0 && catToMoveY < 0) catAniS = 12;
            else if (catToMoveX == 0 && catToMoveY > 0) catAniS = 14;
            else if (catToMoveX == 0 && catToMoveY < 0) catAniS = 16;
            else catAniS = 0;

            if (catAniS > 5 && oldAni == 4) { catAniS = 2; catAniN = 1; }
            else
            {
                if (catAniS > 5) catIdleTime = 0;
                else
                {
                    if (++catIdleTime > 30) catAniS = 4;
                }
            }

            if (catAniN == 0) catAniN = 1;
            else catAniN = 0;
            picCat.Left = (catAniS + catAniN) * -32;
        }

        private void panelForm_MouseMove(object sender, MouseEventArgs e)
        {
            catToMoveX = 0;
            catToMoveY = 0;
            int mouseX = e.Location.X;
            int mouseY = e.Location.Y;

            if (panelCat.Location.X - 2 > mouseX) catToMoveX = -2;
            else if (panelCat.Location.X + 34 < mouseX) catToMoveX = 2;
            if (panelCat.Location.Y - 2 > mouseY) catToMoveY = -2;
            else if (panelCat.Location.Y + 32 < mouseY) catToMoveY = 2;
        }

        private void timerCatMove_Tick(object sender, EventArgs e)
        {
            if (catAniS > 5)
            {
                panelCat.Left += catToMoveX;
                panelCat.Top += catToMoveY;
            }
        }

        private void panelForm_MouseLeave(object sender, EventArgs e)
        {
            catToMoveX = 0;
            catToMoveY = 0;
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            int[] SgameGroup = { 1, 1, 2, 1, 1, 2, 1, 2, 2, 2, 1, 1, 1, 1, 2, 1 };
            int[] HgameGroup = { 5, 3, 3, 4, 5, 4, 3, 5, 4, 3, 4, 5, 5, 3, 4, 5 };
            int gn = -1, p;
            string gName;
            if (score < 3)
            {
                do
                {
                    p = rand.Next(0, 16);
                    if (SgameGroup[p] == score) gn = p;
                } while (gn == -1);
                lbxGames.SelectedIndex = gn;
                gName = lbxGames.Text;
                lbxGames.Visible = true;
            }
            else
            {
                do
                {
                    p = rand.Next(0, 16);
                    if (HgameGroup[p] == score) gn = p;
                } while (gn == -1);
                lbxGamesHappy.SelectedIndex = gn;
                gName = lbxGamesHappy.Text;
                lbxGamesHappy.Visible = true;
            }
            rTxtHistory.Text += "Chatbot: You may consider to play '" + gName + "'.\n\n";
        }

        private void toRun(string prog, string item)
        {
            System.Diagnostics.Process browser = new System.Diagnostics.Process();
            browser.StartInfo.FileName = prog;
            browser.StartInfo.Arguments = Application.StartupPath + item;
            browser.StartInfo.UseShellExecute = false;
            browser.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;
            browser.Start();
        }
        private void StripMenu_Online_Click(object sender, EventArgs e)
        {
            toRun("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", "AIChatbot.html");
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnInputOK.PerformClick();
        }

        private void btnAbout_OK_Click(object sender, EventArgs e)
        {
            timerNameList.Enabled = false;
            panelAbout.Visible = false;
        }

        private void StripMenu_View_Click(object sender, EventArgs e)
        {
            rTxtHistory.Text = "";
            try
            {
                int n = 0;
                StreamReader sr = new StreamReader("records.dat");
                while (!sr.EndOfStream)
                {
                    string s = decryptRecord(sr.ReadLine());
                    if (s[0] == '`')
                    {
                        if (s[1] == '^')
                        {
                            if (n++ > 0) rTxtHistory.Text += "=======================================================\n\n";
                            rTxtHistory.Text += "Date: " + s.Substring(2) + "\n\n\n";
                        }
                        if (s[1] == '|')
                        {
                            rTxtHistory.Text += "(" + s.Substring(2) + ")\n\n";
                        }
                    }
                    else
                    {
                        rTxtHistory.Text += s + "\n";
                        if (s.Length > 8 && s.Substring(0, 8).Equals("Chatbot:"))
                            rTxtHistory.Text += "\n\n";
                    }
                }
                sr.Close();
                btnViewChart.Visible = true;
            }
            catch (Exception)
            {
                rTxtHistory.Text = "There is no chat record at the moment.\n";
            }
        }

        private void timerResponse_Tick(object sender, EventArgs e)
        {
            responseStep++;
            chatbot_Response();
            timerResponse.Enabled = false;
        }

        private void txtDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) todayDate = txtDate.Text;
        }

        private void lbxGames_MouseLeave(object sender, EventArgs e)
        {
            lbxGames.Visible = false;
        }

        private void lbxGamesHappy_MouseLeave(object sender, EventArgs e)
        {
            lbxGamesHappy.Visible = false;
        }

        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            lbxMusic.Visible = true;
        }

        private void lbxMusic_MouseLeave(object sender, EventArgs e)
        {
            lbxMusic.Visible = false;
        }

        private void btnNoAI_Click(object sender, EventArgs e)
        {
            int s = 3;
            panelCat.Width = 32;
            panelCat.Height = 30;
            panelCat.Visible = true;
            timerCatMove.Enabled = true;
            timerCatPic.Enabled = true;
            btnPlayMusic.Visible = true;
            rTxtHistory.Text += "\n" + username + ": " + txtQuestion.Text + "\n";
            responseStep = 1;
            string q = txtQuestion.Text.ToLower();
            responseMesg = "";
            foreach (string w in Nwords)
                if (q.IndexOf(w) >= 0) { s = 2; break; }
            if (s == 2)
            {
                string[] noAIresponse = { "I'm so sorry to hear that you're feeling sad.Would you like to talk about what's bothering you? Sometimes sharing your thoughts and feelings with someone who can listen without judgment can help ease the weight of them. I'll do my best to support you.",
                                          "I'm here to listen and help in any way I can. Would you like to talk about what's on your mind and feeling sad is not a problem, just share with me?",
                                          "It can feel really tough to deal with unhappiness. What's going on that's making you feel this way? Is there anything specific happening in your life that might be contributing to your feelings?",
                                          "It's normal to feel that way, especially when something doesn't go as planned. Can you tell me what specifically happened? This will help me provide a better response."
                                        };
                responseMesg = noAIresponse[rand.Next(0, 4)];
            }
            if (s == 3)
            {
                foreach (string w in Pwords)
                    if (q.IndexOf(w) >= 0) { s = 4; break; }
                if (s == 4)
                {
                    string[] noAIresponse = { "That's wonderful to hear! It's great that you're feeling happy today. Is there something on your mind or would you like some suggestions or just want to chat about anything in particular?",
                                              "It's great to hear you're feeling happy. Is there anything I can help you with today?",
                                              "I'm glad to hear that you're feeling happy. What's going on today that's making you smile?"
                                            };
                    responseMesg = noAIresponse[rand.Next(0, 3)];
                }
            }
            if (s == 3)
            {
                string[] noAIresponse = { "I can offer information and entertainment, but I can't answer personal questions or provide guidance on medical or financial decisions. Can I help you with something else?",
                                          "I can offer information and entertain you with facts and topics.",
                                          "You ask me a question or give me an instruction, and I'll do my best to help. What's on your mind?"
                                        };
                responseMesg = noAIresponse[rand.Next(0, 3)];
            }
            chatbot_Response();
            txtQuestion.Focus();
        }

        private void MenuItem_About_Click(object sender, EventArgs e)
        {
            panelAbout.Visible = true;
            timerNameList.Enabled = true;
        }

        private void btnViewChart_MouseLeave(object sender, EventArgs e)
        {
            btnViewChart.Visible = false;
        }

        private void btnViewChart_Click(object sender, EventArgs e)
        {
            toRun("LumenBuddy-Chart.exe", "LumenBuddy Chart " + encrypt(password));
        }

        private void lbxGamesHappy_DoubleClick(object sender, EventArgs e)
        {
            toRun("flashplayer11.exe", "Games\\" + lbxGamesHappy.Text.Replace(' ', '_') + ".swf");
            lbxGamesHappy.Visible = false;
        }

        private void lbxGames_DoubleClick(object sender, EventArgs e)
        {
            toRun("flashplayer11.exe", "Games\\" + lbxGames.Text.Replace(' ', '_') + ".swf");
            lbxGames.Visible = false;
        }

        private void rTxtHistory_TextChanged(object sender, EventArgs e)
        {
            rTxtHistory.Select(rTxtHistory.Text.Length, 0);
            rTxtHistory.ScrollToCaret();
        }

        private void lbxMusic_DoubleClick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Music\\" + lbxMusic.Text + ".mp3";
            lbxMusic.Visible = false;
        }

        private void picCat_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panelForm.Width = this.Width;
            panelForm.Height = this.Height;
            if (this.Width > 990)
                rTxtHistory.Width = this.Width - rTxtHistory.Left - 35;
            if (this.Height > 600)
            {
                txtQuestion.Height = btnSend.Top - txtQuestion.Top - 10;
                rTxtResponse.Height = this.Height - rTxtResponse.Top - 100;
                rTxtHistory.Height = this.Height - rTxtHistory.Top - 100;
                lbxMusic.Height = this.Height - lbxMusic.Top - 100;
            }
        }

        private void timerNameList_Tick(object sender, EventArgs e)
        {
            int p;
            string s = "Copyright (c)\r\n";
            string[] slist = { "Yip Tsz Ching (23075378D)", "Bu Sin Tung (23022183D)", "NG Ka Yi (23077427D)", "Tai King Hang (24138401D)" };
            for (int i = 0; i < slist.Length; i++)
            {
                do
                {
                    p = rand.Next(0, 4);
                } while (slist[p].Length == 0);
                s += slist[p];
                if (i < 3) s += "\r\n";
                slist[p] = "";
            }
            lblNameList.Text = s;
        }

        private void txtQuestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnNoAI.PerformClick();
            }
        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            string s = txtQuestion.Text;
            int p = s.IndexOf("\r\n");
            if (p >= 0)
                txtQuestion.Text = s.Substring(0, p) + s.Substring(p + 2);
        }
    }
}
