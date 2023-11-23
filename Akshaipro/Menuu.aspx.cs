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
    public partial class Menuu : System.Web.UI.Page
    {
        CONCLS obj = new CONCLS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string str = "select * from Categoryy";
                DataSet ds = obj.Fn_Dataset(str);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int catid = Convert.ToInt32(e.CommandArgument);
            Session["catid"] = catid;
            Response.Redirect("subpages.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }
    }
}