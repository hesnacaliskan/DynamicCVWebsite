using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class DeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var deneyim = db.TBLDENEYIM.Find(x);
            db.TBLDENEYIM.Remove(deneyim);
            db.SaveChanges();
            Response.Redirect("Deneyimler.aspx");
        }
    }
}