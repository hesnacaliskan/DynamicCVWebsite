using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class EgitimGuncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var egitim = db.TBLEGITIM.Find(id);
                TextBox1.Text = egitim.Egitimokul;
                TextBox2.Text = egitim.Egitimayrinti;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var egitim = db.TBLEGITIM.Find(id);
            egitim.Egitimokul = TextBox1.Text;
            egitim.Egitimayrinti = TextBox2.Text;
            db.SaveChanges();
            Response.Redirect("Egitim.aspx");
        }
    }
}