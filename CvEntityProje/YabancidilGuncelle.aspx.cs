using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YabancidilGuncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                var ydil = db.TBLDIL.Find(id);
                TextBox1.Text = ydil.Yabancidil;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["ID"]);
            var ydil = db.TBLDIL.Find(id);
            ydil.Yabancidil = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yabancidil.aspx");
        }
    }
}