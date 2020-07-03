using Sibo.Examen.BLL;
using Sibo.Examen.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sibo.Examen.Site
{
    public partial class CrearFactura : System.Web.UI.Page
    {
        ProductBLL oProductBLL = new ProductBLL();
        wsFacturacion.ServiceSoapClient ws = new wsFacturacion.ServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //dgProducto.DataSource = oProductBLL.Get();
                //dgProducto.DataBind();

            }
        }

        protected void btnCrearCliente_Click(object sender, EventArgs e)
        {
            try
            {                
              var xxxx =  ws.Post(txtCedula.Text, txtNombre.Text, txtApellido.Text);
            }
            catch (Exception)
            {
                throw;
            }
        
        }

        protected void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //wsFacturacion.ServiceSoapClient ws = new wsFacturacion.ServiceSoapClient();
                bool existeCliente = false;
                DataTable dtClientes = ws.Get();
                DataRow[] dr = dtClientes.Select(string.Concat("Identification=", txtCedula.Text));
                txtNombre.ReadOnly = false;
                txtApellido.ReadOnly = false;
                foreach (DataRow row in dr)
                {
                    txtNombre.Text = row.Field<string>("Name");
                    txtApellido.Text = row.Field<string>("LastName");
                    existeCliente = true;
                    //txtNombre.ReadOnly = true;
                    //txtApellido.ReadOnly = true;
                    //btnCrearCliente.Visible = false;
                }

                if(existeCliente)
                {
                    txtNombre.ReadOnly = true;
                    txtApellido.ReadOnly = true;
                    btnCrearCliente.Visible = false;
                }
                else
                {
                    txtNombre.ReadOnly = false;
                    txtApellido.ReadOnly = false;
                    btnCrearCliente.Visible = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
         
        }

        protected void dgProducto_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName.ToString()== "agregarCantidad")
            {
                GridViewRow row = (GridViewRow)(((Button)e.CommandSource).NamingContainer);              
                string id = dgProducto.Rows[row.RowIndex].Cells[0].Text;
                string name = dgProducto.Rows[row.RowIndex].Cells[1].Text;
                string price = dgProducto.Rows[row.RowIndex].Cells[2].Text;
                string quantity = dgProducto.Rows[row.RowIndex].Cells[3].Text;
                string percentDiscount = dgProducto.Rows[row.RowIndex].Cells[3].Text;

                mpePopUp.Show();


            }
        }

      
    }
}