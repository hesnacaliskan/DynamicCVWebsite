using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class SertifikaSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var sertifika = db.TBLSERTIFIKA.Find(x);
            db.TBLSERTIFIKA.Remove(sertifika);
            db.SaveChanges();
            Response.Redirect("Sertifika.aspx");
        }
    }
}