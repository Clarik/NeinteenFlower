<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateMember.aspx.cs" Inherits="Project_PSD.View.Manage_Member.UpdateMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="MemberID" runat="server" Text="Update Member"></asp:Label>
    <br />
    <br />
    <asp:Label ID="errNameU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="txtMemberName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errDOBU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Date Of Birth: "></asp:Label>
        <asp:TextBox ID="txtMemberDOB" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errGenderU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Gender : "></asp:Label>
        <asp:RadioButton ID="MaleMember" GroupName="MemberGender" runat="server" />
        <asp:Label ID="Label5" runat="server" Text="Male"></asp:Label>
        <asp:RadioButton ID="FemaleMember" GroupName="MemberGender" runat="server" />
        <asp:Label ID="Label1" runat="server" Text="Female"></asp:Label>
    <br />
    <br />
    <asp:Label ID="errAddressU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Address: "></asp:Label>
        <asp:TextBox ID="txtMemberAddress" runat="server"></asp:TextBox>  
    <br />
    <br />
    <asp:Label ID="errPhoneU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Phone: "></asp:Label>
        <asp:TextBox ID="txtMemberPhone" runat="server" Textmode="Number"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errEmailU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="txtMemberEmail" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errPassU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtMemberPassword" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="UpdateMessage" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="MemberUpdate" runat="server" Text="Update" OnClick="MemberUpdate_Click"  />
    <br />
    <br />
    <asp:Button ID="ViewMember" runat="server" Text="View Member" OnClick="ViewMember_Click"/>
</asp:Content>
