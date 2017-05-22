using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
namespace GridViewCrudOperation
{
    public partial class Registered : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var objRepository = new EmployeeSqlRepository();
                GridView1.DataSource = objRepository.GetAllEmployees();
                GridView1.DataBind();
            }
           
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }

        protected void GridView1_OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            var datakey = GridView1.DataKeys[e.NewEditIndex];
            if (datakey != null)
            {
                Session["SelectedEmployeeId"] = datakey.Value.ToString();
                Response.Redirect("~/Edit.aspx");
            }
        }

        protected void GridView1_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var datakey = GridView1.DataKeys[e.RowIndex];
            if (datakey != null)
            {
                Session["SelectedEmployeeId"] = datakey.Value.ToString();
                Response.Redirect("~/Delete.aspx");
            }
        }
    }
}