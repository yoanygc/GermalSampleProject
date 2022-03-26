using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CrushWeighProject
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            this.SelectAllTicketsViewTableAdapter.Fill(this.db_Views_DataSource.SelectAllTicketsView);
            configureReport();

        }

        public ReportForm(int ticketId)
        {

            InitializeComponent();
            configureReport();
            this.SelectAllTicketsViewTableAdapter.FillByTicketId(this.db_Views_DataSource.SelectAllTicketsView, ticketId);

            ReportDataSource printTicketDataSet = new ReportDataSource("PrintTicketDataSet", SelectAllTicketsViewBindingSource);
            ReportDataSource dataSet1 = new ReportDataSource("DataSet1", SelectAllTicketsViewBindingSource);

            reportViewer.LocalReport.DataSources.Add(printTicketDataSet);
            reportViewer.LocalReport.DataSources.Add(dataSet1);

            reportViewer.Clear();
            reportViewer.ProcessingMode = ProcessingMode.Local;

            reportViewer.LocalReport.ReportEmbeddedResource = "CrushWeighProject.PrintDeliveryNote.rdlc";
            reportViewer.LocalReport.ReportPath = "../../Reports/PrintDeliveryNote.rdlc";
            reportViewer.RefreshReport();
            reportViewer.Visible = true;

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {


        }

        private void configureReport()
        {
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.Visible = false;

        }
        private void allDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReportDataSource driversReportDataSource = new ReportDataSource("DriversDataSet", DriversBindingSource);
            reportViewer.LocalReport.DataSources.Add(driversReportDataSource);

            // TODO: This line of code loads data into the 'CrushWeighDBDataSet.Drivers' table. You can move, or remove it, as needed.
            this.DriversTableAdapter.FillWithoutSelect(this.db_Tables_DataSource.Drivers);

            reportViewer.Clear();
            reportViewer.ProcessingMode = ProcessingMode.Local;

            reportViewer.LocalReport.ReportEmbeddedResource = "CrushWeighProject.DriversReport.rdlc";
            reportViewer.LocalReport.ReportPath = "../../Reports/DriversReport.rdlc";

            reportViewer.RefreshReport();
            reportViewer.Visible = true;

        }

        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReportDataSource customersReportDataSource = new ReportDataSource("CustomersDataSet", CustomersBindingSource);
            reportViewer.LocalReport.DataSources.Add(customersReportDataSource);

            // TODO: This line of code loads data into the 'CrushWeighDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.CustomersTableAdapter.FillWithoutSelect(this.db_Tables_DataSource.Customers);

            reportViewer.Clear();
            reportViewer.ProcessingMode = ProcessingMode.Local;

            reportViewer.LocalReport.ReportEmbeddedResource = "CrushWeighProject.CustomersReport.rdlc";
            reportViewer.LocalReport.ReportPath = "../../Reports/CustomersReport.rdlc";
            reportViewer.RefreshReport();
            reportViewer.Visible = true;

        }

        private void totalTonsByCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReportDataSource totalGrossReportDataSource = new ReportDataSource("TotalTonsByCustomers", TotalNetWeightByCustomersViewBindingSource);
            reportViewer.LocalReport.DataSources.Add(totalGrossReportDataSource);

            this.totalNetWeightByCustomersViewTableAdapter1.Fill(this.db_Views_DataSource.TotalNetWeightByCustomersView);

            Model2Entities context = new Model2Entities();

            reportViewer.Clear();
            reportViewer.ProcessingMode = ProcessingMode.Local;

            reportViewer.LocalReport.ReportEmbeddedResource = "CrushWeighProject.TotalTonsByCustomers.rdlc";
            reportViewer.LocalReport.ReportPath = "../../Reports/TotalTonsByCustomers.rdlc";
            reportViewer.RefreshReport();
            reportViewer.Visible = true;



        }

        private void deliveryNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
