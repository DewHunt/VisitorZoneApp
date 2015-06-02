using System;
using System.Windows.Forms;

namespace VisitorZoneApp.UI
{
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
            ShowMessage();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            VisitorEntryUi visitorEntry = new VisitorEntryUi();
            visitorEntry.Show();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
           ZoneEntryUi aZoneEntryUi = new ZoneEntryUi();
           aZoneEntryUi.Show();
        }

        private void zoneToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ZoneSpecificVisitorReport zoneSpecificVisitorReport= new ZoneSpecificVisitorReport();
            zoneSpecificVisitorReport.Show();
        }

        private void zoneSpecificVisitorNumberToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ZoneWiseVisitorNumber zoneWiseVisitorNumber = new ZoneWiseVisitorNumber();
            zoneWiseVisitorNumber.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You realy Exit Now?", @"Warnning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mainFormTimer_Tick(object sender, System.EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

        public void ShowMessage()
        {
            message1Label.Text = @"ফেয়ার ম্যানেজমেন্ট সিস্টেম";
            message2Label.Text = @"Fair Management System";
        }
    }
}
