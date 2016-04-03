using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
namespace _14._5._3Session
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpSessionState session = this.Session;//获取session对象
            session["Time"] = DateTime.Now.ToString();//产生session_start事件
            if (session["Time"] != null)
            {
                Response.Write("从Session中获取时间信息：<br>");
                Response.Write(session["Time"]);//从session中获取信息
            }
        }
    }
}