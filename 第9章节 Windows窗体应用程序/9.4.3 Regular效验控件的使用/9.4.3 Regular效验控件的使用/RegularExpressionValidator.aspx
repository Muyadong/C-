<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegularExpressionValidator.aspx.cs" Inherits="_9._4._3_Regular效验控件的使用.RegularExpressionValidator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RegularExpression使用实例</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 341px">
    
        <br />
&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" style="font-size: xx-large" Text="联系信息"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="姓名："></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
&nbsp;
        <br />
&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="身份证："></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
        <br />
        <br />
&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="住址："></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="邮编："></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="确定" />
    
    </div>
    </form>
</body>
</html>
