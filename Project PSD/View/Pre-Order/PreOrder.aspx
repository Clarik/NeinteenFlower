<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="PreOrder.aspx.cs" Inherits="Project_PSD.View.Pre_Order.PreOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:Label ID="Label1" runat="server" Text="Flower List"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnOrder" Text="Pre-Order" runat="server" PostBackUrl='<%# "OrderFlower.aspx?id=" +  Eval("Id")%>'/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
