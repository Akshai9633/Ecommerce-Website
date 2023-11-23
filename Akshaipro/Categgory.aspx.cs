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
    public partial class Categgory : System.Web.UI.Page
    {
        CONCLS obj = new CONCLS();
        public void grid_bind()
        {
            string str = "select * from Categoryy";
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photo/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ins = "insert into Categoryy values('" + DropDownList1.SelectedItem.Value + "','" + p + "','" + TextBox1.Text + "','" + DropDownList2.SelectedItem.Value + "')";
            int i = obj.Fn_Nonquery(ins);
            grid_bind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from Categoryy where Cat_Id=" + id + "";
            int q = obj.Fn_Nonquery(del);
            grid_bind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            grid_bind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            grid_bind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtname = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            TextBox txtdesc = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            TextBox txtstatus = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];
            string update = "update Categoryy set Cat_Name='" + txtname.Text + "',Cat_Description='" + txtdesc.Text + "',Cat_Status='" + txtstatus.Text + "' where Cat_Id=" + id + "";
            int j = obj.Fn_Nonquery(update);
            GridView1.EditIndex = -1;
        }
    }
}