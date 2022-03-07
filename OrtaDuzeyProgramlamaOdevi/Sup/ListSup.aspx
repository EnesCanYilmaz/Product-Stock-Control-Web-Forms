<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/Site2.Master" AutoEventWireup="true" CodeBehind="ListSup.aspx.cs" Inherits="OrtaDuzeyProgramlamaOdevi.Sup.ListSup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
      <h1 class="page-header">Tedarikçiler
    </h1>

    <asp:ListView ID="SupplierListView" runat="server">
        <LayoutTemplate>
            <div class="table-responsive">
                <table class="table table-striped table-sm">
                    <thead>
                        <tr>
                            <th scope="col">Şirket Adı</th>
                            <th scope="col">İletişim</th>
                            <th scope="col">Şehir</th>
                            <th scope="col">Telefon</th>
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
                    <%#Eval("CompanyName")%> 
                </td>
                <td>
                    <%#Eval("ContactName")%>
                </td>
                <td>
                    <%#Eval("City")%>
                </td>
                <td>
                    <%#Eval("Phone")%>
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
