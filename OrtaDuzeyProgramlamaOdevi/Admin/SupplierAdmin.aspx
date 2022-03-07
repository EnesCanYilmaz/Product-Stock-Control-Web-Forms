<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Admin.Master" AutoEventWireup="true" CodeBehind="SupplierAdmin.aspx.cs" Inherits="OrtaDuzeyProgramlamaOdevi.Admin.SupplierAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../User/css/loginstyles.css" type="text/css" media="all" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="wrapper fadeInDown" runat="server">
        <div id="formContent">
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Şirket Adı"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="İletişim adı"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" placeholder="Adres"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" placeholder="Telefon"></asp:TextBox>
            
        </div>
        <asp:Button ID="Button1" runat="server" Text="ürün ekle" OnClick="Button1_Click" />
    </div>
</asp:Content>
