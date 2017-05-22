using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DAL;
using BLL;

namespace GridViewCrudOperation
{

    public partial class Edit : System.Web.UI.Page
    {
        Employee objEmployee = new Employee();
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
                txtFirstName.Text = objDataSet.Tables[0].Rows[0]["FirstName"].ToString();
                txtLastName.Text = objDataSet.Tables[0].Rows[0]["LastName"].ToString();
                txtDesignation.Text = objDataSet.Tables[0].Rows[0]["Designation"].ToString();
                txtDOJ.Text = objDataSet.Tables[0].Rows[0]["DateOfJoining"].ToString();
                string gender = objDataSet.Tables[0].Rows[0]["Gender"].ToString();
                string qualificationsList = objDataSet.Tables[0].Rows[0]["Qualification"].ToString();
                ddlState.SelectedValue = objDataSet.Tables[0].Rows[0]["State"].ToString();
                char[] commaseparator = new char[] { ',' };
                string[] qualifications = qualificationsList.Split(commaseparator, StringSplitOptions.None);
                foreach (ListItem item in RadioButtonListGender.Items)
                {
                    if (item.Text == gender)
                    {
                        item.Selected = true;
                    }
                }
                foreach (ListItem item in CheckBoxListQualification.Items)
                {
                    foreach (var qualification in qualifications)
                    {
                        if (item.Text == qualification)
                        {
                            item.Selected = true;
                        }
                    }

                }

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
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
                objEmployee.EmployeeId = selectedId;
                objEmployee.FirstName = txtFirstName.Text;
                objEmployee.LastName = txtLastName.Text;
                objEmployee.Designation = txtDesignation.Text;
                objEmployee.DateOfJoining = txtDOJ.Text;
                objEmployee.Gender = gender;
                objEmployee.Qualification = qualifictions;
                objEmployee.State = ddlState.SelectedValue.ToString();
                objRepository.UpdateEmployee(objEmployee);
                Response.Redirect("~/Registered.aspx");
            }
            catch (Exception exception)
            {

                lblError.Text = exception.Message.ToString();
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registered.aspx");
        }
    }
}