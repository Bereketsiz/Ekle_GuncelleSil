<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Giris.aspx.cs" Inherits="Giris" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 351px">
        <tr>
            <td style="width: 231px" >Kullanıcı Adı&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</td>
            <td style="width: 363px" >
                <asp:TextBox ID="txtKullaniciAdi" runat="server" Width="150px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 231px" >Şifre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</td>
            <td style="width: 363px" >
                <asp:TextBox ID="txtSifre" runat="server" Width="150px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 231px" >&nbsp;</td>
            <td style="width: 363px" >
                <asp:Button ID="btnGirisYap" runat="server" OnClick="btnGirisYap_Click" Text="Giriş Yap" />
            </td>
        </tr>
    </table>
</asp:Content>

