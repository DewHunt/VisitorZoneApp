using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorZoneApp.DAL.DAO;
using VisitorZoneApp.DAL.Gateway;

namespace VisitorZoneApp.BLL
{
    class JointVisitorZoneManager
    {
        JointVisitorZoneGateway jointVisitorZoneGateway = new JointVisitorZoneGateway();

        public List<Visitor> GetVisitorInfoByZoneId(int jointZoneId)
        {
            return jointVisitorZoneGateway.GetVisitorInfoByZoneId(jointZoneId);
        }

        public List<JointVisitorZone> GetTotalVisitorInZone(string id)
        {
            return jointVisitorZoneGateway.GetTotalVisitorInZone(id);
        }
    }
}
