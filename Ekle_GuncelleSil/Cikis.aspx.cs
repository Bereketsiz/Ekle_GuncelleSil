using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cikis : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Master sayfamıza başlık bilgisi gönderdik
        Label lbl1 = (Label)Master.FindControl("lblSayfaBaslik");
        lbl1.Text = "Çıkış Sayfası";

        //Sessionu null yaparak serbest bırakıyoruz. Artık giriş yapmadan Yönetim Sayfasına giremeyiz.
        Session["KullaniciAdi"] = null;
        Response.Redirect("Default.aspx");
    }
}