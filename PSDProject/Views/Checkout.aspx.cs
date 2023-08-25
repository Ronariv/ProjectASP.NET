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
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string itemid = Request.QueryString["Id"];
                Item item = ItemController.GetOneItem(itemid);
                if (item == null)
                {
                    Response.Redirect("~/Views/Home.aspx");
                }
                else
                {
                    NameLbl.Text = item.ItemName;
                    Image.ImageUrl = item.ItemPicture;
                    DescriptionLbl.Text = item.ItemDescription;
                    PriceLbl.Text = "$ "+ item.ItemPrice;
                }
            }
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            int itemid = int.Parse(Request.QueryString["Id"]);
            int userid = (int)Session["ID"];
            int quantity = int.Parse(QuantityTxt.Text);

            CartController.AddCart(userid, itemid, quantity);
            Response.Redirect("~/Views/Cart.aspx");
        }
    }
}