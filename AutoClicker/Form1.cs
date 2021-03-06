﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace AutoClicker
{

    public partial class Form1 : Form
    {
        //Code for changing webBrowser User Agent
        private static void WebBrowserVersionEmulation()
        {
            const string BROWSER_EMULATION_KEY =
            @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
            //
            // app.exe and app.vshost.exe
            String appname = Process.GetCurrentProcess().ProcessName + ".exe";
            //
            // Webpages are displayed in IE9 Standards mode, regardless of the !DOCTYPE directive.
            const int browserEmulationMode = 9999;

            RegistryKey browserEmulationKey =
                Registry.CurrentUser.OpenSubKey(BROWSER_EMULATION_KEY, RegistryKeyPermissionCheck.ReadWriteSubTree) ??
                Registry.CurrentUser.CreateSubKey(BROWSER_EMULATION_KEY);

            if (browserEmulationKey != null)
            {
                browserEmulationKey.SetValue(appname, browserEmulationMode, RegistryValueKind.DWord);
                browserEmulationKey.Close();
            }
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Function to find tags inside a string
        string ExtractString(string s, string tag)
        {
            // No error checking
            var startTag = tag;
            int startIndex = s.IndexOf(startTag) + startTag.Length;
            int endIndex = s.IndexOf(tag, startIndex);
            return s.Substring(startIndex, endIndex - startIndex);
        }


        Hotkey hk = new Hotkey();
        //Variable for mydocuments
        String myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Directory if it doesn't exist
            System.IO.Directory.CreateDirectory(myDocuments + @"\DG\AutoClicker");
            //Hide Javascript error and change the UserAgent to be Internet Explorer 9
            webBrowser1.ScriptErrorsSuppressed = true;
            WebBrowserVersionEmulation();

            loadingText.BringToFront();

            //Perfect size to show all of the webpage
            this.Size = new Size(336, 396);
            webBrowser1.Navigate("http://mossaband.com/AutoClicker/login.html");
            //Setting GlobalHotKey
            hk.KeyCode = Keys.Oemtilde;
            hk.Windows = true;
            hk.Pressed += hk_Pressed;
            hk.Register(this);
        }

        //Start Autoclicker
        private void hk_Pressed(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(downloadedTemp.Text))
            {
                //downloadTemp.Text contains the temperature
                //If it's less than 50 degrees (COLD), click slower.
                if (Convert.ToDecimal(downloadedTemp.Text) <= 50)
                {
                    //The ClicksPerSecond is saved as a decimal.
                    //Converting it to string
                    string[] autoclickInterval = Convert.ToString((1100 / Convert.ToDecimal(clicksPerSecondText.Text))).Split('.');
                    clicksPerSecondText.Text = autoclickInterval[0];
                    timerAutoClick.Interval = Convert.ToInt32(clicksPerSecondText.Text);
                }
                //If it's more than 50 degrees (HOT).
                else
                {
                    string[] autoclickInterval = Convert.ToString((1000 / Convert.ToDecimal(clicksPerSecondText.Text))).Split('.');
                    clicksPerSecondText.Text = autoclickInterval[0];
                    timerAutoClick.Interval = Convert.ToInt32(clicksPerSecondText.Text);
                }
                if (!timerAutoClick.Enabled)
                {
                    int setInterval = rndm.Next(2000, 5000);
                    timerAutoClick.Start();
                    setAutoClickInterval.Interval = setInterval;
                    setAutoClickInterval.Start();
                }
                else if (timerAutoClick.Enabled)
                {
                    timerAutoClick.Stop();
                    setAutoClickInterval.Stop();
                }
                this.Cursor = new Cursor(Cursor.Current.Handle);
                xCoord.Text = Convert.ToString(Cursor.Position.X);
                yCoord.Text = Convert.ToString(Cursor.Position.Y);
            }
        }

        //Calibrate personal Clicks Per Second for 30 seconds
        double clicks = 0;
        private void buttonClickFast_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelSeed.Text) > 0)
            {
                clicks = clicks + 1;
            }
            if (!timerSeed.Enabled)
            {
                timerSeed.Start();
            }
        }

        private void timerSeed_Tick(object sender, EventArgs e)
        {
            //Make sure timer doesn't go below 0, and when it des hit 0. Stop adding to coujnter
            if (Convert.ToInt32(labelSeed.Text) > 0)
            {
                labelSeed.Text = Convert.ToString(Convert.ToInt32(labelSeed.Text) - 1);
            }
            else if (Convert.ToInt32(labelSeed.Text) <= 0)
            {
                buttonSeed.Visible = false;
                labelSeed.Visible = false;
                instructionsText.Visible = true;
                timerSeed.Stop();
                //Diving by 30 to get Clicks Per Second
                clicksPerSecondText.Text = Convert.ToString(clicks / 30);
                //Write that value inside Settings.txt
                File.WriteAllText(myDocuments + @"\DG\AutoClicker\Settings.txt", clicksPerSecondText.Text);
            }
        }

        //Redo Clicks Per Second
        private void refine_Click(object sender, EventArgs e)
        {
            labelSeed.Text = "30";
            buttonSeed.Visible = true;
            labelSeed.Visible = true;
            clicksPerSecondText.Visible = true;
            instructionsText.Visible = true;
            labelSeed.Visible = true;
        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            loadingText.Visible = false;
            if (webBrowser1.DocumentTitle.Contains("Login"))
            {
                //If this is the Login page, change the size of the form
                this.Size = new Size(336, 462);
            }
            else if (webBrowser1.DocumentTitle.Contains("Create"))
            {
                //If this is the Create an Account page, change the size of the form
                this.Size = new Size(336, 655);
            }
            //This is the page after the User Logs in
            else if (webBrowser1.DocumentText.Contains("ZZ"))
            {

                webBrowser1.Visible = false;

                string html = webBrowser1.DocumentText;
                //The zipcode is between two 'ZZ'
                string zipcode = ExtractString(html, "ZZ");
                //The countrycode is between two 'CC'
                string countrycode = ExtractString(html, "CC");

                //There's a GOTO only because the website fails to load occasionally
            GetTemp:

                int retry = 0;
                try
                {
                    WebClient Weather = new WebClient();
                    //Plugin the zipcode and countrycode we found on the login page
                    string htmlWeather = Weather.DownloadString("http://api.openweathermap.org/data/2.5/weather?zip=" + zipcode + "," + countrycode + "&units=imperial");
                    MatchCollection temperature = Regex.Matches(htmlWeather, "\"temp\":(\\d*.\\d)", RegexOptions.Singleline);

                    foreach (Match currentTemp in temperature)
                    {
                        downloadedTemp.Text = currentTemp.Value;
                    }
                    string temp = downloadedTemp.Text;
                    downloadedTemp.Text = temp.Remove(0, 7);
                    this.Size = new Size(537, 124);

                    //Create Settings.txt if it doesn't exist
                    if (!File.Exists(myDocuments + @"\DG\AutoClicker\Settings.txt"))
                    {
                        FileStream createSettingsTXT = new FileStream(myDocuments + @"\DG\AutoClicker\Settings.txt", FileMode.CreateNew);
                        createSettingsTXT.Close();
                        buttonSeed.Visible = true;
                        labelSeed.Visible = true;
                    }
                    //If Settings.txt already exists, that means they went ahead and calibrated their clicks per second already
                    else
                    {
                        //refineclickButton.Visible = true;
                        instructionsText.Visible = true;
                        string readSettingsTXT = File.ReadAllText(myDocuments + @"\DG\AutoClicker\Settings.txt");
                        clicksPerSecondText.Text = readSettingsTXT;
                    }
                }
                catch (Exception ex)
                {
                    //Attempt to get the temperature 3 times before GTFO
                    if (retry <= 3)
                    {
                        goto GetTemp;
                    }
                    DialogResult res = MessageBox.Show("Can't get Account Information:\n" + ex.Message, "Error",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.Retry)
                    {
                        goto GetTemp;
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        MessageBox.Show("Please send an email to Daniel@Mossaband.com regarding the issue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }
            }
        }

        Random rndm = new Random();
        private void timerAutoClick_Tick(object sender, EventArgs e)
        {
            int xRandomNum = rndm.Next(-2, 2);
            int yRandomNum = rndm.Next(-2, 2);
            Cursor.Position = new Point(Convert.ToInt32(xCoord.Text) + xRandomNum, Convert.ToInt32(yCoord.Text) + yRandomNum);
            DoMouseClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hk.Registered)
            { hk.Unregister(); }
        }

        private void setAutoClickInterval_Tick(object sender, EventArgs e)
        {
        setInterval:
            try
            {
                int setAutoClickInterval = rndm.Next(-100, 100);
                timerAutoClick.Interval = Convert.ToInt32(clicksPerSecondText.Text) + setAutoClickInterval;
            }
            catch (Exception)
            {

                goto setInterval;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoMouseClick();
        }


    }
}
