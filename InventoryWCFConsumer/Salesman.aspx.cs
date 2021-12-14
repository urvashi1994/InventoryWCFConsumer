using InventoryWCFConsumer.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryWCFConsumer
{
    public partial class Salesman : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SalesmanBO newSalesman = new SalesmanBO()
                {
                    SalesmanId = Convert.ToInt32(txtsalesman_id.Text),
                    Name = txtsalesman_name.Text,
                    City = txtcity.Text,
                    Commission = float.Parse(txtcommission.Text)
                };

                ServiceReference1.SalesmanClient client = new ServiceReference1.SalesmanClient("BasicHttpBinding_ISalesman");
                int result = client.InsertNewSalesman(newSalesman);

                if (result > 0)
                {
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Text = "Record has been successfully inserted!!!";
                    clearfields();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
         }
        private void clearfields()
        {
            txtsalesman_id.Text = "";
            txtsalesman_name.Text = "";
            txtcity.Text = "";
            txtcommission.Text = "";
            txtsalesman_id.Focus();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SalesmanBO newSalesman = new SalesmanBO()
                {
                    SalesmanId = Convert.ToInt32(txtsalesman_id.Text),
                    Name = txtsalesman_name.Text,
                    City = txtcity.Text,
                    Commission = float.Parse(txtcommission.Text)
                };
                ServiceReference1.SalesmanClient client = new ServiceReference1.SalesmanClient();
                int result = client.UpdateSalesmanInfo(newSalesman);

                if(result > 0)
                {
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Text = "Record has been successfully Updated!!!";
                    clearfields();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SalesmanBO newSalesman = new SalesmanBO()
                {
                    SalesmanId = Convert.ToInt32(txtsalesman_id.Text)

                };
                ServiceReference1.SalesmanClient client = new ServiceReference1.SalesmanClient();
                int result = client.DeleteSalesmanInfo(newSalesman);

                if(result > 0)
                {
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Text = "Record has been successfully Deleted!!!";
                    clearfields();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }

}