<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/AddEmployeeForm.aspx.cs" Inherits="HumanResourcesDepartmentWebApplication.AddChangeEmployeeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add employee</title>
    <webopt:bundlereference runat="server" path="~/Content/css" />
</head>
<body>

    <form id="add_employee_form" runat="server">
    <div>
        <table >
            <tbody>
                <tr>
                    <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Name</asp:Label></td><td><asp:TextBox runat="server" CssClass="form-control col-xs-4" ID="FirstName"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Surname</asp:Label></td><td><asp:TextBox runat="server" CssClass="form-control col-xs-4" ID="LastName"></asp:TextBox><br /></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Position</asp:Label></td><td><asp:DropDownList runat="server" CssClass="form-control col-xs-4" ID="Position"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Contact Details</asp:Label></td><td><asp:TextBox runat="server" CssClass="form-control col-xs-4" ID="ContactDetails"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Subdivision</asp:Label></td><td><asp:DropDownList runat="server" CssClass="form-control col-xs-4" ID="Subdivision"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Employer</asp:Label></td><td><asp:DropDownList runat="server" CssClass="form-control col-xs-4" ID="Employeer"></asp:DropDownList></td>
                </tr>
            </tbody>
            
        </table>
        
    </div>
    </form>
</body>
</html>
