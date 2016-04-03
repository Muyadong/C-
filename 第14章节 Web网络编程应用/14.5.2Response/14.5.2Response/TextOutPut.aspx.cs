using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _14._5._2Response
{
    public partial class TextOutPut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 4; i > 0; i--)
            {
                Response.Write(string.Format("<h{0}><li>页面输出文本{0}</h{0}><br>", i));
            }

            System.Drawing.Image image = new System.Drawing.Bitmap(200, 100);//创建图像
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(image);
            g.FillRectangle(System.Drawing.Brushes.Gray, 0, 0, 200, 100);//画背景
            System.Drawing.Font font = new System.Drawing.Font("宋体", 16);
            g.DrawString("图片文字", font, System.Drawing.Brushes.Black, 10, 10);//画文字
            image.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Gif);
            image.Dispose();
            font.Dispose();

        }
    }
}