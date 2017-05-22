using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class Employee
  {
      private string _EmployeeId;
      private string _FirstName;
      private string _LastName;
      private string _Designation;
      private string _DateOfJoining;
      private string _Gender;
      private string _Qualification;
      private string _State;


      public string EmployeeId
      {
          get { return _EmployeeId; }
          set
          {
              if (string.IsNullOrWhiteSpace(value))
              {
                  throw new Exception("Employee Id is null.");
              }
              else
              {
                  _EmployeeId = value;
              }
          }
      }
      public string FirstName
      {
          get { return _FirstName; }
          set
          {
              if (string.IsNullOrWhiteSpace(value))
              {
                  throw new Exception("First Name is Required.");
              }
              else
              {
                  _FirstName = value;
              }
          }
      }
      public string LastName
      {
          get { return _LastName; }
          set
          {
              if (string.IsNullOrWhiteSpace(value))
              {
                  throw new Exception("last Name is Required.");
              }
              else
              {
                  _LastName = value;
              }
          }
      }
      public string Designation
      {
          get { return _Designation; }
          set
          {
              if (string.IsNullOrWhiteSpace(value))
              {
                  throw new Exception("Designation is required. ");
              }
              else
              {
                  _Designation = value;
              }
          }
      }
      public string DateOfJoining
      {
          get { return _DateOfJoining; }
          set
          {
              if (string.IsNullOrWhiteSpace(value))
              {
                  throw new Exception("Date of Joining is Required.");
              }
              else
              {
                  _DateOfJoining = value;
              }
          }
      }
      public string Gender
      {
          get { return _Gender; }
          set
          {
              if (string.IsNullOrWhiteSpace(value))
              {
                  throw new Exception("Select Gender.");
              }
              else
              {
                  _Gender = value;
              }
          }
      }
      public string Qualification
      {
          get { return _Qualification; }
          set
          {
              if (string.IsNullOrWhiteSpace(value))
              {
                  throw new Exception("Select Qualification");
              }
              else
              {
                  _Qualification = value;
              }
          }
      }
      public string State
      {
          get { return _State; }
          set
          {
              if (value == "Select State")
              {
                  throw new Exception("Please Select State.");
              }
              else
              {
                  _State = value;
              }
          }
      }
  }
}
