<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HumanResourcesDepartmentWebApplication._Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tbody>
            <tr>
                <td><asp:Label runat="server" CssClass="col-sm-2 control-label">Subdivision</asp:Label></td>
                <td><asp:DropDownList runat="server" CssClass="form-control col-xs-4" ID="SubdivisionDropList" ></asp:DropDownList></td>
                <td><asp:Button runat="server" CssClass="btn" OnClick="SelectSubdivision" Text="Select"/></td>
            </tr>
        </tbody>
    </table>  
    <br />
        <asp:Button runat="server" CssClass="btn btn-success" Text="Add employee" OnClick="AddEmployee" />
    <br>    
   
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
