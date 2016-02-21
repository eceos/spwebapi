using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Microsoft.SharePoint.Client;
using SP = Microsoft.SharePoint.Client;
using System.Security;

namespace SPReportGenerator
{
    public partial class ShowListTasks : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Web site = context.Web;
            //List announcementsList = context.Web.Lists.GetByTitle("Tasks");
            //SP.FieldCollection fieldColl = announcementsList.Fields;
            //context.Load(announcementsList.Fields);
            //context.ExecuteQuery();

            ////to get to know the field / column name
            //foreach (Field f in announcementsList.Fields)
            //{
            //    System.Web.UI.WebControls.TextBox tb = new System.Web.UI.WebControls.TextBox();
            //    tb.ID = f.InternalName;
            //    tb.Text = f.InternalName;
            //    tb.Width = 300;
            //    pnl.Controls.Add(tb);
            //    pnl.Controls.Add(new LiteralControl("<br />"));
            //    //Console.WriteLine("{0} - {1} - {2} - {3}", f.Title, f.InternalName, f.Hidden, f.CanBeDeleted);
            //} 
        }

        protected void listTasks_Click(object sender, EventArgs e)
        {
            Response.Redirect("DefaultListTasks.aspx");
        }
    }
}