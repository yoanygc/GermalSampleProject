namespace CrushWeighProject
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.driversButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.selectAllTicketsViewDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeqNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectAllTicketsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Views_DataSource = new CrushWeighProject.DB_Views_DataSource();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nowButton = new System.Windows.Forms.Button();
            this.categoryCheckBox = new System.Windows.Forms.CheckBox();
            this.fromDateCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.filterByComboBox = new System.Windows.Forms.ComboBox();
            this.equalToComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.modbusTCPIndicatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectAllTicketsViewTableAdapter = new CrushWeighProject.DB_Views_DataSourceTableAdapters.SelectAllTicketsViewTableAdapter();
            this.materialsTableAdapter = new CrushWeighProject.DB_Tables_DataSourceTableAdapters.MaterialsTableAdapter();
            this.tableAdapterManager = new CrushWeighProject.DB_Tables_DataSourceTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllTicketsViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllTicketsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Views_DataSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusTCPIndicatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(1684, 788);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.settingsButton);
            this.panel2.Controls.Add(this.reportsButton);
            this.panel2.Controls.Add(this.driversButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(173, 788);
            this.panel2.TabIndex = 2;
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(24, 469);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(128, 72);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.Location = new System.Drawing.Point(23, 391);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(128, 72);
            this.reportsButton.TabIndex = 4;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // driversButton
            // 
            this.driversButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.driversButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversButton.Location = new System.Drawing.Point(22, 22);
            this.driversButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.driversButton.Name = "driversButton";
            this.driversButton.Size = new System.Drawing.Size(128, 72);
            this.driversButton.TabIndex = 2;
            this.driversButton.Text = "Drivers";
            this.driversButton.UseVisualStyleBackColor = true;
            this.driversButton.Click += new System.EventHandler(this.driversButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.selectAllTicketsViewDataGridView);
            this.panel4.Controls.Add(this.statusStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 225);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8);
            this.panel4.Size = new System.Drawing.Size(1507, 563);
            this.panel4.TabIndex = 5;
            // 
            // selectAllTicketsViewDataGridView
            // 
            this.selectAllTicketsViewDataGridView.AllowUserToAddRows = false;
            this.selectAllTicketsViewDataGridView.AllowUserToDeleteRows = false;
            this.selectAllTicketsViewDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            this.selectAllTicketsViewDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.selectAllTicketsViewDataGridView.AutoGenerateColumns = false;
            this.selectAllTicketsViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.selectAllTicketsViewDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.selectAllTicketsViewDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectAllTicketsViewDataGridView.CausesValidation = false;
            this.selectAllTicketsViewDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selectAllTicketsViewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.selectAllTicketsViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectAllTicketsViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.SeqNumber,
            this.dateTimeInDataGridViewTextBoxColumn,
            this.dateTimeOutDataGridViewTextBoxColumn,
            this.plateNumberDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.ticketStatusDataGridViewTextBoxColumn});
            this.selectAllTicketsViewDataGridView.DataSource = this.selectAllTicketsViewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.selectAllTicketsViewDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.selectAllTicketsViewDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectAllTicketsViewDataGridView.Location = new System.Drawing.Point(8, 8);
            this.selectAllTicketsViewDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.selectAllTicketsViewDataGridView.MultiSelect = false;
            this.selectAllTicketsViewDataGridView.Name = "selectAllTicketsViewDataGridView";
            this.selectAllTicketsViewDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.selectAllTicketsViewDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.selectAllTicketsViewDataGridView.RowTemplate.Height = 28;
            this.selectAllTicketsViewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectAllTicketsViewDataGridView.Size = new System.Drawing.Size(1491, 517);
            this.selectAllTicketsViewDataGridView.TabIndex = 3;
            this.selectAllTicketsViewDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectAllTicketsViewDataGridView_CellClick);
            this.selectAllTicketsViewDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectAllTicketsViewDataGridView_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 69;
            // 
            // SeqNumber
            // 
            this.SeqNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SeqNumber.DataPropertyName = "SeqNumber";
            this.SeqNumber.HeaderText = "SeqNumber";
            this.SeqNumber.Name = "SeqNumber";
            this.SeqNumber.ReadOnly = true;
            this.SeqNumber.Width = 140;
            // 
            // dateTimeInDataGridViewTextBoxColumn
            // 
            this.dateTimeInDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dateTimeInDataGridViewTextBoxColumn.DataPropertyName = "DateTimeIn";
            this.dateTimeInDataGridViewTextBoxColumn.HeaderText = "DateTimeIn";
            this.dateTimeInDataGridViewTextBoxColumn.Name = "dateTimeInDataGridViewTextBoxColumn";
            this.dateTimeInDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeInDataGridViewTextBoxColumn.Width = 138;
            // 
            // dateTimeOutDataGridViewTextBoxColumn
            // 
            this.dateTimeOutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dateTimeOutDataGridViewTextBoxColumn.DataPropertyName = "DateTimeOut";
            this.dateTimeOutDataGridViewTextBoxColumn.HeaderText = "DateTimeOut";
            this.dateTimeOutDataGridViewTextBoxColumn.Name = "dateTimeOutDataGridViewTextBoxColumn";
            this.dateTimeOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeOutDataGridViewTextBoxColumn.Width = 150;
            // 
            // plateNumberDataGridViewTextBoxColumn
            // 
            this.plateNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.plateNumberDataGridViewTextBoxColumn.DataPropertyName = "PlateNumber";
            this.plateNumberDataGridViewTextBoxColumn.HeaderText = "PlateNumber";
            this.plateNumberDataGridViewTextBoxColumn.Name = "plateNumberDataGridViewTextBoxColumn";
            this.plateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.plateNumberDataGridViewTextBoxColumn.Width = 147;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialDataGridViewTextBoxColumn.Width = 111;
            // 
            // ticketStatusDataGridViewTextBoxColumn
            // 
            this.ticketStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ticketStatusDataGridViewTextBoxColumn.DataPropertyName = "TicketStatus";
            this.ticketStatusDataGridViewTextBoxColumn.HeaderText = "TicketStatus";
            this.ticketStatusDataGridViewTextBoxColumn.Name = "ticketStatusDataGridViewTextBoxColumn";
            this.ticketStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketStatusDataGridViewTextBoxColumn.Width = 144;
            // 
            // selectAllTicketsViewBindingSource
            // 
            this.selectAllTicketsViewBindingSource.DataMember = "SelectAllTicketsView";
            this.selectAllTicketsViewBindingSource.DataSource = this.dB_Views_DataSource;
            // 
            // dB_Views_DataSource
            // 
            this.dB_Views_DataSource.DataSetName = "DB_Views_DataSource";
            this.dB_Views_DataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(8, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1491, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(139, 25);
            this.toolStripStatusLabel1.Text = "Indicator Status:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(119, 25);
            this.toolStripStatusLabel2.Text = "Disconnected";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(76, 25);
            this.toolStripStatusLabel3.Text = "        IP: ";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(64, 25);
            this.toolStripStatusLabel4.Text = "0.0.0.0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(1507, 225);
            this.panel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nowButton);
            this.groupBox1.Controls.Add(this.categoryCheckBox);
            this.groupBox1.Controls.Add(this.fromDateCheckBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.toDateTimePicker);
            this.groupBox1.Controls.Add(this.clearFilterButton);
            this.groupBox1.Controls.Add(this.fromDateTimePicker);
            this.groupBox1.Controls.Add(this.applyFilterButton);
            this.groupBox1.Controls.Add(this.filterByComboBox);
            this.groupBox1.Controls.Add(this.equalToComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(10, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1487, 128);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            // 
            // nowButton
            // 
            this.nowButton.Location = new System.Drawing.Point(429, 80);
            this.nowButton.Margin = new System.Windows.Forms.Padding(4);
            this.nowButton.Name = "nowButton";
            this.nowButton.Size = new System.Drawing.Size(64, 32);
            this.nowButton.TabIndex = 32;
            this.nowButton.Text = "Now";
            this.nowButton.UseVisualStyleBackColor = true;
            this.nowButton.Click += new System.EventHandler(this.nowButton_Click);
            // 
            // categoryCheckBox
            // 
            this.categoryCheckBox.AutoSize = true;
            this.categoryCheckBox.Location = new System.Drawing.Point(518, 32);
            this.categoryCheckBox.Name = "categoryCheckBox";
            this.categoryCheckBox.Size = new System.Drawing.Size(103, 24);
            this.categoryCheckBox.TabIndex = 31;
            this.categoryCheckBox.Text = "Category:";
            this.categoryCheckBox.UseVisualStyleBackColor = true;
            this.categoryCheckBox.CheckedChanged += new System.EventHandler(this.categoryCheckBox_CheckedChanged);
            // 
            // fromDateCheckBox
            // 
            this.fromDateCheckBox.AutoSize = true;
            this.fromDateCheckBox.Checked = true;
            this.fromDateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fromDateCheckBox.Location = new System.Drawing.Point(26, 32);
            this.fromDateCheckBox.Name = "fromDateCheckBox";
            this.fromDateCheckBox.Size = new System.Drawing.Size(76, 24);
            this.fromDateCheckBox.TabIndex = 30;
            this.fromDateCheckBox.Text = "From:";
            this.fromDateCheckBox.UseVisualStyleBackColor = true;
            this.fromDateCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "To:";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(106, 80);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(313, 26);
            this.toDateTimePicker.TabIndex = 28;
            this.toDateTimePicker.Value = new System.DateTime(2021, 12, 15, 0, 0, 0, 0);
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Location = new System.Drawing.Point(963, 32);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(92, 80);
            this.clearFilterButton.TabIndex = 24;
            this.clearFilterButton.Text = "Clear";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(106, 32);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(313, 26);
            this.fromDateTimePicker.TabIndex = 29;
            this.fromDateTimePicker.Value = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Location = new System.Drawing.Point(864, 32);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(92, 80);
            this.applyFilterButton.TabIndex = 25;
            this.applyFilterButton.Text = "Apply";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.applyFilterButton_Click);
            // 
            // filterByComboBox
            // 
            this.filterByComboBox.Enabled = false;
            this.filterByComboBox.FormattingEnabled = true;
            this.filterByComboBox.Items.AddRange(new object[] {
            "None",
            "Materials",
            "Trucks",
            "Ticket Status",
            "Customers"});
            this.filterByComboBox.Location = new System.Drawing.Point(632, 30);
            this.filterByComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterByComboBox.Name = "filterByComboBox";
            this.filterByComboBox.Size = new System.Drawing.Size(200, 28);
            this.filterByComboBox.TabIndex = 20;
            this.filterByComboBox.SelectedIndexChanged += new System.EventHandler(this.filterByComboBox_SelectedIndexChanged);
            // 
            // equalToComboBox
            // 
            this.equalToComboBox.Enabled = false;
            this.equalToComboBox.FormattingEnabled = true;
            this.equalToComboBox.Location = new System.Drawing.Point(632, 80);
            this.equalToComboBox.Name = "equalToComboBox";
            this.equalToComboBox.Size = new System.Drawing.Size(200, 28);
            this.equalToComboBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Equal to:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.editToolStripButton,
            this.printToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(10, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1487, 63);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(50, 50);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButton_Click);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(46, 50);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.Click += new System.EventHandler(this.editToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(52, 50);
            this.printToolStripButton.Text = "Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // modbusTCPIndicatorsBindingSource
            // 
            this.modbusTCPIndicatorsBindingSource.DataMember = "ModbusTCPIndicators";
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "SelectAllTicketsView";
            this.materialsBindingSource.DataSource = this.dB_Views_DataSource;
            // 
            // selectAllTicketsViewTableAdapter
            // 
            this.selectAllTicketsViewTableAdapter.ClearBeforeFill = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.DriversTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = this.materialsTableAdapter;
            this.tableAdapterManager.PricesTableAdapter = null;
            this.tableAdapterManager.SystemConfigsTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.TicketStatusTableAdapter = null;
            this.tableAdapterManager.TrucksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CrushWeighProject.DB_Tables_DataSourceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1684, 788);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crush & Weigh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllTicketsViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllTicketsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Views_DataSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modbusTCPIndicatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DB_Tables_DataSource db_Tables_DataSource; 
        private System.Windows.Forms.BindingSource selectAllTicketsViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView selectAllTicketsViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private DB_Tables_DataSourceTableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button driversButton;
        private DB_Views_DataSource dB_Views_DataSource;
        private DB_Views_DataSourceTableAdapters.SelectAllTicketsViewTableAdapter selectAllTicketsViewTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.BindingSource modbusTCPIndicatorsBindingSource;
        private DB_Tables_DataSourceTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Button clearFilterButton;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.ComboBox filterByComboBox;
        private System.Windows.Forms.ComboBox equalToComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox categoryCheckBox;
        private System.Windows.Forms.CheckBox fromDateCheckBox;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.Button nowButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeqNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketStatusDataGridViewTextBoxColumn;
    }
}

