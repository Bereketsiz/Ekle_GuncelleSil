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
    Fonksiyon system = new Fonksiyon();
    string islem = "";
    string YazarId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Üye Güncelle";

        islem = Request.QueryString["islem"];
        YazarId = Request.QueryString["YazarId"];

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
    protected void btnGuncelle_Click(object sender, EventArgs e)
    {
        if (txtKullaniciAdi.Text!="" && txtSifre.Text!="")
        {
            SqlConnection baglanti = system.baglan();
            SqlCommand cmd = new SqlCommand("Update Yazarlar set AdSoyad=@AdSoyad,Sifre=@Sifre Where YazarId=" + YazarId, baglanti);
            cmd.Parameters.Add("AdSoyad", txtKullaniciAdi.Text);
            cmd.Parameters.Add("Sifre", txtSifre.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglanti.Close();
            Response.Redirect("Yonetim.aspx");
        }    
    }

}