﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HumanResourcesDepartmentWebApplication._Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="btn-group ">
        <asp:Button runat="server" CssClass="btn btn-success" Text="Add employee" OnClick="AddEmployee" />
        <asp:Button runat="server" CssClass="btn btn-warning" Text="Add employer" OnClick="AddEmployee" />
        <asp:Button runat="server" CssClass="btn btn-info" Text="Display Subdivisions" />       
    <br>
    </div>
    <div>
        <table>
            <tbody>
                <tr>
                    <td><asp:Label runat="server">ID: </asp:Label></td>
                    <td><asp:TextBox runat="server" CssClass="form-control col-xs-1" ToolTip="Employee's id." ID="EmployeeId" ></asp:TextBox></td>
                    <td><asp:Button runat="server" CssClass="btn btn-danger" Text="Delete Employee" ID="DeleteEmp" OnClick="DeleteEmployee" /></td>
                    <td><asp:Label runat="server" ID="ErrorMsg"></asp:Label></td>
                </tr>
            </tbody>
        </table>
    </div>
   
    <asp:Label runat="server" ID="Label1"></asp:Label>
    <div class="table-responsive">
        <table class="table table-condensed" aria-selected="true">
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
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
            <%= PrintTableHtml()%>
        </tbody>
    </table>
    </div>
    
</asp:Content>
