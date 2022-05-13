using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class HakkimdaGuncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var hakkimda = db.TBLHAKKIMDA.Find(id);
                TextBox1.Text = hakkimda.Adsoyad;
                TextBox2.Text = hakkimda.Unvan;
                TextBox3.Text = hakkimda.Hakkimda;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var hakkimda = db.TBLHAKKIMDA.Find(id);
            hakkimda.Adsoyad = TextBox1.Text;
            hakkimda.Unvan = TextBox2.Text;
            hakkimda.Hakkimda = TextBox3.Text;
            db.SaveChanges();
            Response.Redirect("Hakkimda.aspx");
        }
    }
}