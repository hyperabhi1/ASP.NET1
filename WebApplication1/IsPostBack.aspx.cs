using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class IsPostBack : System.Web.UI.Page
    {
        public void LoadCityDropDownList()
        {
            ListItem l1 = new ListItem("Noida1");
            DropDownList1.Items.Add(l1);
            ListItem l2 = new ListItem("Noida2");
            DropDownList1.Items.Add(l2);
            ListItem l3 = new ListItem("Noida3");
            DropDownList1.Items.Add(l3);
            ListItem l4 = new ListItem("Noida4");
            DropDownList1.Items.Add(l4);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //DropDownList1.Items.Clear();
            
            //if(!IsPostBack)
                LoadCityDropDownList();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("Selected Index changed<br>");
        }
    }
}