using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YeniSertifika : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLSERTIFIKA sertifika = new TBLSERTIFIKA();
            sertifika.Sertifika = TextBox1.Text;
            sertifika.Sertifikaayrinti = TextBox2.Text;
            db.TBLSERTIFIKA.Add(sertifika);
            db.SaveChanges();
            Response.Redirect("Sertifika.aspx");
        }
    }
}