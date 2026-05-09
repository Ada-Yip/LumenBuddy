namespace AI_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            StripMenu_Name = new ToolStripMenuItem();
            StripMenu_Password = new ToolStripMenuItem();
            StripMenu_View = new ToolStripMenuItem();
            StripMenu_Remove = new ToolStripMenuItem();
            StripMenu_Online = new ToolStripMenuItem();
            MenuItem_About = new ToolStripMenuItem();
            StripMenu_Exit = new ToolStripMenuItem();
            panelForm = new Panel();
            panelAbout = new Panel();
            btnAbout_OK = new Button();
            lblNameList = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            lblAbout = new Label();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            btnViewChart = new Button();
            lbxMusic = new ListBox();
            txtDate = new TextBox();
            lbxGamesHappy = new ListBox();
            lbxGames = new ListBox();
            rTxtHistory = new RichTextBox();
            btnPlayGame = new Button();
            rTxtResponse = new RichTextBox();
            lblResponse = new Label();
            txtQuestion = new TextBox();
            lblQuestion = new Label();
            btnPlayMusic = new Button();
            btnSend = new Button();
            btnNoAI = new Button();
            panelCat = new Panel();
            picCat = new PictureBox();
            timerCatPic = new System.Windows.Forms.Timer(components);
            timerCatMove = new System.Windows.Forms.Timer(components);
            timerResponse = new System.Windows.Forms.Timer(components);
            panelInput = new Panel();
            btnInputCancel = new Button();
            btnInputOK = new Button();
            txtInput = new TextBox();
            lblInput = new Label();
            timerNameList = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            panelForm.SuspendLayout();
            panelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            panelCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCat).BeginInit();
            panelInput.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(255, 128, 0);
            menuStrip1.Enabled = false;
            menuStrip1.Font = new Font("DFKai-SB", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { StripMenu_Name, StripMenu_Password, StripMenu_View, StripMenu_Remove, StripMenu_Online, MenuItem_About, StripMenu_Exit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 2, 0, 2);
            menuStrip1.Size = new Size(1264, 29);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // StripMenu_Name
            // 
            StripMenu_Name.Font = new Font("DFKai-SB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            StripMenu_Name.Name = "StripMenu_Name";
            StripMenu_Name.Size = new Size(121, 25);
            StripMenu_Name.Text = "Your Name";
            StripMenu_Name.Click += StripMenu_Name_Click;
            // 
            // StripMenu_Password
            // 
            StripMenu_Password.Font = new Font("DFKai-SB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            StripMenu_Password.Name = "StripMenu_Password";
            StripMenu_Password.Size = new Size(154, 25);
            StripMenu_Password.Text = "Set Password";
            StripMenu_Password.Click += StripMenu_Password_Click;
            // 
            // StripMenu_View
            // 
            StripMenu_View.Font = new Font("DFKai-SB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            StripMenu_View.Name = "StripMenu_View";
            StripMenu_View.Size = new Size(132, 25);
            StripMenu_View.Text = "Mood Diary";
            StripMenu_View.Click += StripMenu_View_Click;
            // 
            // StripMenu_Remove
            // 
            StripMenu_Remove.Font = new Font("DFKai-SB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            StripMenu_Remove.Name = "StripMenu_Remove";
            StripMenu_Remove.Size = new Size(176, 25);
            StripMenu_Remove.Text = "Remove Records";
            StripMenu_Remove.Click += StripMenu_Remove_Click;
            // 
            // StripMenu_Online
            // 
            StripMenu_Online.Font = new Font("DFKai-SB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            StripMenu_Online.Name = "StripMenu_Online";
            StripMenu_Online.Size = new Size(176, 25);
            StripMenu_Online.Text = "Online Version";
            StripMenu_Online.Click += StripMenu_Online_Click;
            // 
            // MenuItem_About
            // 
            MenuItem_About.Font = new Font("DFKai-SB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            MenuItem_About.Name = "MenuItem_About";
            MenuItem_About.Size = new Size(110, 25);
            MenuItem_About.Text = "About Me";
            MenuItem_About.Click += MenuItem_About_Click;
            // 
            // StripMenu_Exit
            // 
            StripMenu_Exit.Font = new Font("DFKai-SB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            StripMenu_Exit.Name = "StripMenu_Exit";
            StripMenu_Exit.Size = new Size(66, 25);
            StripMenu_Exit.Text = "Exit";
            StripMenu_Exit.Click += StripMenu_Exit_Click;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(panelAbout);
            panelForm.Controls.Add(axWindowsMediaPlayer1);
            panelForm.Controls.Add(btnViewChart);
            panelForm.Controls.Add(lbxMusic);
            panelForm.Controls.Add(txtDate);
            panelForm.Controls.Add(lbxGamesHappy);
            panelForm.Controls.Add(lbxGames);
            panelForm.Controls.Add(rTxtHistory);
            panelForm.Controls.Add(btnPlayGame);
            panelForm.Controls.Add(rTxtResponse);
            panelForm.Controls.Add(lblResponse);
            panelForm.Controls.Add(txtQuestion);
            panelForm.Controls.Add(lblQuestion);
            panelForm.Controls.Add(btnPlayMusic);
            panelForm.Controls.Add(btnSend);
            panelForm.Controls.Add(btnNoAI);
            panelForm.Controls.Add(panelCat);
            panelForm.Location = new Point(0, 33);
            panelForm.Margin = new Padding(2);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1280, 700);
            panelForm.TabIndex = 6;
            panelForm.Visible = false;
            panelForm.MouseLeave += panelForm_MouseLeave;
            panelForm.MouseMove += panelForm_MouseMove;
            // 
            // panelAbout
            // 
            panelAbout.BackgroundImage = LumenBuddy.Properties.Resources.WhatsApp_Image_2025_11_25_at_6_39_45_PM;
            panelAbout.BackgroundImageLayout = ImageLayout.None;
            panelAbout.BorderStyle = BorderStyle.Fixed3D;
            panelAbout.Controls.Add(btnAbout_OK);
            panelAbout.Controls.Add(lblNameList);
            panelAbout.Controls.Add(label3);
            panelAbout.Controls.Add(label1);
            panelAbout.Controls.Add(label2);
            panelAbout.Controls.Add(lblAbout);
            panelAbout.Location = new Point(388, 56);
            panelAbout.Margin = new Padding(2);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(503, 504);
            panelAbout.TabIndex = 9;
            panelAbout.Visible = false;
            // 
            // btnAbout_OK
            // 
            btnAbout_OK.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbout_OK.Location = new Point(425, 460);
            btnAbout_OK.Margin = new Padding(2);
            btnAbout_OK.Name = "btnAbout_OK";
            btnAbout_OK.Size = new Size(72, 37);
            btnAbout_OK.TabIndex = 5;
            btnAbout_OK.Text = "OK";
            btnAbout_OK.UseVisualStyleBackColor = true;
            btnAbout_OK.Click += btnAbout_OK_Click;
            // 
            // lblNameList
            // 
            lblNameList.BackColor = Color.Transparent;
            lblNameList.Font = new Font("DFKai-SB", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblNameList.ForeColor = Color.FromArgb(192, 64, 0);
            lblNameList.Location = new Point(142, 411);
            lblNameList.Margin = new Padding(2, 0, 2, 0);
            lblNameList.Name = "lblNameList";
            lblNameList.Size = new Size(215, 86);
            lblNameList.TabIndex = 4;
            lblNameList.Text = "Copyright (c)\r\nYip Tsz Ching (23075378D)\r\nBu Sin Tung (23022183D)\r\nNG Ka Yi (23077427D)\r\nTai King Hang (24138401D)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cambria", 15.75F);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(3, 105);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 3;
            label3.Text = "Version 1.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 15.75F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(3, 74);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 2;
            label1.Text = "23 Nov 2025";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 15.75F);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(3, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 1;
            label2.Text = "Lumen Buddy";
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.BackColor = Color.Transparent;
            lblAbout.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbout.ForeColor = Color.Fuchsia;
            lblAbout.Location = new Point(163, 3);
            lblAbout.Margin = new Padding(2, 0, 2, 0);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(173, 41);
            lblAbout.TabIndex = 0;
            lblAbout.Text = "About Me";
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(1228, 596);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(36, 34);
            axWindowsMediaPlayer1.TabIndex = 22;
            axWindowsMediaPlayer1.Visible = false;
            // 
            // btnViewChart
            // 
            btnViewChart.Font = new Font("DFKai-SB", 15.75F);
            btnViewChart.Location = new Point(450, 257);
            btnViewChart.Margin = new Padding(2);
            btnViewChart.Name = "btnViewChart";
            btnViewChart.Size = new Size(135, 32);
            btnViewChart.TabIndex = 21;
            btnViewChart.Text = "View Chart";
            btnViewChart.UseVisualStyleBackColor = true;
            btnViewChart.Visible = false;
            btnViewChart.Click += btnViewChart_Click;
            btnViewChart.MouseLeave += btnViewChart_MouseLeave;
            // 
            // lbxMusic
            // 
            lbxMusic.BackColor = Color.Black;
            lbxMusic.Font = new Font("DFKai-SB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbxMusic.ForeColor = Color.White;
            lbxMusic.FormattingEnabled = true;
            lbxMusic.Location = new Point(165, 177);
            lbxMusic.Margin = new Padding(2);
            lbxMusic.Name = "lbxMusic";
            lbxMusic.Size = new Size(420, 436);
            lbxMusic.TabIndex = 18;
            lbxMusic.Visible = false;
            lbxMusic.DoubleClick += lbxMusic_DoubleClick;
            lbxMusic.MouseLeave += lbxMusic_MouseLeave;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.Black;
            txtDate.BorderStyle = BorderStyle.None;
            txtDate.Font = new Font("DFKai-SB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txtDate.ForeColor = Color.White;
            txtDate.Location = new Point(436, 8);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(147, 26);
            txtDate.TabIndex = 17;
            txtDate.TextAlign = HorizontalAlignment.Right;
            txtDate.KeyPress += txtDate_KeyPress;
            // 
            // lbxGamesHappy
            // 
            lbxGamesHappy.BackColor = Color.Black;
            lbxGamesHappy.Font = new Font("DFKai-SB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbxGamesHappy.ForeColor = Color.White;
            lbxGamesHappy.FormattingEnabled = true;
            lbxGamesHappy.Items.AddRange(new object[] { "Age of Defense 8", "Age of War", "Batman Gotham City Rush", "Bloons", "Bloxorz", "Checkers", "Commando 2", "Empires of Arkeia", "Mad Arrow", "Mineblocks Minecraft Flash", "Minesweeper", "Papas Pizzeria", "Super Mario Flash", "Super Mario Flash 2", "Tetris", "Toxic 2" });
            lbxGamesHappy.Location = new Point(165, 137);
            lbxGamesHappy.Margin = new Padding(2);
            lbxGamesHappy.Name = "lbxGamesHappy";
            lbxGamesHappy.Size = new Size(420, 436);
            lbxGamesHappy.TabIndex = 14;
            lbxGamesHappy.Visible = false;
            lbxGamesHappy.DoubleClick += lbxGamesHappy_DoubleClick;
            lbxGamesHappy.MouseLeave += lbxGamesHappy_MouseLeave;
            // 
            // lbxGames
            // 
            lbxGames.BackColor = Color.Black;
            lbxGames.Font = new Font("DFKai-SB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbxGames.ForeColor = Color.White;
            lbxGames.FormattingEnabled = true;
            lbxGames.Items.AddRange(new object[] { "Animator", "Animator 2", "Bloons Tower Defence 2", "Dad n Me", "Doom", "Duck Life", "Fish Tales 2", "Jungle Blocks", "Penguin Diner", "Penguin Diner 2", "PC Breakdown", "Pocket Fighter Nova", "Stickmin Breaking the Bank", "Stickmin Escaping the Prison", "Super Mario 63", "Turtle" });
            lbxGames.Location = new Point(165, 137);
            lbxGames.Margin = new Padding(2);
            lbxGames.Name = "lbxGames";
            lbxGames.Size = new Size(420, 436);
            lbxGames.TabIndex = 13;
            lbxGames.Visible = false;
            lbxGames.DoubleClick += lbxGames_DoubleClick;
            lbxGames.MouseLeave += lbxGames_MouseLeave;
            // 
            // rTxtHistory
            // 
            rTxtHistory.BackColor = Color.Black;
            rTxtHistory.Font = new Font("DFKai-SB", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            rTxtHistory.ForeColor = Color.White;
            rTxtHistory.Location = new Point(611, 11);
            rTxtHistory.Margin = new Padding(2);
            rTxtHistory.Name = "rTxtHistory";
            rTxtHistory.Size = new Size(644, 619);
            rTxtHistory.TabIndex = 11;
            rTxtHistory.Text = "";
            rTxtHistory.TextChanged += rTxtHistory_TextChanged;
            // 
            // btnPlayGame
            // 
            btnPlayGame.Font = new Font("DFKai-SB", 15.75F);
            btnPlayGame.Location = new Point(12, 137);
            btnPlayGame.Margin = new Padding(2);
            btnPlayGame.Name = "btnPlayGame";
            btnPlayGame.Size = new Size(135, 32);
            btnPlayGame.TabIndex = 9;
            btnPlayGame.Text = "Play Game";
            btnPlayGame.UseVisualStyleBackColor = true;
            btnPlayGame.Visible = false;
            btnPlayGame.Click += btnPlayGame_Click;
            // 
            // rTxtResponse
            // 
            rTxtResponse.BackColor = Color.Black;
            rTxtResponse.Font = new Font("DFKai-SB", 15.75F);
            rTxtResponse.ForeColor = Color.White;
            rTxtResponse.Location = new Point(12, 294);
            rTxtResponse.Margin = new Padding(2);
            rTxtResponse.Name = "rTxtResponse";
            rTxtResponse.Size = new Size(573, 336);
            rTxtResponse.TabIndex = 8;
            rTxtResponse.Text = "";
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.Font = new Font("DFKai-SB", 15.75F);
            lblResponse.ForeColor = Color.White;
            lblResponse.Location = new Point(12, 262);
            lblResponse.Margin = new Padding(2, 0, 2, 0);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new Size(109, 21);
            lblResponse.TabIndex = 7;
            lblResponse.Text = "Response:";
            // 
            // txtQuestion
            // 
            txtQuestion.BackColor = Color.Black;
            txtQuestion.Font = new Font("DFKai-SB", 15.75F);
            txtQuestion.ForeColor = Color.White;
            txtQuestion.Location = new Point(12, 41);
            txtQuestion.Margin = new Padding(2);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(573, 85);
            txtQuestion.TabIndex = 6;
            txtQuestion.TextChanged += txtQuestion_TextChanged;
            txtQuestion.KeyPress += txtQuestion_KeyPress;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("DFKai-SB", 15.75F);
            lblQuestion.ForeColor = Color.White;
            lblQuestion.Location = new Point(12, 11);
            lblQuestion.Margin = new Padding(2, 0, 2, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(109, 21);
            lblQuestion.TabIndex = 5;
            lblQuestion.Text = "Question:";
            // 
            // btnPlayMusic
            // 
            btnPlayMusic.Font = new Font("DFKai-SB", 15.75F);
            btnPlayMusic.Location = new Point(235, 137);
            btnPlayMusic.Margin = new Padding(2);
            btnPlayMusic.Name = "btnPlayMusic";
            btnPlayMusic.Size = new Size(135, 32);
            btnPlayMusic.TabIndex = 15;
            btnPlayMusic.Text = "Play Music";
            btnPlayMusic.UseVisualStyleBackColor = true;
            btnPlayMusic.Visible = false;
            btnPlayMusic.Click += btnPlayMusic_Click;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("DFKai-SB", 15.75F);
            btnSend.Location = new Point(450, 137);
            btnSend.Margin = new Padding(2);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(135, 32);
            btnSend.TabIndex = 16;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnNoAI
            // 
            btnNoAI.BackColor = Color.FromArgb(255, 128, 255);
            btnNoAI.Location = new Point(450, 176);
            btnNoAI.Name = "btnNoAI";
            btnNoAI.Size = new Size(135, 51);
            btnNoAI.TabIndex = 20;
            btnNoAI.Text = "Send\r\n(AI Simulator)";
            btnNoAI.UseVisualStyleBackColor = false;
            btnNoAI.Click += btnNoAI_Click;
            // 
            // panelCat
            // 
            panelCat.Controls.Add(picCat);
            panelCat.Location = new Point(280, 210);
            panelCat.Margin = new Padding(2);
            panelCat.Name = "panelCat";
            panelCat.Size = new Size(32, 30);
            panelCat.TabIndex = 12;
            panelCat.Visible = false;
            // 
            // picCat
            // 
            picCat.Image = LumenBuddy.Properties.Resources.Cat;
            picCat.Location = new Point(0, 0);
            picCat.Margin = new Padding(2);
            picCat.Name = "picCat";
            picCat.Size = new Size(578, 30);
            picCat.SizeMode = PictureBoxSizeMode.AutoSize;
            picCat.TabIndex = 0;
            picCat.TabStop = false;
            picCat.Click += picCat_Click;
            // 
            // timerCatPic
            // 
            timerCatPic.Interval = 300;
            timerCatPic.Tick += timerCatPic_Tick;
            // 
            // timerCatMove
            // 
            timerCatMove.Interval = 50;
            timerCatMove.Tick += timerCatMove_Tick;
            // 
            // timerResponse
            // 
            timerResponse.Interval = 1;
            timerResponse.Tick += timerResponse_Tick;
            // 
            // panelInput
            // 
            panelInput.BorderStyle = BorderStyle.Fixed3D;
            panelInput.Controls.Add(btnInputCancel);
            panelInput.Controls.Add(btnInputOK);
            panelInput.Controls.Add(txtInput);
            panelInput.Controls.Add(lblInput);
            panelInput.Location = new Point(0, 33);
            panelInput.Margin = new Padding(2);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(364, 192);
            panelInput.TabIndex = 8;
            // 
            // btnInputCancel
            // 
            btnInputCancel.Font = new Font("DFKai-SB", 15.75F);
            btnInputCancel.Location = new Point(214, 129);
            btnInputCancel.Margin = new Padding(2);
            btnInputCancel.Name = "btnInputCancel";
            btnInputCancel.Size = new Size(96, 28);
            btnInputCancel.TabIndex = 3;
            btnInputCancel.Text = "Cancel";
            btnInputCancel.UseVisualStyleBackColor = true;
            btnInputCancel.Click += btnInputCancel_Click;
            // 
            // btnInputOK
            // 
            btnInputOK.Font = new Font("DFKai-SB", 15.75F);
            btnInputOK.Location = new Point(51, 129);
            btnInputOK.Margin = new Padding(2);
            btnInputOK.Name = "btnInputOK";
            btnInputOK.Size = new Size(96, 28);
            btnInputOK.TabIndex = 2;
            btnInputOK.Text = "OK";
            btnInputOK.UseVisualStyleBackColor = true;
            btnInputOK.Click += btnInputOK_Click;
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.Black;
            txtInput.Font = new Font("DFKai-SB", 15.75F);
            txtInput.ForeColor = Color.White;
            txtInput.Location = new Point(21, 71);
            txtInput.Margin = new Padding(2);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(314, 33);
            txtInput.TabIndex = 1;
            txtInput.KeyPress += txtInput_KeyPress;
            // 
            // lblInput
            // 
            lblInput.Font = new Font("DFKai-SB", 15.75F);
            lblInput.ForeColor = Color.White;
            lblInput.Location = new Point(16, 21);
            lblInput.Margin = new Padding(2, 0, 2, 0);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(319, 57);
            lblInput.TabIndex = 0;
            lblInput.Text = "Input:";
            // 
            // timerNameList
            // 
            timerNameList.Interval = 5000;
            timerNameList.Tick += timerNameList_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = LumenBuddy.Properties.Resources.WhatsApp_Image_2025_11_25_at_6_39_45_PM;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelInput);
            Controls.Add(menuStrip1);
            Controls.Add(panelForm);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lumen Buddy - An Emotional Support AI Chatbot - Your little light of hope, always here to listen";
            Load += Form1_Load;
            Resize += Form1_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelAbout.ResumeLayout(false);
            panelAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            panelCat.ResumeLayout(false);
            panelCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCat).EndInit();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem StripMenu_Name;
        private ToolStripMenuItem StripMenu_Password;
        private ToolStripMenuItem StripMenu_Remove;
        private ToolStripMenuItem StripMenu_Exit;
        private Panel panelForm;
        private RichTextBox rTxtResponse;
        private Label lblResponse;
        private TextBox txtQuestion;
        private Label lblQuestion;
        private Button btnPlayGame;
        private RichTextBox rTxtHistory;
        private Panel panelCat;
        private PictureBox picCat;
        private System.Windows.Forms.Timer timerCatPic;
        private System.Windows.Forms.Timer timerCatMove;
        private ListBox lbxGames;
        private ListBox lbxGamesHappy;
        private ToolStripMenuItem StripMenu_View;
        private ToolStripMenuItem StripMenu_Online;
        private ToolStripMenuItem MenuItem_About;
        private Panel panelAbout;
        private Label lblAbout;
        private Label label2;
        private Label lblNameList;
        private Label label3;
        private Label label1;
        private Button btnAbout_OK;
        private System.Windows.Forms.Timer timerResponse;
        private Button btnPlayMusic;
        private Button btnSend;
        private Panel panelInput;
        private Button btnInputCancel;
        private Button btnInputOK;
        private TextBox txtInput;
        private Label lblInput;
        private TextBox txtDate;
        private ListBox lbxMusic;
        private Button btnNoAI;
        private Button btnViewChart;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timerNameList;
    }
}
