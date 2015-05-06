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
            this.refine = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.timerAutoClick = new System.Windows.Forms.Timer(this.components);
            this.loadingText = new System.Windows.Forms.Label();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.downloadedTemp = new System.Windows.Forms.TextBox();
            this.clicksPerSecondText = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
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
            this.buttonSeed.Location = new System.Drawing.Point(170, 166);
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
            this.labelSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeed.Location = new System.Drawing.Point(269, 243);
            this.labelSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeed.Name = "labelSeed";
            this.labelSeed.Size = new System.Drawing.Size(36, 25);
            this.labelSeed.TabIndex = 2;
            this.labelSeed.Text = "30";
            this.labelSeed.Visible = false;
            // 
            // timerSeed
            // 
            this.timerSeed.Interval = 1000;
            this.timerSeed.Tick += new System.EventHandler(this.timerSeed_Tick);
            // 
            // refine
            // 
            this.refine.BackColor = System.Drawing.Color.Black;
            this.refine.ForeColor = System.Drawing.Color.White;
            this.refine.Location = new System.Drawing.Point(427, 14);
            this.refine.Margin = new System.Windows.Forms.Padding(4);
            this.refine.Name = "refine";
            this.refine.Size = new System.Drawing.Size(141, 26);
            this.refine.TabIndex = 4;
            this.refine.Text = "Refine Autoclicker";
            this.refine.UseVisualStyleBackColor = false;
            this.refine.Visible = false;
            this.refine.Click += new System.EventHandler(this.refine_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(45, 60);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(457, 15);
            this.instructionsLabel.TabIndex = 5;
            this.instructionsLabel.Text = "Move your mouse to center of where you want to click and press ` to start/stop";
            this.instructionsLabel.Visible = false;
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
            this.loadingText.Location = new System.Drawing.Point(137, 146);
            this.loadingText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loadingText.Name = "loadingText";
            this.loadingText.Size = new System.Drawing.Size(314, 72);
            this.loadingText.TabIndex = 8;
            this.loadingText.Text = "Loading...";
            // 
            // webControl1
            // 
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Size = new System.Drawing.Size(0, 0);
            this.webControl1.TabIndex = 0;
            // 
            // downloadedTemp
            // 
            this.downloadedTemp.Location = new System.Drawing.Point(13, 138);
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
            this.webBrowser1.Size = new System.Drawing.Size(589, 364);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 364);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.refine);
            this.Controls.Add(this.clicksPerSecondText);
            this.Controls.Add(this.downloadedTemp);
            this.Controls.Add(this.labelSeed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSeed);
            this.Controls.Add(this.loadingText);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DG Smart AutoClicker 0.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSeed;
        private System.Windows.Forms.Label labelSeed;
        private System.Windows.Forms.Timer timerSeed;
        private System.Windows.Forms.Button refine;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Timer timerAutoClick;
        private System.Windows.Forms.Label loadingText;
        private Awesomium.Windows.Forms.WebControl webControl1;
        private System.Windows.Forms.TextBox downloadedTemp;
        private System.Windows.Forms.TextBox clicksPerSecondText;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

