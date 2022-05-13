using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Default : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBLHAKKIMDA.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.TBLHAKKIMDA.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.TBLHAKKIMDA.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.TBLEGITIM.ToList();
            Repeater4.DataBind();
            Repeater5.DataSource = db.TBLYETENEK.ToList();
            Repeater5.DataBind();            
            Repeater6.DataSource = db.TBLDENEYIM.ToList();
            Repeater6.DataBind();
            Repeater7.DataSource = db.TBLSERTIFIKA.ToList();
            Repeater7.DataBind();            
            Repeater8.DataSource = db.TBLDIL.ToList();
            Repeater8.DataBind();
            



        }             

        protected void Button1_Click1(object sender, EventArgs e)
        {
            TBLILETIŞIM mesaj = new TBLILETIŞIM();
            mesaj.Ad = TextBox1.Text;
            mesaj.Soyad = TextBox2.Text;
            mesaj.Email = TextBox3.Text;
            mesaj.Konu = TextBox4.Text;
            mesaj.Mesaj = TextBox5.Text;
            db.TBLILETIŞIM.Add(mesaj);
            db.SaveChanges();
            TextBox1.Text = String.Empty;
            TextBox2.Text = String.Empty;
            TextBox3.Text = String.Empty;
            TextBox4.Text = String.Empty;
            TextBox5.Text = String.Empty;
            Response.Redirect(Request.Url.AbsoluteUri);

        }
    }
}