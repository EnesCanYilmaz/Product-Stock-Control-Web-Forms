<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Admin.Master" AutoEventWireup="true" CodeBehind="ProductAdmin.aspx.cs" Inherits="OrtaDuzeyProgramlamaOdevi.Admin.ProductAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../User/css/loginstyles.css" type="text/css" media="all" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="wrapper fadeInDown" runat="server">
        <div id="formContent">
            <asp:TextBox ID="TextBox1" runat="server" placeholder="ürün adı"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="ürün fiyatı"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" placeholder="ürün stok miktarı"></asp:TextBox>
        </div>
            <asp:Button ID="Button1" runat="server" Text="ürün ekle" OnClick="Button1_Click" />
    </div>
</asp:Content>

