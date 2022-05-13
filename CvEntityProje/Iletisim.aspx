<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="CvEntityProje.Iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>            
            <th>Ad</th>
            <th>Soyad</th>
            <th>Email</th>
            <th>Konu</th>            
            <th>Mesajı Gör</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("ID") %></td>
                    <td><%# Eval("Ad") %></td>      
                    <td><%# Eval("Soyad") %></td>      
                    <td><%# Eval("Email") %></td>      
                    <td><%# Eval("Konu") %></td>      
                    <td><asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-warning" NavigateUrl=<%# "MesajDetay.aspx?ID=" + Eval("ID") %>>Mesajı Gör</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
     </table>

</asp:Content>
