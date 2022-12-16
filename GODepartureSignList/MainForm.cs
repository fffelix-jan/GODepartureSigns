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
            ControlDoubleBuffering.SetDoubleBuffered(scheduleTableLayoutPanel);
            // Set the language to English
            GlobalSettings.CurrentLanguage = ScreenLanguage.English;
            // Hide the cursor
            Cursor.Hide();

            // Cursed font (just for fun, please remove)
            // SetAllControlsFont(Controls);
        }

        // Cursed font (just for fun, please remove)
        // Sets the font of all controls to Comic Sans MS.
        public void SetAllControlsFont(Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.Controls != null)
                    SetAllControlsFont(ctrl.Controls);

                ctrl.Font = new Font("Comic Sans MS", ctrl.Font.Size);

            }
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
                lineColumnLabel.Text = StringConstants.LineFr;
                platformColumnLabel.Text = StringConstants.PlatformFr;
                statusColumnLabel.Text = StringConstants.StatusFr;
            }
            else
            {
                timeColumnLabel.Text = StringConstants.TimeEn;
                lineColumnLabel.Text = StringConstants.LineEn;
                platformColumnLabel.Text = StringConstants.PlatformEn;
                statusColumnLabel.Text = StringConstants.StatusEn;
            }
        }

        // Paints the background colors and separating lines of the table cells, as well as the colour of the "line" cells.
        private void scheduleTableLayoutPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Pen p = new Pen(Color.White, 2.0f);
            // test code
            if (e.Column == 1 && e.Row == 1)
            {
                    e.Graphics.FillRectangle(new SolidBrush(LineColor.LakeshoreEast), e.CellBounds);
            }
            if (e.Column == 1 && e.Row == 2)
            {
                row2LineLabel.BackColor = Color.Transparent;
                e.Graphics.FillRectangle(new SolidBrush(LineColor.LakeshoreWest), e.CellBounds);
            }
            if (e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            }
            e.Graphics.DrawLine(p, new Point(e.CellBounds.Left, e.CellBounds.Top), new Point(e.CellBounds.Right, e.CellBounds.Top));
            e.Graphics.DrawLine(p, new Point(e.CellBounds.Left, e.CellBounds.Bottom), new Point(e.CellBounds.Right, e.CellBounds.Bottom));
        }
    }
}
