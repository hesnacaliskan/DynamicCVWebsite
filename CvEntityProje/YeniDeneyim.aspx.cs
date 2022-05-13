using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YeniDeneyim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLDENEYIM deneyim = new TBLDENEYIM();
            deneyim.Deneyim = TextBox1.Text;
            deneyim.Deneyimayrinti = TextBox2.Text;
            db.TBLDENEYIM.Add(deneyim);
            db.SaveChanges();
            Response.Redirect("Deneyimler.aspx");
        }
    }
}