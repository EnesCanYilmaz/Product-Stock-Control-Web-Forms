<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Admin.Master" AutoEventWireup="true" CodeBehind="ListCategoryAdmin.aspx.cs" Inherits="OrtaDuzeyProgramlamaOdevi.Admin.ListCategoryAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../User/css/loginstyles.css" type="text/css" media="all" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <header class="navbar navbar-dark sticky-top bg-dark flex-md-nowrap p-0 shadow">
        <a class="navbar-brand col-md-3 col-lg-2 me-0 px-3" href="/Home.aspx">ECY</a>
        <button class="navbar-toggler position-absolute d-md-none collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#sidebarMenu" aria-controls="sidebarMenu" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control form-control-dark w-100" type="text" placeholder="Search" aria-label="Search">

        </asp:TextBox>
    </header>
    <h1 class="page-header">Kategoriler
    </h1>

    <asp:ListView ID="CategoryListView" runat="server">
        <LayoutTemplate>
            <div class="table-responsive">
                <table class="table table-striped table-sm">
                    <thead>
                        <tr>
                            <th scope="col">Kategori Adı</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </tbody>
                </table>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <tr id="Tr1" runat="server">
                <td>
                    <%#Eval("CategoryName")%>
                </td>
            </tr>
        </ItemTemplate>

    </asp:ListView>
</asp:Content>
