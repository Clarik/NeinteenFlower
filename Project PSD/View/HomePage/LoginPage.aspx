<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Project_PSD.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Login Page"></asp:Label>
            <br /> <br />
            <asp:Label ID="errorEmail" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="email" runat="server" Text="Email : "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="errorPassword" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="password" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br /> <br />
            <asp:CheckBox ID="remember_Me" runat="server" /> 
            <label for="rememberMe">Remember me</label>

            <br />
            <asp:Label ID="errorLogin" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>
            <br /> <br />
            <asp:Button ID="btnBacktoHome" runat="server" Text="Back to Home" OnClick="btnBacktoHome_Click"/>
            

        </div>
    </form>
</body>
</html>
