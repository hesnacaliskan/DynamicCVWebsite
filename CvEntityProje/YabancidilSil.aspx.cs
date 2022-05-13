using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YabancidilSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var ydil = db.TBLDIL.Find(x);
            db.TBLDIL.Remove(ydil);
            db.SaveChanges();
            Response.Redirect("Yabancidil.aspx");
        }
    }
}