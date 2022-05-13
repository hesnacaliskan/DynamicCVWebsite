using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLYETENEK yetenek = new TBLYETENEK();
            yetenek.Yetenek = TextBox1.Text;
            db.TBLYETENEK.Add(yetenek);
            db.SaveChanges();
            Response.Redirect("Yetenekler.aspx");
        }
    }
}