using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AI_Chart
{
    public partial class Form1 : Form
    {
        string username = "whoiam";
        string password = "";
        string[] argVal;

        public Form1(string[] argv)
        {
            argVal = argv;
            InitializeComponent();
        }

        private string encrypt(string s)
        {
            int i;
            Random rand = new Random();
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

        private void MenuItem_Return_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int argc = argVal.Length;
            //textBox1.Text = "arg: " + argc;
            //foreach (string a in argVal)
            //    textBox1.Text += " | " + a;

            try
            {
                StreamReader sr = new StreamReader("system.dat");
                string s = sr.ReadLine();
                //if (s.Length > 0) username = decrypt(s);
                s = sr.ReadLine();
                string pp = decrypt(s);
                if (s.Length > 0)
                {
                    if (argc < 3)
                        Application.Exit();

                    //textBox1.Text += " $ " + pp;
                    //textBox1.Text += " | " + decrypt(argVal[1]);

                    if (!pp.Equals(decrypt(argVal[argc-1])))
                        Application.Exit();
                }
                sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception)
            {
            }

            chart1.Width = this.Width - 30;
            chart1.Height = this.Height - 80;
            int n = 0;
            string date, cDate = "01-01-2025";
            int dayN = 0, dayScore = 0;

            try
            {
                StreamReader sr = new StreamReader("records.dat");
                chart1.Series[0].Points.Clear();
                while (!sr.EndOfStream)
                {
                    string s = decryptRecord(sr.ReadLine());
                    if (s[0] == '`')
                    {
                        if (s[1] == '^')
                        {
                            date = s.Substring(2);
                            if (n > 0 && date != cDate)
                                chart1.Series[0].Points.AddXY(cDate, Convert.ToDouble(dayScore) / Convert.ToDouble(dayN));
                            cDate = date;
                            dayN = 0;
                            dayScore = 0;
                        }
                        if (s[1] == '|')
                        {
                            dayScore += Convert.ToInt32(s.Substring(2));
                            dayN++;
                            n++;
                        }
                    }
                }
                sr.Close();
                double avg = Convert.ToDouble(dayScore) / Convert.ToDouble(dayN);
                chart1.Series[0].Points.AddXY(cDate, avg);
                chart1.Visible = true;
            }
            catch (Exception)
            {
            }
        }

    }
}
