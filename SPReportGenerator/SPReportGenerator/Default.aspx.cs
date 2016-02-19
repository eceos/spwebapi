using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Client;

namespace SPReportGenerator
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Username : mca.developer@eceos.com
            //Password : Dafo4806
            using (var site = new SPSite("https://eceos2.sharepoint.com/sites/mca-dev"))
            {
                MessageBox.Show(site.Url);
            }
        }
    }
}