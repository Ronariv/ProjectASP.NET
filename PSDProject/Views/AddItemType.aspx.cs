using PSDProject.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject.Views
{
    public partial class AddItemType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Role"] == null)
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            string typename = TypeNameTxt.Text;

            string insertType = ItemController.InsertItemType(typename);

            if (insertType != null)
            {
                TypeNameLbl.Text = insertType;
                TypeNameTxt.Text = "";
            } else
            {
                TypeNameLbl.Text = "";
                Response.Redirect("~/Views/Home.aspx");
            }
        }
    }
}