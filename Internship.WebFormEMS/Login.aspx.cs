using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internship.WebFormEMS
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("SELECT * FROM EmpRegister WHERE Email=@email AND Password=@password", con);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();   
            if(sdr.HasRows)
            {
                sdr.Read();
                Session["EmployeeId"]=sdr.GetValue(0);   
                Response.Redirect("Profile.aspx");
            }
            else
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "swal('Invalid Login..!','','error');", true);
            }

        }
    }
}