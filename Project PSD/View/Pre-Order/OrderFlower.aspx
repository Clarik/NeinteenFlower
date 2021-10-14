<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="OrderFlower.aspx.cs" Inherits="Project_PSD.View.Pre_Order.OrderFlower" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Pre-Order Flower: "></asp:Label>
    <asp:Label ID="Fid" runat="server" Text="0"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Flower name: "></asp:Label>
    <asp:Label ID="Fname" runat="server" Text="0"></asp:Label>
    <br />
        <asp:Label ID="Label4" runat="server" Text="Flower type: "></asp:Label>
    <asp:Label ID="Ftype" runat="server" Text="0"></asp:Label>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Price: "></asp:Label>
    <asp:Label ID="Fprice" runat="server" Text="0"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Input Quantity"></asp:Label>
    <br />
    <asp:TextBox ID="Fquan" runat="server" TextMode="Number"></asp:TextBox>
    <br />
    <asp:Button ID="preOrder" runat="server" Text="Pre-Order" OnClick="preOrder_Click" />

</asp:Content>
