using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Report;
using PSDProject.Repository;
using PSDProject.Model;

namespace PSDProject.Views
{
    public partial class ShowReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //report transaksi user
            // list dari transaksi user yang sedang login
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;

            int userid = (int) Session["ID"];
            DataSet1 data = loadData(
                TransactionRepository.GetAllTrHeader(userid));
            report.SetDataSource(data);
        }

        public DataSet1 loadData(List<TrHeader> transactions)
        {
            DataSet1 newData = new DataSet1();
            var headerTable = newData.TrHeader;
            var detailTable = newData.TrDetail;
            foreach (TrHeader header in transactions)
            {
                var newHeaderRow = headerTable.NewRow();
                newHeaderRow["Id"] = header.Id;
                newHeaderRow["UserId"] = header.UserId;
                newHeaderRow["TransactionDate"] = header.TransactionDate;
                headerTable.Rows.Add(newHeaderRow);

                foreach (TrDetail detail in header.TrDetails)
                {
                    var newDetailRow = detailTable.NewRow();
                    newDetailRow["TrHeaderId"] = detail.TrHeaderId;
                    newDetailRow["ItemId"] = detail.ItemID;
                    newDetailRow["Quantity"] = detail.Quantity;
                    detailTable.Rows.Add(newDetailRow);
                }
            }

            return newData;
        }
    }

    
}