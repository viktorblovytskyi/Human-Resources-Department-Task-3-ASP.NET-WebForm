<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/AddEmployeeForm.aspx.cs" Inherits="HumanResourcesDepartmentWebApplication.AddChangeEmployeeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add employee</title>
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="~/">Application name</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/">Home</a></li>
                    </ul>
                </div>
            </div>
        </div>  
     
    <div class="add-form container">    
        <form id="add_employee_form" runat="server" defaultbutton="SubmitButton" defaultfocus="FirstName">

            <div>
                <asp:Label runat="server" ID="Emp_id" Visible="true"></asp:Label>
                <table class="table">
                    <tbody>
                        <tr>
                            <td>
                                <asp:Label runat="server" CssClass="col-sm-2 control-label">Name</asp:Label></td>
                            <td>
                                <asp:TextBox runat="server" CssClass="form-control col-xs-4" ID="FirstName"></asp:TextBox></td>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="You must enter Name!<br>" ControlToValidate="FirstName"></asp:RequiredFieldValidator>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" CssClass="col-sm-2 control-label">Surname</asp:Label></td>
                            <td>
                                <asp:TextBox runat="server" CssClass="form-control col-xs-4" ID="LastName"></asp:TextBox><br />
                            </td>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="You must enter Surname!<br>" ControlToValidate="LastName"></asp:RequiredFieldValidator>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" CssClass="col-sm-2 control-label">Contact Details</asp:Label></td>
                            <td>
                                <asp:TextBox runat="server" CssClass="form-control col-xs-4" ID="ContactDetails"></asp:TextBox></td>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="You must enter Contact Details!<br>" ControlToValidate="ContactDetails"></asp:RequiredFieldValidator>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" CssClass="col-sm-2 control-label">Position</asp:Label></td>
                            <td>
                                <asp:DropDownList runat="server" CssClass="form-control col-xs-4" ID="Position"></asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" CssClass="col-sm-2 control-label">Subdivision</asp:Label></td>
                            <td>
                                <asp:DropDownList runat="server" CssClass="form-control col-xs-4" ID="Subdivision"></asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" CssClass="col-sm-2 control-label">Employer</asp:Label></td>
                            <td>
                                <asp:DropDownList runat="server" CssClass="form-control col-xs-4" ID="Employeer"></asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td><a href="Default.aspx" class="btn btn-danger btn-block">Back</a></td>
                            <td>
                                <asp:Button runat="server" CssClass="btn btn-success btn-block" ID="SubmitButton" Text="Submit" OnClick="AddEmployee" Visible="true" />
                                <asp:Button runat="server" CssClass="btn btn-primary btn-block" ID="ChangeButton" Text="Submit" OnClick="ChangeEmployee" Visible="false" />
                            </td>
                        </tr>
                    </tbody>

                </table>

            </div>
        </form>
    </div> 
</body>
</html>
