<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IsPostBack.aspx.cs" Inherits="WebApplication1.IsPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 32%;">
            <tr>
                <td colspan="2">EMPLOYEE DETAILS FORM</td>
            </tr>
            <tr>
                <td>First Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="153px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Second Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="152px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register Employee" Width="140px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
