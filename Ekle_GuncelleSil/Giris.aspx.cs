using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Giris : System.Web.UI.Page
{
    //Vt Bağlantısını Yaptığımız class
    Fonksiyon system = new Fonksiyon();
    protected void Page_Load(object sender, EventArgs e)
    {
        //Master sayfamıza başlık bilgisi gönderdik
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Üye Giriş";
    }

    protected void btnGirisYap_Click(object sender, EventArgs e)
    {
        //Bağlantıyı yaptık
        SqlConnection baglanti = system.baglan();
        //Commandımızı oluşturduk
        SqlCommand cmdGirisYap = new SqlCommand("Select * from Yazarlar Where KullaniciAdi=@Kullaniciadi and Sifre=@Sifre", baglanti);
        //Atamaları yaptı
        cmdGirisYap.Parameters.Add("KullaniciAdi", txtKullaniciAdi.Text);
        cmdGirisYap.Parameters.Add("Sifre", txtSifre.Text);
        //Veritabanından adsoyad ve Sifreyi karşılaştırdık veriyi okuduk
        SqlDataReader veriyiOku = cmdGirisYap.ExecuteReader();
        //Eğer kullanıcı varsa
        if (veriyiOku.Read())
        {
            //Bu kullanıcıya bir session uluşturduk ve yetkiyi aldık
            Session["KullaniciAdi"] = veriyiOku["AdSoyad"];
            //Artık yönetim sayfasına girdik
            Response.Redirect("Yonetim.aspx");
        }
        else
        {
            //Yetkimiz yoksa buraya
            Response.Redirect("Giris.aspx");

        }
    }
}