<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="GridViewCrudOperation.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 98%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 293px;
        }
        .auto-style4 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 431px">
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4" colspan="2"><strong>Delete Employee</strong></td>
            </tr>
            <tr>
                <td class="auto-style2">First Name</td>
                <td class="auto-style3">
                    <asp:Label ID="lblFirstName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Last Name</td>
                <td class="auto-style3">
                    <asp:Label ID="lblLastName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Designation</td>
                <td class="auto-style3">
                    <asp:Label ID="lblDesignation" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Date of Joining</td>
                <td class="auto-style3">
                    <asp:Label ID="lblDateOfJoining" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Gender</td>
                <td class="auto-style3">
                    <asp:Label ID="lblGender" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Qualification</td>
                <td class="auto-style3">
                    <asp:Label ID="lblQualification" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">State</td>
                <td class="auto-style3">
                    <asp:Label ID="lblState" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
