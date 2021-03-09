using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int N = 444;
            bool a = false;

            if (N % 4 == 0) {
                a = true;

                if (N % 100 == 0) {
                    if (N % 400 == 0) {
                        a = true;
                    } 
                    else{
                        a = false;
                    }
                } 
            }

           if (a == true) { 
            Response.Write("Y");
            }
            else{
                Response.Write("N");
            }
        }
    }
}