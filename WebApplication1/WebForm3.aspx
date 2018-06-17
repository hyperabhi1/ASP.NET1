<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 172px;
        }
        #Text1 {
            width: 128px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        ASP.NET SERVER CONTROL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="129px"></asp:TextBox>
        <br />
        <br />
        HTML CONTROL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input id="Text1" type="text" runat="server"/><br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="29px" OnClick="Button1_Click1" Text="Button" Width="86px" />
    </form>
</body>
</html>
