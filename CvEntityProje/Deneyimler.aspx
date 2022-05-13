<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Deneyimler.aspx.cs" Inherits="CvEntityProje.Deneyimler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>            
            <th>Deneyimler</th>
            <th>Deneyim Ayrıntıları</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("Deneyim") %></td>      
                    <td><%# Eval("Deneyimayrinti") %></td>      
                    <td><asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl=<%# "DeneyimSil.aspx?ID=" + Eval("ID") %>>Sil</asp:HyperLink></td>
                    <td><asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl=<%# "DeneyimGuncelle.aspx?ID=" + Eval("ID") %>>Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
     </table>
    <a href="YeniDeneyim.aspx" class="btn btn-primary" style="margin-left:20px">Deneyim Ekle </a>
</asp:Content>
