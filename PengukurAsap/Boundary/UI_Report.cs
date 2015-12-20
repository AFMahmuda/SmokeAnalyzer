using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using PengukurAsap.Boundary;
using PengukurAsap.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PengukurAsap
{
    public partial class UI_Report : Form
    {


        public void ClearPanel()
        {
            List<Control> listControls = reportPanel.Controls.Cast<Control>().ToList();
            foreach (var item in listControls)
            {
                reportPanel.Controls.Remove(item);
                item.Dispose();
            }
            reportPanel.FlowDirection = FlowDirection.LeftToRight;

        }

        public void AddHeader()
        {
            Label newLabel = new Label();
            newLabel.Text = "time";
            newLabel.Width = reportPanel.Width / 5;
            reportPanel.Controls.Add(newLabel);

            newLabel = new Label();
            newLabel.Text = "class";
            newLabel.Width = reportPanel.Width / 5;
            reportPanel.Controls.Add(newLabel);

            newLabel = new Label();
            newLabel.Text = "action";
            newLabel.Width = reportPanel.Width / 2;
            reportPanel.Controls.Add(newLabel);
        }


        public void ShowNotification(string message)
        {
            MessageBox.Show(message, "Download");
        }

        public void ShowAllData(List<Report> reports)
        {
            foreach (var item in reports)
            {
                AddReportToPanel(item);
            }
        }


        void AddReportToPanel(Report report)
        {
            Label newLabel = new Label();
            newLabel.Text = report.dateTime.ToString();
            newLabel.Size = new Size(reportPanel.Width / 5, 40);
            newLabel.TextAlign = ContentAlignment.MiddleLeft;
            reportPanel.Controls.Add(newLabel);

            newLabel = new Label();
            newLabel.Text = report.Type.ToString();
            newLabel.Size = new Size(reportPanel.Width / 5, 40);
            newLabel.TextAlign = ContentAlignment.MiddleLeft;
            reportPanel.Controls.Add(newLabel);

            FlowLayoutPanel newPanel = new FlowLayoutPanel();
            newPanel.Size = new Size(reportPanel.Width / 2, 40);
            newPanel.FlowDirection = FlowDirection.LeftToRight;

            Button newButton = new Button();
            newButton.Text = "detail";
            newButton.Click += (s, e) =>
            {
                ReportManager.LoadReport(report.dateTime);
                backButton.Visible = true;
            };
            newButton.ImageAlign = ContentAlignment.MiddleLeft;
            newButton.Size = new Size(newPanel.Width * 4 / 10, 30);

            newPanel.Controls.Add(newButton);

            newButton = new Button();
            newButton.Text = "download";
            newButton.Click += (s, e) => { ReportManager.DownloadReport(report); };
            newButton.ImageAlign = ContentAlignment.MiddleLeft;
            newButton.Size = new Size(newPanel.Width * 2 / 5, 30);

            newPanel.Controls.Add(newButton);
            reportPanel.Controls.Add(newPanel);
        }

        public UI_Report()
        {
            InitializeComponent();
            ReportManager = new ReportManager(this);
            ClearPanel();
            reportPanel.HorizontalScroll.Enabled = false;
            reportPanel.HorizontalScroll.Visible = false;

            ReportManager.LoadAllData();
            backButton.Visible = false;

        }

        internal void ShowReport(Report report)
        {
            reportPanel.FlowDirection = FlowDirection.TopDown;
            Label newLabel = new Label();
            newLabel.Text = "Taken :" + report.dateTime;
            newLabel.Text += "\nAverage type :" + report.Type;
            newLabel.Text += "\nNumber of Images :" + report.Smokes.Count;
            newLabel.Size = new Size(reportPanel.Width * 8 / 10, 60);
            reportPanel.Controls.Add(newLabel);

            int counter = 1;
            foreach (var item in report.Smokes)
            {
                ImageBox imageBox = new ImageBox();
                imageBox.Image = new Image<Gray, byte>(item.Bitmap);
                imageBox.Size = item.Bitmap.Size;
                imageBox.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
                reportPanel.Controls.Add(imageBox);

                newLabel = new Label();
                newLabel.Text = "image " + counter++
                    + "  type : " + item.Type;
                reportPanel.Controls.Add(newLabel);
            }
        }


        ReportManager ReportManager;

        private void backButton_Click(object sender, EventArgs e)
        {
            backButton.Visible = false;
            ReportManager.LoadAllData();
        }
    }
}
