<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Clase09Tp4Dai5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            SESSIONS<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Crear Session" />
            <br />
            <br />
            COOKIES<br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Crear Cookie" />
        </div>
    </form>
</body>
</html>
