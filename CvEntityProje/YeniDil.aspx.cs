using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YeniDil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLDIL ydil = new TBLDIL();
            ydil.Yabancidil = TextBox1.Text;
            db.TBLDIL.Add(ydil);
            db.SaveChanges();
            Response.Redirect("Yabancidil.aspx");
        }
    }
}