<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewFlower.aspx.cs" Inherits="Project_PSD.View.ViewFlower" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Flower List"></asp:Label>
    <br />
    <asp:GridView ID="Grid_View" runat="server" OnSelectedIndexChanged="Grid_View_SelectedIndexChanged">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnUpdate" Text="Update" runat="server" PostBackUrl='<%# "UpdateFlower.aspx?id=" +  Eval("Id")%>'/>
                    <asp:Button ID="btnDelete" OnClick="btnDelete_Click" Text="Delete" runat="server" PostBackUrl='<%# "ViewFlower.aspx?id=" +  Eval("Id")%>'/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnInsert" Text="Insert" runat="server" OnClick="btnInsert_Click"/>
    <br />

</asp:Content>
