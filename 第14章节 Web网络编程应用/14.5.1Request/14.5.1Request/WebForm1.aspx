<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_14._5._1Request.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Request实例类</title>
</head>

<script type="text/C#" runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpRequest request = this.Page.Request;
        Response.Write("<h5>系统信息</h5>");
        Response.Write("DNS:"+request.UserHostName);//获取DNS
        Response.Write("<br>");
        Response.Write("IP:"+request.UserHostAddress);//获取IP
        Response.Write("<br>浏览器："+request.Browser.Type +"-"+request.Browser.Version);
        Response.Write("<br>操作系统："+request.Browser.Platform);
        Response.Write("<br><h5>参数信息</h5>");
        if(request.Params["ID"]!=null)
        {
            Response.Write(request.Params["ID"].ToString());
        }
    }
</script>
<body>
    <form id="form1" runat="server">
    <div> 
    </div>
    </form>
</body>
</html>
