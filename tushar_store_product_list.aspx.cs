using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication7
{
    public partial class tushar_store_product_list : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source=DESKTOP-1J5P8LQ\\SQLEXPRESS;Initial catalog=tushar_stores;Integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            display();
        }
        public void display()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tushar_products", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            gv_store.DataSource = dt;
            gv_store.DataBind();
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into tushar_products(pd_name,pd_expiry,pd_reck_number)values('"+ text_pd_name + "','"+ text_pd_expiry + "','"+ text_pd_reck_no + "')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            display();
        }
    }
}