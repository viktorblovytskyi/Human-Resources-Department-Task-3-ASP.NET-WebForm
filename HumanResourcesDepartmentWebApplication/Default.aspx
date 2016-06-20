<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HumanResourcesDepartmentWebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <br />
    <table class="table">
        <tbody>
            <tr>
                <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Subdivision</asp:Label></td>
                <td><asp:DropDownList runat="server" CssClass="form-control col-xs-4" ID="SubdivisionDropList"></asp:DropDownList></td>
                <td>
                    <asp:Button runat="server" CssClass="btn" OnClick="SelectSubdivision" Text="Select" />
                    <asp:Button runat="server" CssClass="btn btn-danger" Text="Delete Subdivision" OnClick="DeleteSubdivision" />
                </td>                
                <td><asp:Button runat="server" CssClass="btn btn-success" Text="Add employee" OnClick="AddEmployee" /></td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:TextBox runat="server" CssClass="form-control" ToolTip="Name of subdivison" ID="NameOfSubdivision">Name of Subdivision</asp:TextBox>
                    <asp:Button runat="server" CssClass="btn btn-success" Text="Add subdivision" OnClick="AddSubdivision" />
                    <asp:RequiredFieldValidator runat="server" ErrorMessage="You must enter name of subdivision!<br>" ControlToValidate="NameOfSubdivision"></asp:RequiredFieldValidator>
                    
                </td>
            </tr>
        </tbody>
    </table>  

    <asp:Label runat="server" ID="Label1"></asp:Label>
    <div class="table-responsive">
        <table class="table table-condensed" aria-selected="true">
        <thead>
            <tr>
                <th>id</th>
                <th>FirstName</th>
                <th>LastName</th>
                <th>Position</th>
                <th>Contact details</th>
                <th>Subdivision</th>
                <th>Employer</th>
                <th>Employer's id</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
            <%= PrintTableHtml()%>
        </tbody>
    </table>
    </div>

</asp:Content>
