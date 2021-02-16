<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConTact.aspx.cs" Inherits="WebApp2.ConTact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>My Ticket - Contact</title>
    <link href="/Content/Site.css" rel="stylesheet" type="text/css" />
    <link href="/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="/Scripts/modernizr-2.8.3.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="/MyTicket.aspx">My Ticket Book</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a href="Join.aspx">회원가입</a></li>
                        <li><a href="Contact.aspx">연락처</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="container body-content">
            <h2>Contact</h2>
            <h3>Made by Lizzy</h3>
            <address>
                Lizzy Lee<br />
                Phone.8210.6425.9418
            </address>

            <address>
                <strong>E-mail:</strong>   <a href="mailto:ljw4563@gmail.com">ljw4563@gmail.com</a><br />
            </address>
        </div>
    </form>
</body>
</html>
