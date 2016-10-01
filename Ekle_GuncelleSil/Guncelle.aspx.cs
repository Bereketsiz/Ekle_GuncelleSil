using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Guncelle1 : System.Web.UI.Page
{
    //Vt Bağlantısını Yaptığımız class
    Fonksiyon system = new Fonksiyon();

    //Global değişkenler
    string islem = "";
    string YazarId = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        //Master sayfamıza başlık bilgisi gönderdik
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Üye Güncelle<br/><br/>" + Session["KullaniciAdi"].ToString();

        //QueryString den YazarId ve islem değişkenini aldık.
        //Böylece hangi yazara hangi işlemi yapacağımızı anlayacağı. Mesela Güncelle veya Sil
        islem = Request.QueryString["islem"];
        YazarId = Request.QueryString["YazarId"];

        //İşlem Güncelle ise ve Sessionde varsa yetki var demektir.
        //Ozaman Güncelleme işlemi yaılacak bilgiyi ekrana basabailiriz.
        if (islem=="Guncelle" && Session["KullaniciAdi"]!=null)
        {
            DataRow dr = system.GetDataRow("Select * From Yazarlar where YazarId=" + YazarId);

            if (dr!=null)
            {
                if (Page.IsPostBack==false)
                {
                    txtKullaniciAdi.Text = dr["AdSoyad"].ToString();
                    txtSifre.Text = dr["Sifre"].ToString(); 
                }
            }
            else
            {
                lblUyari.Text = "Kayıt Okunamadı";
            }
        }

    }
    //Güncelleme işlemi bu butona tıklanınca gerçekleşiyor
    protected void btnGuncelle_Click(object sender, EventArgs e)
    {
        //Bilgilerin gösterildiği alanlar boş değilse aşağıda update işlemi gerçekleştiriliyor.
        if (txtKullaniciAdi.Text!="" && txtSifre.Text!="")
        {
            SqlConnection baglanti = system.baglan();
            SqlCommand cmdGuncelle = new SqlCommand("Update Yazarlar set AdSoyad=@AdSoyad,Sifre=@Sifre Where YazarId=" + YazarId, baglanti);
            cmdGuncelle.Parameters.Add("AdSoyad", txtKullaniciAdi.Text);
            cmdGuncelle.Parameters.Add("Sifre", txtSifre.Text);
            cmdGuncelle.ExecuteNonQuery();
            cmdGuncelle.Dispose();
            baglanti.Close();

            //İşlem bitti yönetim sayfasına yönlendirdik
            Response.Redirect("Yonetim.aspx");
        }    
    }

}