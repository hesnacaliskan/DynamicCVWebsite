using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class SertifikaGuncelle : System.Web.UI.Page
    {

        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var sertifika = db.TBLSERTIFIKA.Find(id);
                TextBox1.Text = sertifika.Sertifika;
                TextBox2.Text = sertifika.Sertifikaayrinti;
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var sertifika = db.TBLSERTIFIKA.Find(id);
            sertifika.Sertifika = TextBox1.Text;
            sertifika.Sertifikaayrinti = TextBox2.Text;
            db.SaveChanges();
            Response.Redirect("Sertifika.aspx");
        }
    }
}