using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase09Tp4Dai5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Session["nombreSession"] = TextBox1.Text;
            Response.Redirect(Request.RawUrl);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie1 = new HttpCookie("fecha",Label1.Text) ;
            cookie1.Expires = DateTime.Now.AddSeconds(5);
            Response.Cookies.Add(cookie1);
            Response.Redirect(Request.RawUrl);
        }
    }
}