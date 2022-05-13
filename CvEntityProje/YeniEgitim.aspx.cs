using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YeniEgitim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVENTITYEntities db = new DBCVENTITYEntities();

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLEGITIM egitim = new TBLEGITIM();
            egitim.Egitimokul = TextBox1.Text;
            egitim.Egitimayrinti = TextBox2.Text;
            db.TBLEGITIM.Add(egitim);
            db.SaveChanges();
            Response.Redirect("Egitim.aspx");
        }
    }
}