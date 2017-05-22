using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;
namespace GridViewCrudOperation
{
    public partial class Index : System.Web.UI.Page
    {
        Employee objEmployee = new Employee();
        EmployeeSqlRepository objRepository = new EmployeeSqlRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SetObjectFromUI();

        }

        private void SetObjectFromUI()
        {
            try
            {
                string qualifictions = "";
                string gender = "";
                foreach (ListItem item in RadioButtonListGender.Items)
                {
                    if (item.Selected)
                    {
                        gender = item.Text;
                    }
                }
                foreach (ListItem item in CheckBoxListQualification.Items)
                {
                    if (item.Selected)
                    {
                        if (qualifictions == "")
                        {
                            qualifictions = item.Text;
                        }
                        else
                        {
                            qualifictions += "," + item.Text;
                        }
                    }

                }
                objEmployee.EmployeeId = GenerateId();
                objEmployee.FirstName = txtFirstName.Text;
                objEmployee.LastName = txtLastName.Text;
                objEmployee.Designation = txtDesignation.Text;
                objEmployee.DateOfJoining = txtDOJ.Text;
                objEmployee.Gender = gender;
                objEmployee.Qualification = qualifictions;
                objEmployee.State = ddlState.SelectedValue.ToString();
                objRepository.SaveEmployee(objEmployee);
                Response.Redirect("~/Registered.aspx");
            }
            catch (Exception exception)
            {

                lblError.Text = exception.Message.ToString();
            }

        }

        private string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registered.aspx");
        }
    }
}