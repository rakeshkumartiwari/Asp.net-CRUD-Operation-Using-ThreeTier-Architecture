using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DAL;
namespace GridViewCrudOperation
{
    public partial class Delete : System.Web.UI.Page
    {

        EmployeeSqlRepository objRepository = new EmployeeSqlRepository();
        private string selectedId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SelectedEmployeeId"] != null)
            {
                selectedId = Session["SelectedEmployeeId"].ToString();
            }
            if (!IsPostBack)
            {
                DataSet objDataSet = objRepository.GetEmployee(selectedId);
                lblFirstName.Text = objDataSet.Tables[0].Rows[0]["FirstName"].ToString();
                lblLastName.Text = objDataSet.Tables[0].Rows[0]["LastName"].ToString();
                lblDesignation.Text = objDataSet.Tables[0].Rows[0]["Designation"].ToString();
                lblDateOfJoining.Text = objDataSet.Tables[0].Rows[0]["DateOfJoining"].ToString();
                lblGender.Text = objDataSet.Tables[0].Rows[0]["Gender"].ToString();
                lblQualification.Text = objDataSet.Tables[0].Rows[0]["Qualification"].ToString();
                lblState.Text = objDataSet.Tables[0].Rows[0]["State"].ToString();


            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            objRepository.DeleteEmployee(selectedId);
            Response.Redirect("~/Registered.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registered.aspx");
        }
    }
}