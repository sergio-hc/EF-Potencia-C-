using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int bas = Convert.ToInt32(TextBox1.Text);
        int pot = Convert.ToInt32(TextBox2.Text);
        int res = 1;
        ClassLibrary1.Class1 c = new ClassLibrary1.Class1();
        res = c.potencia(bas, pot);
        TextBox3.Text = res.ToString();
    }
}