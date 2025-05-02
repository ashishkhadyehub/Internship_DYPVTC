using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Internship.Training
{
    public partial class Register : System.Web.UI.Page
    {
        //1.Design UI form with asp controls.
        //2.Create table in database.
        //3.Apply required validations to UI fom.
        //4.Setup connection string in web.config file.
        //5.Create connection class in back end file.
        //6.Write ado.net code to store data in table.

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("insert into Users values (@name,@mobile,@city)", con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@mobile", txtContact.Text);
            cmd.Parameters.AddWithValue("@city", ddlCities.SelectedItem.Text);
            con.Open();
            cmd.ExecuteNonQuery();

            txtName.Text = "";
            txtContact.Text = "";
            ddlCities.SelectedIndex = 0;

            Response.Write("<script>alert('Data Inserted Successfully');</script>");    

        }
    }
}