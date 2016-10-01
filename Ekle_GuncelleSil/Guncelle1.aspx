<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Guncelle1.aspx.cs" Inherits="Guncelle1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table width="300px">
        <tr>
            <td style="width: 272px">Kullanıcı Adı&nbsp;&nbsp; :</td>
            <td style="width: 304px">
                <asp:TextBox ID="txtKullaniciAdi" runat="server" Width="150px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 272px">Şifre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</td>
            <td style="width: 304px">
                <asp:TextBox ID="txtSifre" runat="server" Width="150px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 272px">
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </td>
            <td style="width: 304px">
                <asp:Button ID="btnGuncelle" runat="server" OnClick="btnGuncelle_Click" Text="Yazar Güncelle" />
                <asp:Label ID="lblUyari" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

