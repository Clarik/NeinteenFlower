<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertMember.aspx.cs" Inherits="Project_PSD.View.Manage_Member.InsertMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server" Text="Insert Member"></asp:Label>
    <br />
    <br />
    <asp:Label ID="errName" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="txtMemberName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errDOB" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Date Of Birth: "></asp:Label>
    <asp:TextBox ID="txtMemberDOB" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errGender" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Gender : "></asp:Label>
        <asp:RadioButton ID="MaleMember" GroupName="MemberGender" runat="server" />
        <asp:Label ID="Label5" runat="server" Text="Male"></asp:Label>
        <asp:RadioButton ID="FemaleMember" GroupName="MemberGender" Checked ="true" runat="server" />
        <asp:Label ID="Label1" runat="server" Text="Female"></asp:Label>
    <br />
    <br />
    <asp:Label ID="errAddress" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Address: "></asp:Label>
        <asp:TextBox ID="txtMemberAddress" runat="server"></asp:TextBox>  
    <br />
    <br />
    <asp:Label ID="errPhone" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Phone: "></asp:Label>
        <asp:TextBox ID="txtMemberPhone" runat="server" ></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errEmail" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="txtMemberEmail" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errPass" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtMemberPassword" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="insertMessage" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="MemberInsert" runat="server" Text="Insert" OnClick="MemberInsert_Click"  />
    <br />
    <br />
    <asp:Button ID="ViewMember" runat="server" Text="View Member" OnClick="ViewMember_Click"/>
</asp:Content>
