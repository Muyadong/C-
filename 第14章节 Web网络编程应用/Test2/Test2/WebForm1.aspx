<%@ Page Language="C#" %>
<html>
    <head>
        <title>使用<script>...</script>示例</title>
        <script language="C#" Runat="Server">
            string func1(string day)
            {
                string plan = "";
                switch (day)
                {
                    case "Monday":
                        plan = "上班";
                        break;
                    case "Thuseday":
                        plan = "上班";
                        break;
                    case "Wednesday":
                        plan = "上班";
                        break;
                    case "Thursday":
                        plan = "上班";
                        break;
                    case "Friday":
                        plan = "上班";
                        break;
                    default:
                        plan = "周末狂欢！";
                        break; 
                }
                return plan;
            }
            </script>
    </head>
    <body>
    <%
        string today = System.DateTime.Today.DayOfWeek.ToString();
        string output = func1(today);
        Response.Write("今天是："+today+",我"+output);
     %>
    </body>
</html>