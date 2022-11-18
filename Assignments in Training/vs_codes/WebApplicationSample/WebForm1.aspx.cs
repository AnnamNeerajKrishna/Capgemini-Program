using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationSample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnDisplay_Click(object sender, EventArgs e)
        {
            string unName = TextBox1.Text;
            LbMsg.Text = "Welcome"+unName;
            
        }
    }
}