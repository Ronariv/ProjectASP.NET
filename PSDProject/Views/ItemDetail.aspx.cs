using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Model;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class ItemDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["Id"];
                Item item = ItemController.GetOneItem(id);
                int userid = -1;
                if (Session["Role"] != null)
                {
                    userid = (int)Session["ID"];
                }
                if (item == null)
                {
                    Response.Redirect("~/Views/Home.aspx");
                }
                else
                {
                    ClothLbl.Text = item.ItemName;
                    PriceLbl.Text = "$ " + item.ItemPrice;
                    DescLbl.Text = item.ItemDescription;
                    CategoryLbl.Text = item.ItemType.ItemTypeName;
                    Image.ImageUrl = item.ItemPicture;
                    if (item.UserID == userid)
                    {
                        BtnPanel.Visible = true;
                    }
                    else
                    {
                        BtnPanel.Visible = false;
                    }
                }
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            Response.Redirect("~/Views/UpdateItem.aspx?id=" + id);
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            string error = ItemController.DeleteItem(id);

            if(error == null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }
        }

        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            Response.Redirect("~/Views/Checkout.aspx?id=" + id);
        }
    }
}