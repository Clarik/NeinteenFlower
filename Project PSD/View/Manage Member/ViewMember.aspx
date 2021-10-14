<%@Page EnableEventValidation="false"  Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewMember.aspx.cs" Inherits="Project_PSD.View.Manage_Member.ViewMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Member List"></asp:Label>
    <br />
        <asp:GridView ID="Member_Grid" runat="server">
            <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="UpdateMember" runat="server" Text="Update" PostBackUrl='<%# "UpdateMember.aspx?id=" +  Eval("Id")%>'></asp:Button>
                    <asp:Button ID="DeleteMember" OnClick="DeleteMember_Click" runat="server" Text="Delete" PostBackUrl='<%# "ViewMember.aspx?id=" +  Eval("Id")%>'></asp:Button>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        </asp:GridView>
    <br />
    <asp:Button ID="InsertMember" runat="server" Text="Insert" OnClick="InsertMember_Click" />
</asp:Content>
