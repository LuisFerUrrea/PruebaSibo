using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sibo.Examen.DAL;
using Sibo.Examen.DAL.Model;

namespace Sibo.Examen.BLL
{
    public class AdviserBLL
    {
        public Adviser Authenticate(string User, string Password)
        {
            AdviserDAL oAdviser = new AdviserDAL();
            return oAdviser.GetAdviser(User, Password);
        }
    }
}
