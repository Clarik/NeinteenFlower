<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPasswordPage.aspx.cs" Inherits="Project_PSD.View.HomePage.ForgotPasswordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Button1" runat="server" Text="Forgot Password"></asp:Label>
            <br /><br />
            <asp:Label ID="errorEmail" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Email : "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Captcha : "></asp:Label>
            <asp:Label ID="txtCaptcha" runat="server" Text=""></asp:Label>
            <br /><br />
            <asp:Label ID="errorPassword" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="New Password : "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="resetPasswordMessage" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnResetPassword" runat="server" Text="Reset Password" OnClick="btnResetPassword_Click"/>
            <br /> <br />
            <asp:Button ID="btnBacktoHome" runat="server" Text="Back to Home" OnClick="btnBacktoHome_Click"/>
            

        </div>
    </form>
</body>
</html>
