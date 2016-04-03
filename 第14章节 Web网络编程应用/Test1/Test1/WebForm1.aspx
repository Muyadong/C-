<%@ Page Language="C#" %>
<html>
<head><title>使用<% %></title></head>
<body>
<center>
    <%
    int i;
    for(i=0;i<8;i++)
    {
    %>
     <font size=<% Response.Write(i); %>>Hello World!</font><br />
     <% } %>
</center>
</body>
</html>