using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.Write("It is post back response <br>");
            }
            else
            {
                Response.Write("Page Loaded for the first time <br>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("button clicked <br>");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Text Changed <br>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page Init" + "<br>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Page Init Complete" + "<br>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("Page Pre Load" + "<br>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write("Page Load Complete" + "<br>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page Pre Render" + "<br>");
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Page Pre Render Complete" + "<br>");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            //Response.Write("Page Unload" + "<br>");
        }
    }
}