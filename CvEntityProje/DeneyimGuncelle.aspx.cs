using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class DeneyimGuncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var deneyim = db.TBLDENEYIM.Find(id);
                TextBox1.Text = deneyim.Deneyim;
                TextBox2.Text = deneyim.Deneyimayrinti;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var deneyim = db.TBLDENEYIM.Find(id);
            deneyim.Deneyim = TextBox1.Text;
            deneyim.Deneyimayrinti = TextBox2.Text;
            db.SaveChanges();
            Response.Redirect("Deneyimler.aspx");
        }
    }
}