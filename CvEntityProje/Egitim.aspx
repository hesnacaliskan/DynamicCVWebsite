<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Egitim.aspx.cs" Inherits="CvEntityProje.Egitim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>            
            <th>Eğitim</th>
            <th>Eğitim Ayrıntıları</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("Egitimokul") %></td>      
                    <td><%# Eval("Egitimayrinti") %></td>      
                    <td><asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl=<%# "EgitimSil.aspx?ID=" + Eval("ID") %>>Sil</asp:HyperLink></td>
                    <td><asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl=<%# "EgitimGuncelle.aspx?ID=" + Eval("ID") %>>Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
     </table>
    <a href="YeniEgitim.aspx" class="btn btn-primary" style="margin-left:20px">Eğitim Ekle </a>
</asp:Content>
