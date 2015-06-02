using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorZoneApp.DAL.DAO;

namespace VisitorZoneApp.DAL.Gateway
{
    class JointVisitorZoneGateway
    {
        VisitorGateway visitorGateway = new VisitorGateway();

        private SqlConnection SqlConnectionObj;
        private SqlCommand SqlCommandObj;
        public JointVisitorZoneGateway()
        {
            SqlConnectionObj = new SqlConnection(ConfigurationManager.ConnectionStrings["VisitorZoneDB"].ConnectionString);
            SqlCommandObj = new SqlCommand();
            SqlCommandObj.Connection = SqlConnectionObj;
        }

        public List<Visitor> GetVisitorInfoByZoneId(int jointZoneId)
        {
            string visitorIdQuery = "SELECT visitorid FROM tbl_joint_visitor_zone WHERE zoneid = '" + jointZoneId + "'";
            SqlConnectionObj.Open();
            SqlCommandObj.CommandText = visitorIdQuery;
            SqlDataReader visitorIdReader = SqlCommandObj.ExecuteReader();

            List<int> visitorIdList = new List<int>();

            while (visitorIdReader.Read())
            {
                int JointVisitorId = int.Parse(visitorIdReader["visitorid"].ToString());

                visitorIdList.Add(JointVisitorId);
            }
            visitorIdReader.Close();
            SqlConnectionObj.Close();

            List<Visitor> visitorsInfoList = visitorGateway.GetVisitorInfoByVisitorId(visitorIdList);

            return visitorsInfoList;
        }

        public List<JointVisitorZone> GetTotalVisitorInZone(string id)
        {
            string totalVisitorInZoneQuery = "SELECT visitorid FROM tbl_joint_visitor_zone WHERE zoneid='" + id + "'";

            SqlConnectionObj.Open();
            SqlCommandObj.CommandText = totalVisitorInZoneQuery;
            SqlDataReader totalVisitorInZoneReader = SqlCommandObj.ExecuteReader();

            List<JointVisitorZone> totalVisitorInZoneList = new List<JointVisitorZone>();

            while (totalVisitorInZoneReader.Read())
            {
                JointVisitorZone aJointVisitorZone =new JointVisitorZone();
                aJointVisitorZone.JointVisitorId = int.Parse(totalVisitorInZoneReader["visitorid"].ToString());

                totalVisitorInZoneList.Add(aJointVisitorZone);
            }
            totalVisitorInZoneReader.Close();
            SqlConnectionObj.Close();

            return totalVisitorInZoneList;
        }
    }
}
