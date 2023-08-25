using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
using PSDProject.Model;
namespace PSDProject.Views
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int userid = (int)Session["ID"];
                TableRepeater.DataSource = CartController.GetCart(userid);
                TableRepeater.DataBind();
            }
        }

        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            int userid = (int)Session["ID"];

            List<Model.Cart> transactions = CartController.Carts(userid);

            int headerID = TransactionController.InsertTransaction(userid);

            foreach (Model.Cart cart in transactions)
            {
                TransactionController.InsertTransactionDetail(headerID, cart.ItemID, cart.Quantity);
            }
            CartController.DeleteCart(userid);
            Response.Redirect("~/Views/Transaction.aspx");
        }
    }
}