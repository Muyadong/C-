using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _9._4._3_Regular效验控件的使用
{
    public partial class RegularExpressionValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegularExpressionValidator1.ControlToValidate = "TextBox2";//设置要验证的控件
            RegularExpressionValidator1.Text = "身份证号有误！";//验证失败的错误信息
            RegularExpressionValidator1.ValidationExpression = @"\d{17}[\d|X]|\d{15}";//验证的正则表达式

            RegularExpressionValidator2.ControlToValidate = "TextBox4";
            RegularExpressionValidator2.Text = "邮编不正确！";
            RegularExpressionValidator2.ValidationExpression = @"\d{6}";//6位数
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Response.Write("验证成功！");
            }
        }
    }
}