using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _14._4._2codefile
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hello World,ASP.NET";

            Response.Write("用户操作的控件名为：" + ((System.Web.UI.WebControls.WebControl)sender).ID.ToString() + "<br>");
            Response.Write("用户操作的参数为："+e.ToString()+"<br>");
        }
    }
}