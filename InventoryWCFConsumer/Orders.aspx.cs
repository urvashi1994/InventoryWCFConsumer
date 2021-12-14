using InventoryWCFConsumer.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryWCFConsumer
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersBO NewOrders = new OrdersBO()
                {
                    OrderNo = Convert.ToInt32(txtord_no.Text),
                    PurchAmt = float.Parse(txtpurch_amt.Text),
                    OrderDate = Convert.ToDateTime(txtord_date.Text),
                    CustomerId = Convert.ToInt32(txtcust_id.Text),
                    SalesmanId = Convert.ToInt32(txtsalesman_id.Text)
                };

                ServiceReference1.OrdersClient client = new ServiceReference1.OrdersClient("BasicHttpBinding_IOrders");
                int result = client.InsertNewOrder(NewOrders);

                if (result > 0)
                {
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Text = "Record has been successfully inserted!!!";
                    ClearFields();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ClearFields()
        {
            txtord_no.Text = "";
            txtpurch_amt.Text = "";
            txtord_date.Text = "";
            txtcust_id.Text = "";
            txtsalesman_id.Text = "";
            txtord_no.Focus();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersBO NewOrders = new OrdersBO()
                {
                    OrderNo = Convert.ToInt32(txtord_no.Text),
                    PurchAmt = float.Parse(txtpurch_amt.Text),
                    OrderDate = Convert.ToDateTime(txtord_date.Text),
                    CustomerId = Convert.ToInt32(txtcust_id.Text),
                    SalesmanId = Convert.ToInt32(txtsalesman_id.Text)
                };

                ServiceReference1.OrdersClient client = new ServiceReference1.OrdersClient();
                int result = client.UpdateOrdersInfo(NewOrders);

                if (result > 0)
                {
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Text = "Record has been successfully Updated!!!";
                    ClearFields();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersBO NewOrders = new OrdersBO()
                {
                    OrderNo = Convert.ToInt32(txtord_no.Text),
                };

                ServiceReference1.OrdersClient client = new ServiceReference1.OrdersClient();
                int result = client.DeleteOrdersInfo(NewOrders);

                if (result > 0)
                {
                    lblResult.ForeColor = System.Drawing.Color.Green;
                    lblResult.Text = "Record has been successfully Deleted!!!";
                    ClearFields();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}