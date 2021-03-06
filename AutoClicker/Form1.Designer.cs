﻿namespace AutoClicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSeed = new System.Windows.Forms.Button();
            this.labelSeed = new System.Windows.Forms.Label();
            this.timerSeed = new System.Windows.Forms.Timer(this.components);
            this.refineclickButton = new System.Windows.Forms.Button();
            this.timerAutoClick = new System.Windows.Forms.Timer(this.components);
            this.loadingText = new System.Windows.Forms.Label();
            this.downloadedTemp = new System.Windows.Forms.TextBox();
            this.clicksPerSecondText = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.instructionsText = new System.Windows.Forms.TextBox();
            this.xCoord = new System.Windows.Forms.TextBox();
            this.yCoord = new System.Windows.Forms.TextBox();
            this.setAutoClickInterval = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSeed
            // 
            this.buttonSeed.BackColor = System.Drawing.Color.Black;
            this.buttonSeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSeed.ForeColor = System.Drawing.Color.White;
            this.buttonSeed.Location = new System.Drawing.Point(150, 9);
            this.buttonSeed.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSeed.Name = "buttonSeed";
            this.buttonSeed.Size = new System.Drawing.Size(221, 66);
            this.buttonSeed.TabIndex = 1;
            this.buttonSeed.Text = "Click this button as fast as you can for 30 seconds";
            this.buttonSeed.UseVisualStyleBackColor = false;
            this.buttonSeed.Visible = false;
            this.buttonSeed.Click += new System.EventHandler(this.buttonClickFast_Click);
            // 
            // labelSeed
            // 
            this.labelSeed.AutoSize = true;
            this.labelSeed.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeed.Location = new System.Drawing.Point(40, 23);
            this.labelSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeed.Name = "labelSeed";
            this.labelSeed.Size = new System.Drawing.Size(55, 38);
            this.labelSeed.TabIndex = 2;
            this.labelSeed.Text = "30";
            this.labelSeed.Visible = false;
            // 
            // timerSeed
            // 
            this.timerSeed.Interval = 1000;
            this.timerSeed.Tick += new System.EventHandler(this.timerSeed_Tick);
            // 
            // refineclickButton
            // 
            this.refineclickButton.BackColor = System.Drawing.Color.Black;
            this.refineclickButton.ForeColor = System.Drawing.Color.White;
            this.refineclickButton.Location = new System.Drawing.Point(424, 37);
            this.refineclickButton.Margin = new System.Windows.Forms.Padding(4);
            this.refineclickButton.Name = "refineclickButton";
            this.refineclickButton.Size = new System.Drawing.Size(84, 45);
            this.refineclickButton.TabIndex = 4;
            this.refineclickButton.Text = "Refine Autoclicker";
            this.refineclickButton.UseVisualStyleBackColor = false;
            this.refineclickButton.Visible = false;
            this.refineclickButton.Click += new System.EventHandler(this.refine_Click);
            // 
            // timerAutoClick
            // 
            this.timerAutoClick.Tick += new System.EventHandler(this.timerAutoClick_Tick);
            // 
            // loadingText
            // 
            this.loadingText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingText.AutoSize = true;
            this.loadingText.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loadingText.Location = new System.Drawing.Point(103, 6);
            this.loadingText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loadingText.Name = "loadingText";
            this.loadingText.Size = new System.Drawing.Size(314, 72);
            this.loadingText.TabIndex = 8;
            this.loadingText.Text = "Loading...";
            // 
            // downloadedTemp
            // 
            this.downloadedTemp.Location = new System.Drawing.Point(0, 40);
            this.downloadedTemp.Margin = new System.Windows.Forms.Padding(4);
            this.downloadedTemp.Name = "downloadedTemp";
            this.downloadedTemp.Size = new System.Drawing.Size(132, 21);
            this.downloadedTemp.TabIndex = 6;
            this.downloadedTemp.Visible = false;
            // 
            // clicksPerSecondText
            // 
            this.clicksPerSecondText.Location = new System.Drawing.Point(13, 167);
            this.clicksPerSecondText.Margin = new System.Windows.Forms.Padding(4);
            this.clicksPerSecondText.Name = "clicksPerSecondText";
            this.clicksPerSecondText.ReadOnly = true;
            this.clicksPerSecondText.Size = new System.Drawing.Size(132, 21);
            this.clicksPerSecondText.TabIndex = 3;
            this.clicksPerSecondText.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(521, 85);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // instructionsText
            // 
            this.instructionsText.BackColor = System.Drawing.Color.White;
            this.instructionsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructionsText.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsText.Location = new System.Drawing.Point(12, 7);
            this.instructionsText.Multiline = true;
            this.instructionsText.Name = "instructionsText";
            this.instructionsText.ReadOnly = true;
            this.instructionsText.Size = new System.Drawing.Size(497, 71);
            this.instructionsText.TabIndex = 10;
            this.instructionsText.Text = "Move your mouse to the center of where you want to click and press WinKey + ` to " +
    "start/stop";
            this.instructionsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.instructionsText.Visible = false;
            // 
            // xCoord
            // 
            this.xCoord.Location = new System.Drawing.Point(12, 64);
            this.xCoord.Name = "xCoord";
            this.xCoord.Size = new System.Drawing.Size(25, 21);
            this.xCoord.TabIndex = 11;
            this.xCoord.Visible = false;
            // 
            // yCoord
            // 
            this.yCoord.Location = new System.Drawing.Point(44, 64);
            this.yCoord.Name = "yCoord";
            this.yCoord.Size = new System.Drawing.Size(24, 21);
            this.yCoord.TabIndex = 12;
            this.yCoord.Visible = false;
            // 
            // setAutoClickInterval
            // 
            this.setAutoClickInterval.Interval = 5000;
            this.setAutoClickInterval.Tick += new System.EventHandler(this.setAutoClickInterval_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 85);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yCoord);
            this.Controls.Add(this.xCoord);
            this.Controls.Add(this.refineclickButton);
            this.Controls.Add(this.clicksPerSecondText);
            this.Controls.Add(this.downloadedTemp);
            this.Controls.Add(this.labelSeed);
            this.Controls.Add(this.buttonSeed);
            this.Controls.Add(this.loadingText);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.instructionsText);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DG Smart AutoClicker 0.0.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSeed;
        private System.Windows.Forms.Label labelSeed;
        private System.Windows.Forms.Timer timerSeed;
        private System.Windows.Forms.Button refineclickButton;
        private System.Windows.Forms.Timer timerAutoClick;
        private System.Windows.Forms.Label loadingText;
        private System.Windows.Forms.TextBox downloadedTemp;
        private System.Windows.Forms.TextBox clicksPerSecondText;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox instructionsText;
        private System.Windows.Forms.TextBox xCoord;
        private System.Windows.Forms.TextBox yCoord;
        private System.Windows.Forms.Timer setAutoClickInterval;
    }
}

