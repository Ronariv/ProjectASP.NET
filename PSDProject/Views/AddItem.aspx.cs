using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
namespace PSDProject.Views
{
    public partial class AddItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Role"] == null)
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
                categorySelect.DataSource = ItemController.GetAllItemType();
                categorySelect.DataBind();
                categorySelect.DataTextField = "ItemTypeName";
                categorySelect.DataValueField = "Id";
                categorySelect.DataBind();
            }
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            string title = TitleTxt.Text;
            int typeid = int.Parse(categorySelect.SelectedValue);
            int price = int.Parse(PriceTxt.Text);
            string description = DescriptionTxt.Text;

            int userid = (int)Session["ID"];
            string error = ItemController.InsertItem(title, ImageFile, description, typeid, price, userid);

            if(error == null)
            {
                Response.Redirect("~/Views/Home.aspx");
            } else
            {
                ErrorTxt.Text = error;
            }

        }

        protected void CancelBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Home.aspx");
        }
    }
}