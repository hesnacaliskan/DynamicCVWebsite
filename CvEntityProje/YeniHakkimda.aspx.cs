using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YeniHakkimda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLHAKKIMDA hakkimda = new TBLHAKKIMDA();
            hakkimda.Adsoyad = TextBox1.Text;
            hakkimda.Unvan = TextBox2.Text;
            hakkimda.Hakkimda = TextBox3.Text;
            db.TBLHAKKIMDA.Add(hakkimda);
            db.SaveChanges();
            Response.Redirect("Hakkimda.aspx");

        }
    }
}