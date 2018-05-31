<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Template message.aspx.cs" Inherits="TestLineBot.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Push Text Message" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Push Sticker Message" />

    
        <br />

    
        <br />

    
    </div>
        <asp:Button ID="Button3" runat="server" Text="Push Tempalte Message" OnClick="Button3_Click" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
    </form>
</body>
</html>
