using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorZoneApp.DAL.DAO;
using VisitorZoneApp.DAL.Gateway;

namespace VisitorZoneApp.BLL
{
    class VisitorManager
    {
        VisitorGateway visitorGateway = new VisitorGateway();
        public string SaveVisitor(Visitor aVisitor, List<Zone> zoneListForJonitTable)
        {
            if (aVisitor.VisitorName == "")
            {
                return "Please Fill Up Your Name";
            }
            else
            {
                if (aVisitor.VisitorEmail == "")
                {
                    return "Please Fill Up Your Email";
                }
                else
                {
                    if (aVisitor.VisitorPhone == "")
                    {
                        return "Please Fill Up Your Contact Number";
                    }
                    else
                    {
                        if (visitorGateway.HasThisEmailExists(aVisitor.VisitorEmail))
                        {
                            return "This Email is Alredy Used.";
                        }
                        else
                        {
                            if (visitorGateway.SaveVisitor(aVisitor, zoneListForJonitTable))
                            {
                                return "Saved SuccessFully";
                            }
                            else
                            {
                                return "Saved Failed";
                            }
                        }
                    }
                }
            }
        }
    }
}
