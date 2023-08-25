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
    public partial class UpdateItem : System.Web.UI.Page
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
                string id = Request.QueryString["Id"];
                Item item = ItemController.GetOneItem(id);

                if (item == null)
                {
                    Response.Redirect("~/Views/Home.aspx");
                }
                else
                {
                    clothesnameTxt.Text = item.ItemName;
                    priceTxt.Text = item.ItemPrice.ToString();
                    descriptionTxt.Text = item.ItemDescription;
                    categorySelect.SelectedIndex = item.ItemTypeID;
                }
            }
            
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {

            int id = int.Parse(Request.QueryString["Id"]);
            string name = clothesnameTxt.Text;
            int price = int.Parse(priceTxt.Text);
            int type = categorySelect.SelectedIndex;
            string description = descriptionTxt.Text;

            string error = ItemController.UpdateItem(id, name, ImageFile, description, type, price);

            if(error == null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }
            else
            {
                ErrorLbl.Text = error;
                ErrorLbl.Visible = true;
            }
        }

        protected void CancelBtn_Click(object sender, EventArgs e)
        {

        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}