<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Project_PSD.View.HomePage.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Home Page"></asp:Label>
    <br /> <br />
    <div id="guestBtnList" runat="server">
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click"/>
        <asp:Button ID="btnForgotPassword" runat="server" Text="Forgot Password" OnClick="btnForgotPassword_Click"/>
        <br />
    </div>

    <div id="adminBtnList" runat="server">
        <br />
        <asp:Button ID="btnManageMember" Text="Manage Member" runat="server" OnClick="btnManageMember_Click"/>
        <asp:Button ID="btnManageEmployee" Text="Manage Employee" runat="server" OnClick="btnManageEmployee_Click"/>
        <br />
    </div>
    <div id="memberBtnList" runat="server">
        <%-- Tabel for show flower list in database --%>
        <br />
        <asp:Button ID="btnPreOrder" Text="Pre Order" runat="server" OnClick="btnPreOrder_Click"/>
        <asp:Button ID="btnTransactionHistory" Text="View Transaction History" runat="server" OnClick="btnTransactionHistory_Click"/>
        <br />
    </div>
    <div id="employeeBtnList" runat="server">
        <br />
        <asp:Button ID="btnManageFlower" Text="Manage Flower" runat="server" OnClick="btnManageFlower_Click"/>
        <br />
    </div>


</asp:Content>
