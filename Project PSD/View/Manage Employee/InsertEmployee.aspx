<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertEmployee.aspx.cs" Inherits="Project_PSD.View.Manage_Employee.InsertEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label" runat="server" Text="Insert_Employee"></asp:Label>
    <br />
    <br />
    <asp:Label ID="errorEEmail" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Email : "></asp:Label>
    <asp:TextBox ID="txtEEmail" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errorEPassword" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Password : "></asp:Label>
    <asp:TextBox ID="txtEPassword" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errorEName" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Name : "></asp:Label>
    <asp:TextBox ID="txtEName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errorEAge" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Age : "></asp:Label>
    <asp:TextBox ID="txtEmployeeDOB" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errorEGender" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label11" runat="server" Text="Gender : "></asp:Label>
    <asp:RadioButton ID="Male" GroupName="EmployeeGender" runat="server" />
    <asp:Label ID="Label5" runat="server" Text="Male"></asp:Label>
    <asp:RadioButton ID="Female" GroupName="EmployeeGender" Checked ="true" runat="server" />
    <asp:Label ID="Label7" runat="server" Text="Female"></asp:Label>
    <br />
    <br />
    <asp:Label ID="errorEPhoneNumber" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Phone Number : "></asp:Label>
    <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errorEAddress" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label10" runat="server" Text="Address : "></asp:Label>
    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errorSalary" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Salary : "></asp:Label>
    <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="insertMessage" runat="server"></asp:Label>
    <br />
    <asp:Button ID="btnInsertEmployee" runat="server" Text="Insert" OnClick="btnInsert_Click"/>
    <br />
    <br />
    <asp:Button ID="btnBackToManagePage" runat="server" Text="Manage Employee" OnClick="btnBackToManagePage_Click"/>
</asp:Content>
