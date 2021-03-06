﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GetIPAddress.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Get IP Address</title>
    <link href="Files/css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1><strong>Your IP Address : </strong></h1>
        <br/>
        <h1><strong>Method 1 : </strong><asp:Label ID="lblIPAddress" CssClass="label label-primary" runat="server" Text="Label"></asp:Label></h1>
        <br />
        <h1><strong>Method 2 : </strong><asp:Label ID="lblIPAdd" CssClass="label label-info" runat="server" Text="Label"></asp:Label></h1>
    </div>
    </form>
</body>
</html>
