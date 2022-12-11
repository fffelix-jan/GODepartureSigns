using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GODepartureSignList;

namespace GODepartureSigns
{
    public partial class MainForm : Form
    {
        readonly CultureInfo enCulture = new CultureInfo("en-US", false);
        readonly CultureInfo frCulture = new CultureInfo("fr-FR", false);

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Centers a control horizontally.
        /// </summary>
        /// <param name="ctrlToCenter">The control to center.</param>
        private void CenterControlHorizontally(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Making the table layout panel double buffered prevents it from flickering when it is redrawn.
            ControlDoubleBuffering.SetDoubleBuffered(tableLayoutPanel1);
            // Set the language to English
            GlobalSettings.CurrentLanguage = ScreenLanguage.English;
        }

        // Function to refresh the date and time display
        private void refreshTime()
        {
            if (GlobalSettings.CurrentLanguage == ScreenLanguage.French)
                dateLabel.Text = DateTime.Now.ToString(frCulture.DateTimeFormat.LongDatePattern, frCulture);
            else
                dateLabel.Text = DateTime.Now.ToString(enCulture.DateTimeFormat.LongDatePattern, enCulture);
            clockLabel.Text = DateTime.Now.ToString("HH:mm");
            CenterControlHorizontally(dateLabel);
        }

        // Timer that refreshes the date and time display every 100 ms
        private void dateTimeTimer_Tick(object sender, EventArgs e)
        {
            refreshTime();
        }

        private void languageToggleTimer_Tick(object sender, EventArgs e)
        {
            if (GlobalSettings.CurrentLanguage == ScreenLanguage.French)
                setNewLanguage(ScreenLanguage.English);
            else
                setNewLanguage(ScreenLanguage.French);
            
        }

        private void setNewLanguage(ScreenLanguage lang)
        {
            GlobalSettings.CurrentLanguage = lang;
            refreshTime();
            if (lang == ScreenLanguage.French)
            {
                timeColumnLabel.Text = StringConstants.TimeFr;
            }
            else
            {
                timeColumnLabel.Text = StringConstants.TimeEn;
            }
        }
    }
}
