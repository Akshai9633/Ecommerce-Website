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
    public partial class cartview : System.Web.UI.Page
    {
        CONCLS obj = new CONCLS();

        public void grid_bind()
        {
            string str = "select Cart.Cart_Id,Product.Name,Product.Image,Cart.Quantity,Cart.Product_Total from  Product join Cart on Product.Product_Id=Cart.Product_Id";
            DataSet ds = obj.Fn_Dataset(str);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        public void total_price()
        {
            int sum = 0;
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(GridView1.Rows[i].Cells[4].Text);
            }
            Label3.Text = sum.ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                grid_bind();
                total_price();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from Cart where Cart_Id=" + id + "";
            int q = obj.Fn_Nonquery(del);
            grid_bind();
            total_price();
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

            string a = "select Quantity from Cart where Cart_Id=" + id + "";
            string cq = obj.Fn_scalar(a);
            string b = "select Product_Total from Cart where Cart_Id=" + id + "";
            string ip = obj.Fn_scalar(b);
            int im = Convert.ToInt32(ip) / Convert.ToInt32(cq);
            TextBox txtqty = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];

            int s = Convert.ToInt32(txtqty.Text) * im;
            string v = "update Cart set Quantity=" + txtqty.Text + ",Product_Total=" + s + " where Cart_Id=" + id + "";
            int j = obj.Fn_Nonquery(v);
            GridView1.EditIndex = -1;
            grid_bind();
            total_price();
        }
    }
}