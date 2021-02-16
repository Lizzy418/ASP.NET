<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Join.aspx.cs" Inherits="WebApp2.Join" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>My Ticket - Login</title>
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
            <h2>Join</h2>
            <h4>My Ticket 이용을 위한 회원가입 페이지입니다.</h4>
            <h4>회원가입 정보를 입력해주세요.</h4>
            <br />
            <div class="col-md-4">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; I&nbsp; D :
                <asp:TextBox ID="tbID" runat="server"></asp:TextBox>&nbsp;
                <asp:Button ID="btnID" runat="server" OnClick="btnID_Click" Text="중복 확인" />&nbsp;
                <asp:Label ID="lblIDcheck" runat="server" Font-Italic="False" Font-Size="Small" ForeColor="#CC0000"></asp:Label>
                &nbsp;<br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 이&nbsp; 름 :
                <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 암&nbsp; 호 :
                <asp:TextBox ID="tbPWD" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                암 호 확 인 :
                <asp:TextBox ID="tbPWD2" runat="server" TextMode="Password"></asp:TextBox>&nbsp;
                <asp:Label ID="lblPWDcheck" runat="server" Font-Italic="False" Font-Size="Small" ForeColor="#CC0000"></asp:Label>
                <br />
                <br />
                전 화 번 호 :
                <asp:TextBox ID="tbPhone" runat="server"></asp:TextBox>
                &nbsp;<asp:Label ID="lblPhoneCheck" runat="server" Font-Italic="False" Font-Size="Small" ForeColor="Black">숫자만 입력해주세요. 예)01012345678</asp:Label>&nbsp;
                <asp:Label ID="lblPhoneCheck2" runat="server" Font-Italic="False" Font-Size="Small" ForeColor="#CC0000"></asp:Label>
                <br />
                <br />
                메 일 주 소 :
                <asp:TextBox ID="tbMail" runat="server" TextMode="Email"></asp:TextBox>
&nbsp;<asp:Label ID="lblMailcheck" runat="server" Font-Italic="False" Font-Size="Small" ForeColor="Black">@를 포함하여 입력해주세요. 예)abc@example.com</asp:Label>
                <br />
                <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnJoin" runat="server" OnClick="btnJoin_Click" Text="완료" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="초기화" />
                <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblJoin" runat="server" Font-Size="Small"></asp:Label>    
                </div>
        </div>
    </form>
</body>
</html>
