<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertFlower.aspx.cs" Inherits="Project_PSD.View.InsertFlower" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label100" runat="server" Text="Insert_Flower"></asp:Label>
    <br />
    <br />
    <asp:Label ID="errorName" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Name : "></asp:Label>
    <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errorImg" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Image Path : "></asp:Label>
    <asp:TextBox ID="txtFImagePath" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="errorDesc" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Description : "></asp:Label>
    <asp:TextBox ID="txtFDescription" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="errorType" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Flower Type : "></asp:Label>
    <asp:DropDownList ID="ddlFType" runat="server"></asp:DropDownList>  
    <br />
    <br />
    <asp:Label ID="errorPrice" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Price : "></asp:Label>
    <asp:TextBox ID="txtPrice" runat="server" TextMode="Number"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="insertMessage" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click"/>
    <br />
    <br />
    <asp:Button ID="btnBackToViewFlower" runat="server" Text="View Flower" OnClick="btnBackToViewFlower_Click"/>
</asp:Content>
