using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Yonetim : System.Web.UI.Page
{
    //Vt Bağlantısını Yaptığımız class
    Fonksiyon system = new Fonksiyon();
    //Global değişkenler
    string YazarId = "";
    string islem = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //Master sayfamıza başlık bilgisi gönderdik
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Üye Yönetimi";
        //QueryString den YazarId ve islem değişkenini aldık.
        //Böylece hangi yazara hangi işlemi yapacağımızı anlayacağı. Mesela Güncelle veya Sil
        YazarId = Request.QueryString["YazarId"];
        islem = Request.QueryString["islem"];

        //Session yoksa yetkide yoktur. Ozaman Girişe
        if (Session["KullaniciAdi"]==null)
        {
            Response.Redirect("Giris.aspx"); 
        }
            //Session varsa zaten aşağıda veriler listeleniyor ve işlem durumuna göre
        //sil ise silme işlemi yapılıyor
        else
        {  
            DataTable dt = system.GetDataTable("select YazarId,AdSoyad,Sifre from Yazarlar");
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }

        if (islem=="Sil")
        {
            system.cmd("Delete From Yazarlar Where YazarId="+YazarId);
            Response.Redirect("Yonetim.aspx");
        }
    }
    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {

    }
}