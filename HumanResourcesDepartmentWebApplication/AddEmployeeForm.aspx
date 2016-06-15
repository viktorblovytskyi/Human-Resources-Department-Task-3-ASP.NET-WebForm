<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/AddEmployeeForm.aspx.cs" Inherits="HumanResourcesDepartmentWebApplication.AddChangeEmployeeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add employee</title>
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>

    <form id="add_employee_form" runat="server" defaultbutton="SubmitButton" defaultfocus="FirstName">
    <div>
        <table >
            <tbody>
                <tr>
                    <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Name</asp:Label></td>
                    <td><asp:TextBox runat="server" CssClass="form-control col-xs-4" ID="FirstName"></asp:TextBox></td>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="You must enter Name!<br>" ControlToValidate="FirstName"></asp:RequiredFieldValidator>
                </tr>
                <tr>
                    <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Surname</asp:Label></td>
                    <td><asp:TextBox runat="server" CssClass="form-control col-xs-4" ID="LastName"></asp:TextBox><br /></td>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="You must enter Surname!<br>" ControlToValidate="LastName"></asp:RequiredFieldValidator>
                </tr>
                <tr>
                    <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Contact Details</asp:Label></td>
                    <td><asp:TextBox runat="server" CssClass="form-control col-xs-4" ID="ContactDetails"></asp:TextBox></td>
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="You must enter Contact Details!<br>" ControlToValidate="ContactDetails"></asp:RequiredFieldValidator>
                </tr>
                <tr>
                    <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Position</asp:Label></td>
                    <td><asp:DropDownList runat="server" CssClass="form-control col-xs-4" ID="Position"  ></asp:DropDownList></td>
                </tr>           
                <tr>
                    <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Subdivision</asp:Label></td>
                    <td><asp:DropDownList runat="server" CssClass="form-control col-xs-4" ID="Subdivision"  ></asp:DropDownList></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Employer</asp:Label></td>
                    <td><asp:DropDownList runat="server" CssClass="form-control col-xs-4" ID="Employeer"  ></asp:DropDownList></td>
                </tr>
                <tr>
                    <td><asp:Button runat="server" CssClass="btn btn-warning btn-block" ID="EditButton" Text="Submit" Visible="false" OnClick="AddEmployee"/></td><td><asp:Button runat="server" CssClass="btn btn-success btn-block" ID="SubmitButton" Text="Submit" Visible="false" OnClick="AddEmployee"/></td>
                </tr>
            </tbody>
            
        </table>
        
    </div>
    </form>
</body>
</html>
