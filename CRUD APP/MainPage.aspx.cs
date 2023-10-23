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
            if (!IsPostBack)
            {
                Load_Rec();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "insert into stdDetails values('" + int.Parse(txtBoxId.Text) + "','" + txtBoxName.Text + "','" + ddCity.Text + "','" + int.Parse(txtBoxAge.Text) + "','" + int.Parse(txtBoxContact.Text) + "')";

                SqlCommand cd = new SqlCommand(insertQuery, con);
                con.Open();
                cd.ExecuteNonQuery();
                con.Close();

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                Load_Rec();

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!!')", true);
            }
        }

        public void Load_Rec()
        {
            try
            {
                string selectQuery = "select * from stdDetails";
                SqlCommand cm = new SqlCommand(selectQuery, con);
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cm);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                con.Close();
                GridView1.DataSource = tb;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "update stdDetails set StudentName = '" + txtBoxName.Text + "', City = '" + ddCity.Text + "'     , Age = '" + int.Parse(txtBoxAge.Text) + "', Contact = '" + int.Parse(txtBoxContact.Text) + "' where StudentId = '" + int.Parse(txtBoxId.Text) + "'";
                SqlCommand cd = new SqlCommand(updateQuery, con);
                con.Open();
                cd.ExecuteNonQuery();
                con.Close();

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Updated Successfully')", true);
                Load_Rec();

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!!')", true);
            }

        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "delete stdDetails where StudentId = '" + int.Parse(txtBoxId.Text) + "'";
                SqlCommand cd = new SqlCommand(updateQuery, con);
                con.Open();
                cd.ExecuteNonQuery();
                con.Close();

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Deleted Successfully')", true);
                Load_Rec();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!!')", true);
            }
        }

        protected void btnSelectRec_Click(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "select * from stdDetails where StudentId = '" + int.Parse(txtBoxId.Text) + "'";
                SqlCommand cm = new SqlCommand(selectQuery, con);
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cm);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                con.Close();
                GridView1.DataSource = tb;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!!')", true);
            }
        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            Load_Rec();
        }

        protected void btnGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string selectQuery = "select * from stdDetails where StudentId = '" + int.Parse(txtBoxId.Text) + "'";
                SqlCommand cm = new SqlCommand(selectQuery, con);
                con.Open();
                SqlDataReader red = cm.ExecuteReader();
                while (red.Read())
                {
                    txtBoxName.Text = red.GetValue(1).ToString();
                    ddCity.Text = red.GetValue(2).ToString();
                    txtBoxAge.Text = red.GetValue(3).ToString();
                    txtBoxContact.Text = red.GetValue(4).ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error!!')", true);
            }
        }
    }
}