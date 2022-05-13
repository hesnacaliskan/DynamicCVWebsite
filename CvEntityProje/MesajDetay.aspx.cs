using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.TBLILETIŞIM.Find(x);
            TextAd.Text = mesaj.Ad;
            TextSoyad.Text = mesaj.Soyad;
            TextMail.Text = mesaj.Email;
            TextKonu.Text = mesaj.Konu;
            TextMesaj.Text = mesaj.Mesaj;           

        }
    }
}