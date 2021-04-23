using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class ReverseInt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
            int N = 1234;

            string Y;

            char[] ArrayN = N.ToString().ToCharArray();
            
            Array.Reverse(ArrayN);
            
            Y = new string(ArrayN);
           
            Label1.Text = N + "----->" + Y;
            

        }
    }
}