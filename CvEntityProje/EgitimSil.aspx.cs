using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class EgitimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var egitim = db.TBLEGITIM.Find(x);
            db.TBLEGITIM.Remove(egitim);
            db.SaveChanges();
            Response.Redirect("Egitim.aspx");
        }
    }
}