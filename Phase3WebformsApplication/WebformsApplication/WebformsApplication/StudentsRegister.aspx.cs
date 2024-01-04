using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebformsApplication
{
    public partial class StudentsRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            SqlConnection con = new SqlConnection("server=LAPTOP-T7MCP4KU;database=WebFormDb;trusted_connection=true;");
            try
            {

                SqlCommand cmd = new SqlCommand("insert into Student(StudentId,FirstName,LastName,Gender,ClassId) values(@StudentId,@fname,@lname,@gender,@classid) ", con);
                cmd.Parameters.AddWithValue("@StudentId", int.Parse(TxtStdntId.Text));
                cmd.Parameters.AddWithValue("@fname", TxtStdntFname.Text);
                cmd.Parameters.AddWithValue("@lname", TxtStdntLname.Text);
                cmd.Parameters.AddWithValue("@gender", TxtStdntGender.Text);
                cmd.Parameters.AddWithValue("@classid", int.Parse(TxtClassId.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                LblMsg.Text = "Student Record Inserted!!!";


            }
            catch (Exception ex)
            {
                LblMsg.Text += "Error!!!" + ex.Message;
            }
            finally { con.Close(); }
        }
    }
}