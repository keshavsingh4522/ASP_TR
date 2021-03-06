<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsletterSignup.aspx.cs" Inherits="WebFormsApplication.NewsletterSignup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Newsletter Signup</h1>
            <p>
                <asp:Literal ID="ltMessage" runat="server"></asp:Literal>
            </p>
            <p>
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
&nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            </p>
        </div>
    </form>
</body>
</html>
