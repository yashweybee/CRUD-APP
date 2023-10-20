using System;
using System.Collections.Generic;
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=Students; integrated security=SSPI");
                string query = "select * from stdDetails";

                SqlCommand cd = new SqlCommand(query, con);
                con.Open();
                cd.ExecuteNonQuery();

                Response.Write("Query executed!!!");

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
    }
}