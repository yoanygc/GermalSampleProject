namespace CrushWeighProject
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalTonsByCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllTicketsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_Views_DataSource = new CrushWeighProject.DB_Views_DataSource();
            this.TotalNetWeightByCustomersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectAllTicketsViewTableAdapter = new CrushWeighProject.DB_Views_DataSourceTableAdapters.SelectAllTicketsViewTableAdapter();
            this.db_Tables_DataSource = new CrushWeighProject.DB_Tables_DataSource();
            this.CustomersTableAdapter = new CrushWeighProject.DB_Tables_DataSourceTableAdapters.CustomersTableAdapter();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DriversTableAdapter = new CrushWeighProject.DB_Tables_DataSourceTableAdapters.DriversTableAdapter();
            this.DriversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalNetWeightByCustomersViewTableAdapter1 = new CrushWeighProject.DB_Views_DataSourceTableAdapters.TotalNetWeightByCustomersViewTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectAllTicketsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Views_DataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalNetWeightByCustomersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Tables_DataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriversBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PrintTicket";
            reportDataSource1.Value = this.SelectAllTicketsViewBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.Location = new System.Drawing.Point(0, 33);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer.Size = new System.Drawing.Size(1331, 615);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driversToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.ticketsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1331, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allDriversToolStripMenuItem});
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // allDriversToolStripMenuItem
            // 
            this.allDriversToolStripMenuItem.Name = "allDriversToolStripMenuItem";
            this.allDriversToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.allDriversToolStripMenuItem.Text = "All Drivers";
            this.allDriversToolStripMenuItem.Click += new System.EventHandler(this.allDriversToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allCustomersToolStripMenuItem,
            this.totalTonsByCustomersToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // allCustomersToolStripMenuItem
            // 
            this.allCustomersToolStripMenuItem.Name = "allCustomersToolStripMenuItem";
            this.allCustomersToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.allCustomersToolStripMenuItem.Text = "All Customers";
            this.allCustomersToolStripMenuItem.Click += new System.EventHandler(this.allCustomersToolStripMenuItem_Click);
            // 
            // totalTonsByCustomersToolStripMenuItem
            // 
            this.totalTonsByCustomersToolStripMenuItem.Name = "totalTonsByCustomersToolStripMenuItem";
            this.totalTonsByCustomersToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.totalTonsByCustomersToolStripMenuItem.Text = "Total Tons By Customers";
            this.totalTonsByCustomersToolStripMenuItem.Click += new System.EventHandler(this.totalTonsByCustomersToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deliveryNoteToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // deliveryNoteToolStripMenuItem
            // 
            this.deliveryNoteToolStripMenuItem.Name = "deliveryNoteToolStripMenuItem";
            this.deliveryNoteToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.deliveryNoteToolStripMenuItem.Text = "Delivery Note";
            this.deliveryNoteToolStripMenuItem.Click += new System.EventHandler(this.deliveryNoteToolStripMenuItem_Click);
            // 
            // SelectAllTicketsViewBindingSource
            // 
            this.SelectAllTicketsViewBindingSource.DataMember = "SelectAllTicketsView";
            this.SelectAllTicketsViewBindingSource.DataSource = this.db_Views_DataSource;
            // 
            // db_Views_DataSource
            // 
            this.db_Views_DataSource.DataSetName = "DB_Views_DataSource";
            this.db_Views_DataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TotalNetWeightByCustomersViewBindingSource
            // 
            this.TotalNetWeightByCustomersViewBindingSource.DataMember = "TotalNetWeightByCustomersView";
            this.TotalNetWeightByCustomersViewBindingSource.DataSource = this.db_Views_DataSource;
            // 
            // SelectAllTicketsViewTableAdapter
            // 
            this.SelectAllTicketsViewTableAdapter.ClearBeforeFill = true;
            // 
            // db_Tables_DataSource
            // 
            this.db_Tables_DataSource.DataSetName = "CrushWeighViewsDataSet";
            this.db_Tables_DataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomersTableAdapter
            // 
            this.CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DataMember = "Customers";
            this.CustomersBindingSource.DataSource = this.db_Tables_DataSource;
            // 
            // DriversTableAdapter
            // 
            this.DriversTableAdapter.ClearBeforeFill = true;
            // 
            // DriversBindingSource
            // 
            this.DriversBindingSource.DataMember = "Drivers";
            this.DriversBindingSource.DataSource = this.db_Tables_DataSource;
            // 
            // totalNetWeightByCustomersViewTableAdapter1
            // 
            this.totalNetWeightByCustomersViewTableAdapter1.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 648);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectAllTicketsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Views_DataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalNetWeightByCustomersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Tables_DataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriversBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DB_Tables_DataSource db_Tables_DataSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCustomersToolStripMenuItem;
        private DB_Tables_DataSourceTableAdapters.CustomersTableAdapter CustomersTableAdapter;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private DB_Tables_DataSourceTableAdapters.DriversTableAdapter DriversTableAdapter;
        private System.Windows.Forms.BindingSource DriversBindingSource;
        private System.Windows.Forms.ToolStripMenuItem totalTonsByCustomersToolStripMenuItem;
        private System.Windows.Forms.BindingSource TotalNetWeightByCustomersViewBindingSource;
        private DB_Views_DataSource db_Views_DataSource;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryNoteToolStripMenuItem;
        private System.Windows.Forms.BindingSource SelectAllTicketsViewBindingSource;
        private DB_Views_DataSourceTableAdapters.SelectAllTicketsViewTableAdapter SelectAllTicketsViewTableAdapter;
        private DB_Views_DataSourceTableAdapters.TotalNetWeightByCustomersViewTableAdapter totalNetWeightByCustomersViewTableAdapter1;
    }
}