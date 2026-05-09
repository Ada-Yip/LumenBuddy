namespace AI_Chart
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Return = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myNameToolStripMenuItem,
            this.passwordToolStripMenuItem,
            this.viewRecordsToolStripMenuItem,
            this.deleteRecordsToolStripMenuItem,
            this.onlineVersionToolStripMenuItem,
            this.aboutMeToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.MenuItem_Return});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(913, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myNameToolStripMenuItem
            // 
            this.myNameToolStripMenuItem.Enabled = false;
            this.myNameToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myNameToolStripMenuItem.Name = "myNameToolStripMenuItem";
            this.myNameToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.myNameToolStripMenuItem.Text = "Your Name";
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.Enabled = false;
            this.passwordToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.passwordToolStripMenuItem.Text = "Set Password";
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.Enabled = false;
            this.viewRecordsToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.viewRecordsToolStripMenuItem.Text = "Mood Diary";
            // 
            // deleteRecordsToolStripMenuItem
            // 
            this.deleteRecordsToolStripMenuItem.Enabled = false;
            this.deleteRecordsToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRecordsToolStripMenuItem.Name = "deleteRecordsToolStripMenuItem";
            this.deleteRecordsToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.deleteRecordsToolStripMenuItem.Text = "Delete Records";
            // 
            // onlineVersionToolStripMenuItem
            // 
            this.onlineVersionToolStripMenuItem.Enabled = false;
            this.onlineVersionToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineVersionToolStripMenuItem.Name = "onlineVersionToolStripMenuItem";
            this.onlineVersionToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.onlineVersionToolStripMenuItem.Text = "Online Version";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Enabled = false;
            this.aboutMeToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.aboutMeToolStripMenuItem.Text = "About Me";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Enabled = false;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MenuItem_Return
            // 
            this.MenuItem_Return.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItem_Return.Name = "MenuItem_Return";
            this.MenuItem_Return.Size = new System.Drawing.Size(65, 26);
            this.MenuItem_Return.Text = "Close";
            this.MenuItem_Return.Click += new System.EventHandler(this.MenuItem_Return_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 37);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(900, 453);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Chart";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(901, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(913, 499);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lumen Buddy - An Emotional Support AI Chatbot - Your little light of hope, always" +
    " here to listen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Return;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

