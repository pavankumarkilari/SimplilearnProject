using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebformsApplication
{
    public partial class SubjectsDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=LAPTOP-T7MCP4KU;database=ProjectCRUDDb;trusted_connection=true;");
                SqlCommand cmd = new SqlCommand("select * from  Subject", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                LblMsg.Text = "Number of Subjects are:" + ds.Tables[0].Rows.Count;
                gvsubjects.DataSource = ds.Tables[0];
                gvsubjects.DataBind();
                con.Close();
            }
            catch (Exception ex)
            {
                LblMsg.Text += "Error!!!" + ex.Message;
            }
        }
    }
}