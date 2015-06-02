using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorZoneApp.BLL;
using VisitorZoneApp.DAL.DAO;

namespace VisitorZoneApp.UI
{
    public partial class VisitorEntryUi : Form
    {
        ZoneManager zoneManager = new ZoneManager();
        VisitorManager visitorManager = new VisitorManager();
        private List<Zone> getZoneList; 
        public VisitorEntryUi()
        {
            InitializeComponent();
            LoadZoneCheckedListBox();
        }

        private void LoadZoneCheckedListBox()
        {
            getZoneList = zoneManager.GetAllZone();
            zoneTypeCheckedListBox.Items.Clear();
            foreach (var zone in getZoneList)
            {
                var item = zoneTypeCheckedListBox.Items;
                item.Add(zone.Name, true);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Visitor aVisitor = new Visitor();
            aVisitor.VisitorName = nameTextBox.Text;
            aVisitor.VisitorEmail = emailTextBox.Text;
            aVisitor.VisitorPhone = contactNumberTextBox.Text;

            if (nameTextBox.Text == "" && emailTextBox.Text == "" && contactNumberTextBox.Text == "")
            {
                MessageBox.Show("Please Fill Up All Information", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Zone> zoneListForJonitTable = new List<Zone>();

                foreach (var zone in getZoneList)
                {
                    foreach (string checkedItem in zoneTypeCheckedListBox.CheckedItems)
                    {
                        string name = checkedItem;
                        if (name == zone.Name)
                        {
                            zoneListForJonitTable.Add(zone);
                        }
                    }
                }

                MessageBox.Show(visitorManager.SaveVisitor(aVisitor, zoneListForJonitTable), @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
