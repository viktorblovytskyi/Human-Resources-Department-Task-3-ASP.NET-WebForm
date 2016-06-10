<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HumanResourcesDepartmentWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add employee</title>
</head>
<body>

    <form id="add_employee_form" runat="server">
    <div>
        <table class="table">
            <tbody>
                <tr>
                    <td><asp:Label runat="server">Name</asp:Label></td><td><asp:TextBox runat="server" ID="FirstName"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Surname</asp:Label></td><td><asp:TextBox runat="server" ID="LastName"></asp:TextBox><br /></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Position</asp:Label></td><td><asp:DropDownList runat="server" ID="Position"></asp:DropDownList><br /></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Contact Details</asp:Label></td><td><asp:TextBox runat="server" ID="ContactDetails"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Subdivision</asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Employer</asp:Label></td>
                </tr>
            </tbody>
            
        </table>
        
    </div>
    </form>
</body>
</html>
