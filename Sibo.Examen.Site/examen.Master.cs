using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sibo.Examen.DAL.Model;

namespace Sibo.Examen.Site
{
    public partial class examen : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
                Response.Redirect("default.aspx");
            else
            {
                Adviser eClient =(Adviser)Session["User"];
                lblUserName.Text = eClient.Name + " " + eClient.LastName;
            }
        }

        protected void lnkSalir_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("default.aspx");
        }
    }
}