<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyTicket.aspx.cs" Inherits="WebApp2.MyTicket" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>My Ticket</title>
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
            <br />
            <h2>Login</h2>
            <h4>My Ticket을 이용하시려면 로그인해주세요.</h4>
            <br />
            <div>
                <p>
                    사용자명&nbsp;
                    <asp:TextBox ID="tbUserName" runat="server"></asp:TextBox>
                    &nbsp;<asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnMove" runat="server" Text="이동하기" OnClientClick="window.open('https://localhost:44335/myTickets/Index')" Visible="False" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </p>
                <p>
                    암&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 호&nbsp;
                    <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
                    &nbsp;
                </p>
                <p>
                    <asp:Label ID="lblCong" runat="server"></asp:Label>
                </p>
                <br />
            </div>
        </div>  
                
    </form>
</body>
</html>
