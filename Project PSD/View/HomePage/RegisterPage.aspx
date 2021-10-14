<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Project_PSD.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Register Page"></asp:Label>
            <br /> <br />
            <asp:Label ID="errName" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label runat="server" Text="Name: "></asp:Label>
                <asp:TextBox ID="txtMemberName" runat="server"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="errDOB" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label runat="server" Text="Date Of Birth: "></asp:Label>
            <asp:TextBox ID="txtMemberDOB" runat="server" TextMode="Date"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="errGender" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label runat="server" Text="Gender : "></asp:Label>
            <asp:RadioButton ID="MaleMember" GroupName="MemberGender" runat="server" />Male
            <asp:RadioButton ID="FemaleMember" GroupName="MemberGender" Checked ="true" runat="server" />Female
            <br /> <br />
            <asp:Label ID="errAddress" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label runat="server" Text="Address: "></asp:Label>
            <asp:TextBox ID="txtMemberAddress" runat="server"></asp:TextBox>  
            <br /> <br />
            <asp:Label ID="errPhone" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label runat="server" Text="Phone: "></asp:Label>
            <asp:TextBox ID="txtMemberPhone" runat="server" Textmode="Number"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="errEmail" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtMemberEmail" runat="server"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="errPass" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="txtMemberPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="registerMessage" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="RegisterMember" runat="server" Text="Register" OnClick="RegisterMember_Click"  />
            <br /> <br />
            <asp:Button ID="btnBacktoHome" runat="server" Text="Back to Home" OnClick="btnBacktoHome_Click"/>
        </div>
    </form>
</body>
</html>
