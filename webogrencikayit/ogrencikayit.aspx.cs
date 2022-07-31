using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webogrencikayit
{
    public partial class ogrencikayit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ogrenciTableAdapter dt = new DataSet1TableAdapters.ogrenciTableAdapter();
            dt.ogrenciekle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            TextBox1.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = " ";
            TextBox4.Text = " ";
        }
    }
}