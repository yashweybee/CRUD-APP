using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_APP
{
    public partial class MainPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("data source=.; database=Students; integrated security=SSPI");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "insert into stdDetails values('" + int.Parse(txtBoxId.Text) + "','" + txtBoxName.Text + "','" + ddCity.Text + "','" + int.Parse(txtBoxAge.Text) + "','" + int.Parse(txtBoxContact.Text) + "')";

                SqlCommand cd = new SqlCommand(insertQuery, con);
                con.Open();
                cd.ExecuteNonQuery();

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);

                //SqlDataReader red = cd.ExecuteReader();
                //red.Read();

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }

        protected void btnShowRec_Click(object sender, EventArgs e)
        {
            string selectQuery = "select * from stdDetails";
            SqlCommand cm = new SqlCommand(selectQuery, con);
            SqlDataAdapter ad = new SqlDataAdapter(cm);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            GridView1.DataSource = tb;
            GridView1.DataBind();
        }
    }
}