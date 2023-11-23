using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Akshaipro
{
    public partial class Adminreg : System.Web.UI.Page
    {
        CONCLS obj = new CONCLS();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from User_login";
            string regid = obj.Fn_scalar(sel);
            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            string ins = "insert into Admin_reg values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = obj.Fn_Nonquery(ins);
            if (i != 0)
            {
                string inslog = "insert into User_login values(" + reg_id + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','admin','active')";
                int j = obj.Fn_Nonquery(inslog);
            }
        }
    }
}