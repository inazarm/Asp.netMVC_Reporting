using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using reportingApp.Models;

namespace reportingApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getReport();
            }
        }

        private void getReport()
        {
            using (TestDBEntities db=new TestDBEntities())
            {
                var list = (from n in db.sp_getBookNPublisher() select n);

                ReportDataSource rd = new ReportDataSource("DataSet1",list);
            }
        }
    }
}