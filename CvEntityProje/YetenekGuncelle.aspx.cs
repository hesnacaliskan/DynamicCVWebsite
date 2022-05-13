using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if(Page.IsPostBack == false)
            {
                var yetenek = db.TBLYETENEK.Find(id);
                TextBox1.Text = yetenek.Yetenek;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var yetenek = db.TBLYETENEK.Find(id);
            yetenek.Yetenek = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yetenekler.aspx");
        }
    }
}