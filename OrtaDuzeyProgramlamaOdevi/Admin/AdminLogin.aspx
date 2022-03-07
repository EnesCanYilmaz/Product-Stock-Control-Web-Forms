<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/User.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="OrtaDuzeyProgramlamaOdevi.Admin.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../User/css/loginstyles.css" type="text/css" media="all" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="wrapper fadeInDown" runat="server">
        <div id="formContent">
            <asp:TextBox ID="TextBox1" runat="server" placeholder="kullanıcı adınız"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="şifreniz" TextMode="password"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="giriş yap" OnClick="Button1_Click" />
        </div>
        <br />
        <div>
            <h6>
                Kullanıcı adı = Admin
                Şifre = 123456
            </h6>
        </div>
    </div>
</asp:Content>
