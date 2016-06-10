<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HumanResourcesDepartmentWebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Button runat="server" CssClass="btn btn-success" Text="Add employee" OnClick="AddEmployee" />
    <br>
    <asp:Label runat="server" ID="Label1"></asp:Label>
    <div class="table-responsive">
        <table class="table table-condensed">
        <thead>
            <tr>
                <th>id</th>
                <th>FirstName</th>
                <th>LastName</th>
                <th>Position</th>
                <th>Conyacy details</th>
                <th>Subdivision</th>
                <th>Employer</th>
                <th>Employer's id</th>
            </tr>
        </thead>
        <tbody>
            <%= PrintTableHtml()%>
        </tbody>
    </table>
    </div>
    
</asp:Content>
