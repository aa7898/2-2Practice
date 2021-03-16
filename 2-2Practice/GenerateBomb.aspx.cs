using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class GenerateBomb : System.Web.UI.Page{
        void mt_GetRowCol(ref int r, ref int c, int bomb)
        {
            r = bomb / 10;
            c = bomb % 10;
        }
        protected void Page_Load(object sender, EventArgs e){
            Response.Write("題目：踩地雷生成");
            int[] bomb = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            int r =0,c = 0;
            int[,] map = new int[10, 10];
            Response.Write("<table border= 4>");
            for (int i = 0; i < bomb.Length; i++) {                
                mt_GetRowCol(ref r, ref c, bomb[i]);
                map[r, c] = -1;                
            }
            for (int i = 0; i < 10; i++)
            {
                Response.Write("<tr>");
                for (int j = 0; j < 10; j++)
                {
                    Response.Write("<td>"+ map[i, j]+"</td>");
                }
                Response.Write("</tr>");
                Response.Write("<br / >");
            }
            Response.Write("</table>");
        }
    }
    
}