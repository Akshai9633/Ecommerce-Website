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
    public partial class Productt : System.Web.UI.Page
    {
        CONCLS obj = new CONCLS();

        public void grid_bind()
        {
            string str = "select * from Product";
            DataSet ds = obj.Fn_Dataset(str);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid_bind();
            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
           
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
           
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
           
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photo/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ins = "insert into Product values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + p + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DropDownList1.SelectedItem.Value + "','" + DropDownList2.SelectedItem.Value + "')";
            int i = obj.Fn_Nonquery(ins);
            if (i == 1)
            {
                Label9.Text = "Inserted...";
            }
        }

        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            grid_bind();
        }

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtname = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox txtdesc = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];
            TextBox txtprice = (TextBox)GridView1.Rows[i].Cells[8].Controls[0];
            TextBox txtstatus = (TextBox)GridView1.Rows[i].Cells[9].Controls[0];
            TextBox txtstock = (TextBox)GridView1.Rows[i].Cells[10].Controls[0];
            string update = "update Product set Name='" + txtname.Text + "',Description='" + txtdesc.Text + "',Price='" + txtprice .Text + "',Status='"+txtstatus.Text+"',Stock='"+txtstock.Text+"' where Product_Id=" + id + "";
            int j = obj.Fn_Nonquery(update);
            GridView1.EditIndex = -1;
        }

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            grid_bind();
        }

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from Product where Product_Id=" + id + "";
            int q = obj.Fn_Nonquery(del);
            grid_bind();
        }
    }
}