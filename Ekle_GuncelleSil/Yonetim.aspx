<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Yonetim.aspx.cs" Inherits="Yonetim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black">
        <AlternatingItemStyle BackColor="PaleGoldenrod" />
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <ItemTemplate>
            <table>
                <tr>
                    <td>
                        <table>
                            <tr>
                                <td>Kullanıcı Adı</td>
                                <td>
                                    <label id="lblAdSoyad"><%#Eval("AdSoyad") %></label>
                                </td>
                            </tr>
                            <tr>
                                <td>Şifresi</td>
                                <td>
                                    <label id="lblSifre"><%#Eval("Sifre") %></label>
                                </td>
                                <td><a href="Guncelle1.aspx?islem=Guncelle&YazarId=<%#Eval("YazarId") %>">Güncelle</a></td>
                                <td><a href="Yonetim.aspx?islem=Sil&YazarId=<%#Eval("YazarId") %>">Sil</a></td>
                                <td></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
    </asp:DataList>
</asp:Content>

