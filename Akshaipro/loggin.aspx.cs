﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Akshaipro
{
    public partial class loggin : System.Web.UI.Page
    {
        CONCLS obj = new CONCLS();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(Reg_Id) from User_login where Username='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "'";
            string cid = obj.Fn_scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string str1 = "select Reg_Id from User_login where Username = '" + TextBox1.Text + "' and Password = '" + TextBox2.Text + "'";
                string regid = obj.Fn_scalar(str1);
                Session["userid"] = regid;
                string str2 = "select Log_type from User_login where Username = '" + TextBox1.Text + "' and Password = '" + TextBox2.Text + "'";
                string logtype = obj.Fn_scalar(str2);
                if (logtype == "admin")
                {
                    Label3.Text = "Admin";
                }
                else if (logtype == "user")
                {
                    Label3.Text = "User";
                }
            }
        }
    }
}