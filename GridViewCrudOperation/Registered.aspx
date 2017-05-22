<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registered.aspx.cs" Inherits="GridViewCrudOperation.Registered" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"><strong>Registered Employees</strong></td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="EmployeeId" OnRowEditing="GridView1_OnRowEditing" OnRowDeleting="GridView1_OnRowDeleting">
                        
                        <Columns>
                            <asp:BoundField HeaderText="First Name" DataField="FirstName"/>
                            <asp:BoundField HeaderText="Last Name" DataField="LastName"/>
                            <asp:BoundField HeaderText="Designation" DataField="Designation"/>
                            <asp:BoundField HeaderText="Date of Joining" DataField="DateOfJoining"/>
                            <asp:BoundField HeaderText="Gender" DataField="Gender"/>
                            <asp:BoundField HeaderText="Qualification" DataField="Qualification"/>
                            <asp:BoundField HeaderText="State" DataField="State"/>
                            <asp:CommandField ShowEditButton="True"/>
                            <asp:CommandField ShowDeleteButton="True"/>
                        </Columns>
                        

                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
