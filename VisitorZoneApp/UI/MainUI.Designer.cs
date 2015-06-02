namespace VisitorZoneApp.UI
{
    partial class MainUi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneSpecificVisitorNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.mainFormMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.message1Label = new System.Windows.Forms.Label();
            this.message2Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorEntryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.visitorToolStripMenuItem.Text = "Visitor";
            // 
            // visitorEntryToolStripMenuItem
            // 
            this.visitorEntryToolStripMenuItem.Name = "visitorEntryToolStripMenuItem";
            this.visitorEntryToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.visitorEntryToolStripMenuItem.Text = "Visitor Entry";
            this.visitorEntryToolStripMenuItem.Click += new System.EventHandler(this.visitorEntryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneTypeToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // zoneTypeToolStripMenuItem
            // 
            this.zoneTypeToolStripMenuItem.Name = "zoneTypeToolStripMenuItem";
            this.zoneTypeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.zoneTypeToolStripMenuItem.Text = "Zone Type";
            this.zoneTypeToolStripMenuItem.Click += new System.EventHandler(this.zoneTypeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneToolStripMenuItem,
            this.zoneSpecificVisitorNumberToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // zoneToolStripMenuItem
            // 
            this.zoneToolStripMenuItem.Name = "zoneToolStripMenuItem";
            this.zoneToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.zoneToolStripMenuItem.Text = "Zone Specific Visitor Details";
            this.zoneToolStripMenuItem.Click += new System.EventHandler(this.zoneToolStripMenuItem_Click);
            // 
            // zoneSpecificVisitorNumberToolStripMenuItem
            // 
            this.zoneSpecificVisitorNumberToolStripMenuItem.Name = "zoneSpecificVisitorNumberToolStripMenuItem";
            this.zoneSpecificVisitorNumberToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.zoneSpecificVisitorNumberToolStripMenuItem.Text = "Zone Wise Visitor Number";
            this.zoneSpecificVisitorNumberToolStripMenuItem.Click += new System.EventHandler(this.zoneSpecificVisitorNumberToolStripMenuItem_Click);
            // 
            // mainFormTimer
            // 
            this.mainFormTimer.Enabled = true;
            this.mainFormTimer.Tick += new System.EventHandler(this.mainFormTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Location = new System.Drawing.Point(733, 273);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(37, 15);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "label1";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateLabel.Location = new System.Drawing.Point(530, 275);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(37, 15);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "label2";
            // 
            // mainFormMonthCalendar
            // 
            this.mainFormMonthCalendar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.mainFormMonthCalendar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.mainFormMonthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Friday;
            this.mainFormMonthCalendar.Location = new System.Drawing.Point(532, 295);
            this.mainFormMonthCalendar.Name = "mainFormMonthCalendar";
            this.mainFormMonthCalendar.ShowWeekNumbers = true;
            this.mainFormMonthCalendar.TabIndex = 3;
            this.mainFormMonthCalendar.UseWaitCursor = true;
            // 
            // message1Label
            // 
            this.message1Label.AutoSize = true;
            this.message1Label.Font = new System.Drawing.Font("BrahmaputraMJ", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message1Label.Location = new System.Drawing.Point(422, 202);
            this.message1Label.Name = "message1Label";
            this.message1Label.Size = new System.Drawing.Size(161, 54);
            this.message1Label.TabIndex = 4;
            this.message1Label.Text = "label1";
            // 
            // message2Label
            // 
            this.message2Label.AutoSize = true;
            this.message2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.message2Label.Font = new System.Drawing.Font("Segoe Print", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message2Label.Location = new System.Drawing.Point(12, 24);
            this.message2Label.Name = "message2Label";
            this.message2Label.Size = new System.Drawing.Size(358, 170);
            this.message2Label.TabIndex = 5;
            this.message2Label.Text = "label1";
            this.message2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.message2Label.UseMnemonic = false;
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 487);
            this.Controls.Add(this.message2Label);
            this.Controls.Add(this.message1Label);
            this.Controls.Add(this.mainFormMonthCalendar);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainUi";
            this.ShowIcon = false;
            this.Text = "Main AREA UI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneSpecificVisitorNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.Timer mainFormTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.MonthCalendar mainFormMonthCalendar;
        private System.Windows.Forms.Label message1Label;
        private System.Windows.Forms.Label message2Label;

    }
}

