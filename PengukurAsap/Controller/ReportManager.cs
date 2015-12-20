using PengukurAsap.Boundary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PengukurAsap
{
    class ReportManager
    {
        List<Report> reports;
        private UI_Report uI_Report;

        public ReportManager(UI_Report uI_Report)
        {
            this.uI_Report = uI_Report;
        }

        public ReportManager()
        {
        }


        internal void LoadAllData()
        {

            reports = I_FileManager.LoadAllReport();
            uI_Report.ClearPanel();
            uI_Report.AddHeader();
            uI_Report.ShowAllData(reports);
        }

        public void SaveReport(Report report)
        {
            I_FileManager.SaveReport(report);
        }

        internal void LoadReport(DateTime dateTime)
        {
            uI_Report.ClearPanel();
            reports = I_FileManager.LoadAllReport();
            foreach (var item in reports)
            {
                if (item.dateTime.Equals(dateTime))
                {
                    uI_Report.ClearPanel();
                    uI_Report.ShowReport(item);
                    break;
                }

            }
        }

        public void DownloadReport(Report report)
        {
            string message;

            if (I_FileManager.Download(report))
                message = "Success!";
            else
                message = "Failed!";
            uI_Report.ShowNotification(message);
        }
    }
}
