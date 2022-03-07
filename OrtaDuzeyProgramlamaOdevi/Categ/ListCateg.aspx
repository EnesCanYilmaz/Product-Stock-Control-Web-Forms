<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Site2.Master" AutoEventWireup="true" CodeBehind="ListCateg.aspx.cs" Inherits="OrtaDuzeyProgramlamaOdevi.Categ.ListCateg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
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
