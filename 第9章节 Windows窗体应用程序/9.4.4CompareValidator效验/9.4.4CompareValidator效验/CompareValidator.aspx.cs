using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _9._4._4CompareValidator效验
{
    public partial class CompareValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.CompareValidator1.ControlToValidate = "TextBox2";
            //指定验证数据类型
            this.CompareValidator1.Operator = ValidationCompareOperator.DataTypeCheck;
            this.CompareValidator1.Type = ValidationDataType.Integer;
            this.CompareValidator1.Text = "只接受数据密码！";

            this.CompareValidator2.ControlToValidate = "TextBox3";//默认控件值比较
            this.CompareValidator2.ControlToCompare = "TextBox2";//指定比较的控件
            this.CompareValidator2.Type = ValidationDataType.String;//指定比较的数据类型
            this.CompareValidator2.Text = "两次密码不一致！";
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