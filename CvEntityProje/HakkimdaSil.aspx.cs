using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class HakkimdaSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db = new DBCVENTITYEntities();
            int x = Convert.ToInt32(Request.QueryString["ID"]);
            var hakkimda = db.TBLHAKKIMDA.Find(x);
            db.TBLHAKKIMDA.Remove(hakkimda);
            db.SaveChanges();
            Response.Redirect("Hakkimda.aspx");
        }
    }
}