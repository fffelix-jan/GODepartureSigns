
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timeColumnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.dateLabel.Location = new System.Drawing.Point(480, 0);
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
            this.clockLabel.Location = new System.Drawing.Point(1727, 0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(197, 86);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.timeColumnLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1920, 856);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // timeColumnLabel
            // 
            this.timeColumnLabel.AutoSize = true;
            this.timeColumnLabel.Location = new System.Drawing.Point(4, 1);
            this.timeColumnLabel.Name = "timeColumnLabel";
            this.timeColumnLabel.Size = new System.Drawing.Size(180, 84);
            this.timeColumnLabel.TabIndex = 0;
            this.timeColumnLabel.Text = "Time";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1924, 1058);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.trainsSubtitleLabel);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Name = "MainForm";
            this.Text = "GO Transit Union Departure List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label timeColumnLabel;
    }
}

