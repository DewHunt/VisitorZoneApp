using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorZoneApp.BLL;
using VisitorZoneApp.DAL.DAO;
using Zone = VisitorZoneApp.DAL.DAO.Zone;

namespace VisitorZoneApp.UI
{
    public partial class ZoneWiseVisitorNumber : Form
    {
        ZoneManager zoneManager = new ZoneManager();
        JointVisitorZoneManager jointVisitorZoneManager = new JointVisitorZoneManager();
        public ZoneWiseVisitorNumber()
        {
            InitializeComponent();
            ZoneWiseTotalVisitor();
        }

        public void ZoneWiseTotalVisitor()
        {
            List<Zone> zoneInfoList = zoneManager.GetAllZone();

            int serial = 1;
            int totalVisitor = 0;

            foreach (var show in zoneInfoList)
            {
                int totalVisitorInZone = 0;
                List<JointVisitorZone> totalVisitorInZoneList = jointVisitorZoneManager.GetTotalVisitorInZone(show.Id);

                foreach (var totalvisitor in totalVisitorInZoneList)
                {
                    totalVisitorInZone++;
                }

                ListViewItem item = new ListViewItem(serial.ToString());
                item.SubItems.Add(show.Name);
                item.SubItems.Add(totalVisitorInZone.ToString());
                zoneWiseVisitorListView.Items.Add(item);
                totalVisitor = totalVisitor + totalVisitorInZone;
                serial++;
            }

            overAllVisitorTextBox.Text = totalVisitor.ToString();
        }
    }
}
