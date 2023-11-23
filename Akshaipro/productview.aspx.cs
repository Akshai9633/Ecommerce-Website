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
    public partial class productview : System.Web.UI.Page
    {
        CONCLS obj = new CONCLS();
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = "select Name,Image,Price,Description from Product where Product_Id=" + Session["proid"] + "";
            SqlDataReader da = obj.Fn_Datareader(a);
            while (da.Read())
            {
                Image1.ImageUrl = da["Image"].ToString();
                Label1.Text = da["Name"].ToString();
                Label2.Text = da["Price"].ToString();
                Label3.Text = da["Description"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select max(Cart_Id) from Cart";
            string n = obj.Fn_scalar(s);
            int carttid = 0;
            if (n == "")
            {
                carttid = 1;
            }
            else
            {
                int newcarid = Convert.ToInt32(n);
                carttid = newcarid + 1;
            }
            int t = Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(Label2.Text);
            int r = Convert.ToInt32(Session["userid"]);
            int g = Convert.ToInt32(Session["proid"]);

            string a = "insert into Cart values(" + carttid + "," + r + "," + g + "," + TextBox1.Text + "," + t + ")";
            int f = obj.Fn_Nonquery(a);
            if(f==1)
            {
                Label4.Visible = true;
                Label4.Text = "Cart is Added";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Categgory.aspx");
        }
    }
}