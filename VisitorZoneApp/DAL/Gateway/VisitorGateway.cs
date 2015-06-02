using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorZoneApp.DAL.DAO;

namespace VisitorZoneApp.DAL.Gateway
{
    class VisitorGateway
    {

        private SqlConnection SqlConnectionObj;
        private SqlCommand SqlCommandObj;

        public VisitorGateway()
        {
            SqlConnectionObj = new SqlConnection(ConfigurationManager.ConnectionStrings["VisitorZoneDB"].ConnectionString);
            SqlCommandObj = new SqlCommand();
            SqlCommandObj.Connection = SqlConnectionObj;
        }
        public bool HasThisEmailExists(string visitorEmail)
        {
            SqlConnectionObj.Open();

            string emailExistsQuery = "SELECT email FROM tbl_visitor WHERE email = '" + visitorEmail + "'";

            SqlCommandObj.CommandText = emailExistsQuery;

            SqlDataReader emailExistsReader = SqlCommandObj.ExecuteReader();
            bool emailEsistsStatus = emailExistsReader.HasRows;

            emailExistsReader.Close();
            SqlConnectionObj.Close();

            return emailEsistsStatus;
        }

        public bool SaveVisitor(Visitor aVisitor, List<Zone> zoneListForJonitTable)
        {
            SqlConnectionObj.Open();
            string saveVisitorQuery = "INSERT INTO tbl_visitor VALUES ('" + aVisitor.VisitorName + "','" +
                                      aVisitor.VisitorEmail + "','" + aVisitor.VisitorPhone + "')";
            SqlCommandObj.CommandText = saveVisitorQuery;
            int saveVisitorRowAffected = SqlCommandObj.ExecuteNonQuery();

            SqlConnectionObj.Close();

            int visitorLastId = Convert.ToInt32(LastValue());

            if (SaveVisitorIdAndZoneIdInJointTable(visitorLastId, zoneListForJonitTable) && saveVisitorRowAffected > 0)
            {
                return true;
            }
            return false;
        }

        private bool SaveVisitorIdAndZoneIdInJointTable(int visitorLastId, List<Zone> zoneListForJonitTable)
        {
            int idRowAffected = 0;

            foreach (var zone in zoneListForJonitTable)
            {
                SqlConnectionObj.Open();
                string saveJointquery = "INSERT INTO tbl_joint_visitor_zone VALUES ('" + visitorLastId + "','" + zone.Id + "')";

                SqlCommandObj.CommandText = saveJointquery;
                idRowAffected = +SqlCommandObj.ExecuteNonQuery();
                SqlConnectionObj.Close();

            }

            if (idRowAffected > 0)
            {
                return true;
            }
            return false;
        }

        public string LastValue()
        {
            string value = "";
            string lastValueQuery = "SELECT LAST_VALUE (id) OVER (ORDER BY id ROWS BETWEEN  CURRENT ROW AND UNBOUNDED FOLLOWING) AS id FROM tbl_visitor";

            SqlConnectionObj.Open();
            SqlCommandObj.CommandText = lastValueQuery;
            SqlDataReader reader = SqlCommandObj.ExecuteReader();
            while (reader.Read())
            {
                value = reader["id"].ToString();
            }

            SqlConnectionObj.Close();

            return value;
        }

        public List<Visitor> GetVisitorInfoByVisitorId(List<int> visitorIdList)
        {
            List<Visitor> visitorInfoList = new List<Visitor>();

            SqlConnectionObj.Open();

            foreach (var visitorId in visitorIdList)
            {
                string visitorInfoQuery = "SELECT * FROM tbl_visitor WHERE id = '" + visitorId + "'";

                SqlCommandObj.CommandText = visitorInfoQuery;
                SqlDataReader visitorInfoReader = SqlCommandObj.ExecuteReader();

                while (visitorInfoReader.Read())
                {
                    Visitor aVisitor = new Visitor();
                    aVisitor.VisitorName = visitorInfoReader["name"].ToString();
                    aVisitor.VisitorEmail = visitorInfoReader["email"].ToString();
                    aVisitor.VisitorPhone = visitorInfoReader["phone"].ToString();

                    visitorInfoList.Add(aVisitor);
                }
                visitorInfoReader.Close();
            }

            SqlConnectionObj.Close();

            return visitorInfoList;
        }
    }
}
