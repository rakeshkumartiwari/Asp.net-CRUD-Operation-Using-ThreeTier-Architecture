<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="GridViewCrudOperation.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 98%;
        }
        .auto-style2 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 604px">
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2"><strong>Update Employee</strong></td>
            </tr>
            <tr>
                <td>First Name</td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Designation</td>
                <td>
                    <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Date of Joining</td>
                <td>
                    <asp:TextBox ID="txtDOJ" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonListGender" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Qualification</td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxListQualification" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>10th</asp:ListItem>
                        <asp:ListItem>12th</asp:ListItem>
                        <asp:ListItem>B-Tech</asp:ListItem>
                        <asp:ListItem>PG</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td>State</td>
                <td>
                    <asp:DropDownList ID="ddlState" runat="server">
                        <asp:ListItem>Select State</asp:ListItem>
                        <asp:ListItem>Odisha</asp:ListItem>
                        <asp:ListItem>West Bengal</asp:ListItem>
                        <asp:ListItem>MP</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
