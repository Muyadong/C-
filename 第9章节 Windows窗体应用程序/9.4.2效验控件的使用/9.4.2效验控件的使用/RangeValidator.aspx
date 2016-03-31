<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RangeValidator.aspx.cs" Inherits="_9._4._2效验控件的使用.RangeValidator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RangeValidator使用示例</title>
</head>
<body style="height: 315px">
    <form id="form1" runat="server">
    <div style="height: 404px">
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large"  Text="用户信息"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="名称："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage="RangeValidator"></asp:RangeValidator><br />

        <asp:Label ID="Label3" runat="server" Text="年龄："></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" Type="Integer"></asp:RangeValidator><br />
 
        <asp:Label ID="Label4" runat="server" Text="生日："></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Height="17px" Width="144px"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="RangeValidator"></asp:RangeValidator><br />

        <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />

    </div>
    </form>
</body>
</html>

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        this.RangeValidator1.ControlToValidate = "TextBox2";//设置验证的控件
        this.RangeValidator1.Type = ValidationDataType.Integer;//设置数据类型
        this.RangeValidator1.MaximumValue = "120";//指定最大值
        this.RangeValidator1.MinimumValue = "10";//指定最小值
        this.RangeValidator1.Text = "年龄必须在10-120之间";//指定验证失败的错去信息

        this.RangeValidator2.ControlToValidate = "TextBox3";
        this.RangeValidator2.Type = ValidationDataType.Date;
        this.RangeValidator2.MaximumValue = DateTime.Now.AddYears(-10).ToShortDateString();
        this.RangeValidator2.MinimumValue = DateTime.Now.AddYears(-120).ToShortDateString();
        this.RangeValidator2.Text = "请正确填写出生日期";

        this.RangeValidator3.ControlToValidate = "TextBox1";
        this.RangeValidator3.Type = ValidationDataType.String;
        this.RangeValidator3.Text = "用户不能为空";
        //this.RangeValidator3.ErrorMessage = "请完整填写信息";
        
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            Response.Write("验证成功"); 
        } 
    }
    
    </script>
