<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateFlower.aspx.cs" Inherits="Project_PSD.View.UpdateFlower" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="FlowerID" runat="server" Text="Update Flower"></asp:Label>
    <br />
    <br />
    <asp:Label ID="errorNameU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Name : "></asp:Label>
    <asp:TextBox ID="txtFNameU" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errorImgU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Image Path : "></asp:Label>
    <asp:TextBox ID="txtFImagePathU" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errorDescU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Description : "></asp:Label>
    <asp:TextBox ID="txtFDescriptionU" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errorTypeU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Flower Type : "></asp:Label>
    <asp:DropDownList ID="ddlFTypeU" runat="server"></asp:DropDownList>  
    <br />
    <br />
    <asp:Label ID="errorPriceU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Price : "></asp:Label>
    <asp:TextBox ID="txtPriceU" runat="server" TextMode="Number"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="updateMessageU" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"/>
    <br />
    <br />
    <asp:Button ID="btnBackToViewFlower" runat="server" Text="View Flower" OnClick="btnBackToViewFlower_Click"/>


</asp:Content>
