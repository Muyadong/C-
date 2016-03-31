<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_9._4._1效验控件的使用.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>webForm1使用实例</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="用户："></asp:Label>
       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator">
        </asp:RequiredFieldValidator><br /> <!--注释br 意思是换行--> <%--注释内容 --%>
        
        <asp:Label ID="Label2" runat="server" Text="密码："></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_click" Text="登录" Width="54px" /><br />  <!注释>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    
    </div>
    </form>
</body>
</html>

<script runat="server">
    protected void Button1_click(object sender, EventArgs e)
    {
        if (IsValid)//在服务器端判断是否验证成功
            Response.Write("登录成功"); 
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        this.RequiredFieldValidator1.ControlToValidate = "TextBox1";
        this.RequiredFieldValidator1.Text = "用户不能为空";
        this.RequiredFieldValidator1.ErrorMessage = "请完整填写信息";
    }
    </script>