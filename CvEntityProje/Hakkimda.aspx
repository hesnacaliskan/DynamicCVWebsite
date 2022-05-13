<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Hakkimda.aspx.cs" Inherits="CvEntityProje.Hakkimda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>Ad Soyad</th>
            <th>Unvan</th>
            <th>Hakkımda</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("Adsoyad") %></td>
                    <td><%# Eval("Unvan") %></td>
                    <td><%# Eval("Hakkimda") %></td>      
                    <td><asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl=<%# "HakkimdaSil.aspx?ID=" + Eval("ID") %>>Sil</asp:HyperLink></td>
                    <td><asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-success" NavigateUrl=<%# "HakkimdaGuncelle.aspx?ID=" + Eval("ID") %>>Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>    
    <a href="YeniHakkimda.aspx" class="btn btn-primary" style="margin-left:20px">Hakkımda Ekle </a>
</asp:Content>
