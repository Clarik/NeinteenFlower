<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewEmployee.aspx.cs" Inherits="Project_PSD.View.Manage_Employee.ViewEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label" runat="server" Text="Employee_Page"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="Employee_Grid" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" PostBackUrl='<%#"UpdateEmployee.aspx?id=" + Eval("Id")%>'></asp:Button>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"  PostBackUrl='<%#"ViewEmployee.aspx?id=" + Eval("Id")%>'></asp:Button>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnInsert" Text="Insert" runat="server" OnClick="btnInsert_Click" />
</asp:Content>
