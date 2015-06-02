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
using Microsoft.Office.Interop.Excel;

namespace VisitorZoneApp.UI
{
    public partial class ZoneSpecificVisitorReport : Form
    {
        ZoneManager zoneManager = new ZoneManager();
        Visitor aVisitor = new Visitor();
        JointVisitorZoneManager jointVisitorZoneManager = new JointVisitorZoneManager();

        public ZoneSpecificVisitorReport()
        {
            InitializeComponent();
            LoadAllZoneComboBox();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            visitorZoneSpecificListView.Items.Clear();
            JointVisitorZone jointVisitorZone = new JointVisitorZone();
            jointVisitorZone.JointZoneId = int.Parse(zoneComboBox.SelectedValue.ToString());

            int totalVisitor = 0;

            List<Visitor> visitorInfoList = jointVisitorZoneManager.GetVisitorInfoByZoneId(jointVisitorZone.JointZoneId);

            foreach (var show in visitorInfoList)
            {
                ListViewItem item = new ListViewItem(show.VisitorName);
                item.SubItems.Add(show.VisitorEmail);
                item.SubItems.Add(show.VisitorPhone);

                visitorZoneSpecificListView.Items.Add(item);

                totalVisitor++;
            }

            totalVisitroTextBox.Text = totalVisitor.ToString();
        }

        public void LoadAllZoneComboBox()
        {
            zoneComboBox.DataSource = zoneManager.GetAllZone();
            zoneComboBox.ValueMember = "Id";
            zoneComboBox.DisplayMember = "Name";
        }

        private void exportToExcelButton_Click(object sender, EventArgs e)
        {
            if (visitorZoneSpecificListView.Items.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application excleApp = new Microsoft.Office.Interop.Excel.Application();

                excleApp.Visible = true;

                Microsoft.Office.Interop.Excel.Workbook workbook = excleApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excleApp.ActiveSheet;

                excleApp.Columns.ColumnWidth = 22;

                worksheet.Cells[1, 2] = "Zone Name =";
                worksheet.Cells[1, 3] = zoneComboBox.Text;

                worksheet.Cells[3, 1] = "Visitor Name";
                worksheet.Cells[3, 1] = "Visitor Name";
                worksheet.Cells[3, 2] = "Email";
                worksheet.Cells[3, 3] = "Contact Number";

                int row = 4;

                int coloum = 1;

                foreach (ListViewItem comp in visitorZoneSpecificListView.Items)
                {

                    worksheet.Cells[row, coloum] = comp.Text.ToString();


                    foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                    {

                        worksheet.Cells[row, coloum] = drv.Text.ToString();

                        coloum++;

                    }

                    coloum = 1;

                    row++;

                }
                worksheet.Cells[row + 1, 2] = "Total VisitorNumbers =";
                worksheet.Cells[row + 1, 3] = totalVisitroTextBox.Text;
            }
            else
            {
                MessageBox.Show("There is no Data", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
