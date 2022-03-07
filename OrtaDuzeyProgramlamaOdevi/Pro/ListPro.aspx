<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Site2.Master" AutoEventWireup="true" CodeBehind="ListPro.aspx.cs" Inherits="OrtaDuzeyProgramlamaOdevi.Pro.ListPro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
      <h1 class="page-header">Ürünler
    </h1>

    <asp:ListView ID="ProductListView" runat="server">
        <LayoutTemplate>
            <div class="table-responsive">
                <table class="table table-striped table-sm">
                    <thead>
                        <tr>
                            <th scope="col">Ürün Adı</th>
                            <th scope="col">Fiyatı</th>
                            <th scope="col">Stok Adedi</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </tbody>
                </table>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <tr id="ItemPlaceHolder" runat="server">
                <td>
                    <%#Eval("ProductName")%> 
                </td>
                <td>
                    <%#Eval("UnitPrice")%>
                </td>
                <td>
                    <%#Eval("UnitsInStock")%>
                </td>
            </tr>
        </ItemTemplate>
        </asp:ListView>
</asp:Content>
