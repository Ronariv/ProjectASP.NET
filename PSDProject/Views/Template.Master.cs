﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSDProject
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] != null)
            {
                RegisterBtn.Visible = false;
                LoginBtn.Visible = false;
                LogoutBtn.Visible = true;
                ManagePanel.Visible = true;
            }
            else
            {
                RegisterBtn.Visible = true;
                LoginBtn.Visible = true;
                LogoutBtn.Visible = false;
                ManagePanel.Visible = false;
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["UserCookie"] != null)
            {
                HttpCookie userCookie = new HttpCookie("UserCookie");
                Request.Cookies["UserCookie"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(userCookie);
            }
            Session.Abandon();
            Response.Redirect("~/Views/Login.aspx");
        }
    }
}