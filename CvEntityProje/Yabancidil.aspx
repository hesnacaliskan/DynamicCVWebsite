<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yabancidil.aspx.cs" Inherits="CvEntityProje.Yabancidil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>            
            <th>Yabancı Diller</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("Yabancidil") %></td>      
                    <td><asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl=<%# "YabancidilSil.aspx?ID=" + Eval("ID") %>>Sil</asp:HyperLink></td>
                    <td><asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl=<%# "YabancidilGuncelle.aspx?ID=" + Eval("ID") %>>Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
     </table>
    <a href="YeniDil.aspx" class="btn btn-primary" style="margin-left:20px">Dil Ekle </a>
</asp:Content>
