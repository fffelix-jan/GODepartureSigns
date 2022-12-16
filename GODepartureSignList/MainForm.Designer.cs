
namespace GODepartureSigns
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.clockLabel = new System.Windows.Forms.Label();
            this.trainsSubtitleLabel = new System.Windows.Forms.Label();
            this.dateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.languageToggleTimer = new System.Windows.Forms.Timer(this.components);
            this.scheduleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.row1LineLabel = new System.Windows.Forms.Label();
            this.platformColumnLabel = new System.Windows.Forms.Label();
            this.destinationsColumnLabel = new System.Windows.Forms.Label();
            this.lineColumnLabel = new System.Windows.Forms.Label();
            this.timeColumnLabel = new System.Windows.Forms.Label();
            this.row1TimeLabel = new System.Windows.Forms.Label();
            this.row2TimeLabel = new System.Windows.Forms.Label();
            this.row3TimeLabel = new System.Windows.Forms.Label();
            this.row4TimeLabel = new System.Windows.Forms.Label();
            this.row5TimeLabel = new System.Windows.Forms.Label();
            this.row6TimeLabel = new System.Windows.Forms.Label();
            this.row7TimeLabel = new System.Windows.Forms.Label();
            this.row8TimeLabel = new System.Windows.Forms.Label();
            this.row9TimeLabel = new System.Windows.Forms.Label();
            this.statusColumnLabel = new System.Windows.Forms.Label();
            this.row2LineLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.scheduleTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GODepartureSignList.Properties.Resources.GOLogo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(18, 20, 18, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(478, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(800, 86);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Friday, December 25, 1969";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clockLabel
            // 
            this.clockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.Location = new System.Drawing.Point(1718, 0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(202, 86);
            this.clockLabel.TabIndex = 2;
            this.clockLabel.Text = "04:20";
            // 
            // trainsSubtitleLabel
            // 
            this.trainsSubtitleLabel.AutoSize = true;
            this.trainsSubtitleLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainsSubtitleLabel.Location = new System.Drawing.Point(181, 17);
            this.trainsSubtitleLabel.Name = "trainsSubtitleLabel";
            this.trainsSubtitleLabel.Size = new System.Drawing.Size(146, 65);
            this.trainsSubtitleLabel.TabIndex = 3;
            this.trainsSubtitleLabel.Text = "Trains";
            // 
            // dateTimeTimer
            // 
            this.dateTimeTimer.Enabled = true;
            this.dateTimeTimer.Tick += new System.EventHandler(this.dateTimeTimer_Tick);
            // 
            // languageToggleTimer
            // 
            this.languageToggleTimer.Enabled = true;
            this.languageToggleTimer.Interval = 5000;
            this.languageToggleTimer.Tick += new System.EventHandler(this.languageToggleTimer_Tick);
            // 
            // scheduleTableLayoutPanel
            // 
            this.scheduleTableLayoutPanel.ColumnCount = 5;
            this.scheduleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.scheduleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.scheduleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.scheduleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.scheduleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.scheduleTableLayoutPanel.Controls.Add(this.row1LineLabel, 1, 1);
            this.scheduleTableLayoutPanel.Controls.Add(this.platformColumnLabel, 3, 0);
            this.scheduleTableLayoutPanel.Controls.Add(this.destinationsColumnLabel, 2, 0);
            this.scheduleTableLayoutPanel.Controls.Add(this.lineColumnLabel, 1, 0);
            this.scheduleTableLayoutPanel.Controls.Add(this.timeColumnLabel, 0, 0);
            this.scheduleTableLayoutPanel.Controls.Add(this.row1TimeLabel, 0, 1);
            this.scheduleTableLayoutPanel.Controls.Add(this.row2TimeLabel, 0, 2);
            this.scheduleTableLayoutPanel.Controls.Add(this.row3TimeLabel, 0, 3);
            this.scheduleTableLayoutPanel.Controls.Add(this.row4TimeLabel, 0, 4);
            this.scheduleTableLayoutPanel.Controls.Add(this.row5TimeLabel, 0, 5);
            this.scheduleTableLayoutPanel.Controls.Add(this.row6TimeLabel, 0, 6);
            this.scheduleTableLayoutPanel.Controls.Add(this.row7TimeLabel, 0, 7);
            this.scheduleTableLayoutPanel.Controls.Add(this.row8TimeLabel, 0, 8);
            this.scheduleTableLayoutPanel.Controls.Add(this.row9TimeLabel, 0, 9);
            this.scheduleTableLayoutPanel.Controls.Add(this.statusColumnLabel, 4, 0);
            this.scheduleTableLayoutPanel.Controls.Add(this.row2LineLabel, 1, 2);
            this.scheduleTableLayoutPanel.Location = new System.Drawing.Point(0, 99);
            this.scheduleTableLayoutPanel.Name = "scheduleTableLayoutPanel";
            this.scheduleTableLayoutPanel.RowCount = 10;
            this.scheduleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scheduleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scheduleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scheduleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scheduleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scheduleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scheduleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scheduleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scheduleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scheduleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.scheduleTableLayoutPanel.Size = new System.Drawing.Size(1920, 856);
            this.scheduleTableLayoutPanel.TabIndex = 4;
            this.scheduleTableLayoutPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.scheduleTableLayoutPanel_CellPaint);
            // 
            // row1LineLabel
            // 
            this.row1LineLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row1LineLabel.AutoSize = true;
            this.row1LineLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(46)))), ((int)(((byte)(36)))));
            this.row1LineLabel.Location = new System.Drawing.Point(225, 95);
            this.row1LineLabel.Name = "row1LineLabel";
            this.row1LineLabel.Size = new System.Drawing.Size(349, 65);
            this.row1LineLabel.TabIndex = 14;
            this.row1LineLabel.Text = "Lakeshore East";
            // 
            // platformColumnLabel
            // 
            this.platformColumnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.platformColumnLabel.AutoSize = true;
            this.platformColumnLabel.BackColor = System.Drawing.Color.White;
            this.platformColumnLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformColumnLabel.ForeColor = System.Drawing.Color.Black;
            this.platformColumnLabel.Location = new System.Drawing.Point(1282, 10);
            this.platformColumnLabel.Name = "platformColumnLabel";
            this.platformColumnLabel.Size = new System.Drawing.Size(226, 65);
            this.platformColumnLabel.TabIndex = 12;
            this.platformColumnLabel.Text = "Platform";
            // 
            // destinationsColumnLabel
            // 
            this.destinationsColumnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.destinationsColumnLabel.AutoSize = true;
            this.destinationsColumnLabel.BackColor = System.Drawing.Color.White;
            this.destinationsColumnLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationsColumnLabel.ForeColor = System.Drawing.Color.Black;
            this.destinationsColumnLabel.Location = new System.Drawing.Point(780, 10);
            this.destinationsColumnLabel.Name = "destinationsColumnLabel";
            this.destinationsColumnLabel.Size = new System.Drawing.Size(310, 65);
            this.destinationsColumnLabel.TabIndex = 11;
            this.destinationsColumnLabel.Text = "Destinations";
            // 
            // lineColumnLabel
            // 
            this.lineColumnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineColumnLabel.AutoSize = true;
            this.lineColumnLabel.BackColor = System.Drawing.Color.White;
            this.lineColumnLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineColumnLabel.ForeColor = System.Drawing.Color.Black;
            this.lineColumnLabel.Location = new System.Drawing.Point(339, 10);
            this.lineColumnLabel.Name = "lineColumnLabel";
            this.lineColumnLabel.Size = new System.Drawing.Size(122, 65);
            this.lineColumnLabel.TabIndex = 10;
            this.lineColumnLabel.Text = "Line";
            // 
            // timeColumnLabel
            // 
            this.timeColumnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeColumnLabel.AutoSize = true;
            this.timeColumnLabel.BackColor = System.Drawing.Color.White;
            this.timeColumnLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeColumnLabel.ForeColor = System.Drawing.Color.Black;
            this.timeColumnLabel.Location = new System.Drawing.Point(30, 10);
            this.timeColumnLabel.Name = "timeColumnLabel";
            this.timeColumnLabel.Size = new System.Drawing.Size(140, 65);
            this.timeColumnLabel.TabIndex = 0;
            this.timeColumnLabel.Text = "Time";
            // 
            // row1TimeLabel
            // 
            this.row1TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row1TimeLabel.AutoSize = true;
            this.row1TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.row1TimeLabel.Location = new System.Drawing.Point(30, 95);
            this.row1TimeLabel.Name = "row1TimeLabel";
            this.row1TimeLabel.Size = new System.Drawing.Size(140, 65);
            this.row1TimeLabel.TabIndex = 1;
            this.row1TimeLabel.Text = "00:01";
            // 
            // row2TimeLabel
            // 
            this.row2TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row2TimeLabel.AutoSize = true;
            this.row2TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.row2TimeLabel.Location = new System.Drawing.Point(26, 180);
            this.row2TimeLabel.Name = "row2TimeLabel";
            this.row2TimeLabel.Size = new System.Drawing.Size(148, 65);
            this.row2TimeLabel.TabIndex = 2;
            this.row2TimeLabel.Text = "00:02";
            // 
            // row3TimeLabel
            // 
            this.row3TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row3TimeLabel.AutoSize = true;
            this.row3TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.row3TimeLabel.Location = new System.Drawing.Point(26, 265);
            this.row3TimeLabel.Name = "row3TimeLabel";
            this.row3TimeLabel.Size = new System.Drawing.Size(148, 65);
            this.row3TimeLabel.TabIndex = 3;
            this.row3TimeLabel.Text = "00:03";
            // 
            // row4TimeLabel
            // 
            this.row4TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row4TimeLabel.AutoSize = true;
            this.row4TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.row4TimeLabel.Location = new System.Drawing.Point(25, 350);
            this.row4TimeLabel.Name = "row4TimeLabel";
            this.row4TimeLabel.Size = new System.Drawing.Size(149, 65);
            this.row4TimeLabel.TabIndex = 4;
            this.row4TimeLabel.Text = "00:04";
            // 
            // row5TimeLabel
            // 
            this.row5TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row5TimeLabel.AutoSize = true;
            this.row5TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.row5TimeLabel.Location = new System.Drawing.Point(26, 435);
            this.row5TimeLabel.Name = "row5TimeLabel";
            this.row5TimeLabel.Size = new System.Drawing.Size(148, 65);
            this.row5TimeLabel.TabIndex = 5;
            this.row5TimeLabel.Text = "00:05";
            // 
            // row6TimeLabel
            // 
            this.row6TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row6TimeLabel.AutoSize = true;
            this.row6TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.row6TimeLabel.Location = new System.Drawing.Point(26, 520);
            this.row6TimeLabel.Name = "row6TimeLabel";
            this.row6TimeLabel.Size = new System.Drawing.Size(148, 65);
            this.row6TimeLabel.TabIndex = 6;
            this.row6TimeLabel.Text = "00:06";
            // 
            // row7TimeLabel
            // 
            this.row7TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row7TimeLabel.AutoSize = true;
            this.row7TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.row7TimeLabel.Location = new System.Drawing.Point(26, 605);
            this.row7TimeLabel.Name = "row7TimeLabel";
            this.row7TimeLabel.Size = new System.Drawing.Size(147, 65);
            this.row7TimeLabel.TabIndex = 7;
            this.row7TimeLabel.Text = "00:07";
            // 
            // row8TimeLabel
            // 
            this.row8TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row8TimeLabel.AutoSize = true;
            this.row8TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.row8TimeLabel.Location = new System.Drawing.Point(26, 690);
            this.row8TimeLabel.Name = "row8TimeLabel";
            this.row8TimeLabel.Size = new System.Drawing.Size(148, 65);
            this.row8TimeLabel.TabIndex = 8;
            this.row8TimeLabel.Text = "00:08";
            // 
            // row9TimeLabel
            // 
            this.row9TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row9TimeLabel.AutoSize = true;
            this.row9TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.row9TimeLabel.Location = new System.Drawing.Point(26, 778);
            this.row9TimeLabel.Name = "row9TimeLabel";
            this.row9TimeLabel.Size = new System.Drawing.Size(148, 65);
            this.row9TimeLabel.TabIndex = 9;
            this.row9TimeLabel.Text = "00:09";
            // 
            // statusColumnLabel
            // 
            this.statusColumnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusColumnLabel.AutoSize = true;
            this.statusColumnLabel.BackColor = System.Drawing.Color.White;
            this.statusColumnLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusColumnLabel.ForeColor = System.Drawing.Color.Black;
            this.statusColumnLabel.Location = new System.Drawing.Point(1636, 10);
            this.statusColumnLabel.Name = "statusColumnLabel";
            this.statusColumnLabel.Size = new System.Drawing.Size(168, 65);
            this.statusColumnLabel.TabIndex = 13;
            this.statusColumnLabel.Text = "Status";
            // 
            // row2LineLabel
            // 
            this.row2LineLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.row2LineLabel.AutoSize = true;
            this.row2LineLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(46)))), ((int)(((byte)(36)))));
            this.row2LineLabel.Location = new System.Drawing.Point(215, 180);
            this.row2LineLabel.Name = "row2LineLabel";
            this.row2LineLabel.Size = new System.Drawing.Size(370, 65);
            this.row2LineLabel.TabIndex = 15;
            this.row2LineLabel.Text = "Lakeshore West";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.scheduleTableLayoutPanel);
            this.Controls.Add(this.trainsSubtitleLabel);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Name = "MainForm";
            this.Text = "GO Transit Union Departure List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.scheduleTableLayoutPanel.ResumeLayout(false);
            this.scheduleTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Label trainsSubtitleLabel;
        private System.Windows.Forms.Timer dateTimeTimer;
        private System.Windows.Forms.Timer languageToggleTimer;
        private System.Windows.Forms.TableLayoutPanel scheduleTableLayoutPanel;
        private System.Windows.Forms.Label timeColumnLabel;
        private System.Windows.Forms.Label row1TimeLabel;
        private System.Windows.Forms.Label row2TimeLabel;
        private System.Windows.Forms.Label row3TimeLabel;
        private System.Windows.Forms.Label row4TimeLabel;
        private System.Windows.Forms.Label row5TimeLabel;
        private System.Windows.Forms.Label row6TimeLabel;
        private System.Windows.Forms.Label row7TimeLabel;
        private System.Windows.Forms.Label row8TimeLabel;
        private System.Windows.Forms.Label row9TimeLabel;
        private System.Windows.Forms.Label lineColumnLabel;
        private System.Windows.Forms.Label platformColumnLabel;
        private System.Windows.Forms.Label destinationsColumnLabel;
        private System.Windows.Forms.Label statusColumnLabel;
        private System.Windows.Forms.Label row1LineLabel;
        private System.Windows.Forms.Label row2LineLabel;
    }
}

