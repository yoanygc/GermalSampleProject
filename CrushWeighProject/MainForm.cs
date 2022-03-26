using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrushWeighProject
{
    public partial class MainForm : Form
    {

        DriversManagementForm driversManagementForm;
        SettingsForm settingsForm;

        Model1Container model1Context = new Model1Container();
        Model2Entities model2Context = new Model2Entities();


        int selectedRowIndex;
        int selectedTicketId;

        private void applyFilters()
        {
            List<SelectAllTicketsView> ticketsByDate;
            List<SelectAllTicketsView> tickets;
            toDateTimePicker.Value = DateTime.Now;


            if (fromDateCheckBox.Checked)
            {
                ticketsByDate = model2Context.SelectAllTicketsViews.
                    Where(ticket =>
                        ticket.DateTimeIn.Value >= fromDateTimePicker.Value.Date &&
                        ticket.DateTimeIn.Value <= toDateTimePicker.Value)
                    .ToList();
            }
            else
            {
                ticketsByDate = model2Context.SelectAllTicketsViews.
                    Where(ticket => ticket.Id >= 0).ToList();
            }

            selectAllTicketsViewDataGridView.DataSource = ticketsByDate;


            if (categoryCheckBox.Checked)
            {

                switch (filterByComboBox.SelectedIndex)
                {

                    case 1:
                        tickets = ticketsByDate.
                            Where(ticket => ticket.Material == equalToComboBox.Text).ToList();
                        break;

                    case 2:
                        tickets = ticketsByDate.
                            Where(ticket => ticket.PlateNumber == equalToComboBox.Text).ToList();
                        break;

                    case 3:
                        tickets = ticketsByDate.
                            Where(ticket => ticket.TicketStatus == equalToComboBox.Text).ToList();
                        break;
                    case 4:
                        tickets = ticketsByDate.
                            Where(ticket => ticket.CustomerName == equalToComboBox.Text).ToList();
                        break;

                    case 5:
                        tickets = model2Context.SelectAllTicketsViews.
                            Where(ticket => ticket.CustomerName == equalToComboBox.Text).ToList();
                        break;

                    default:
                        tickets = model2Context.SelectAllTicketsViews.
                            Where(ticket => ticket.Id >= 0).ToList();
                        break;

                }
                selectAllTicketsViewDataGridView.DataSource = tickets;
            }
            selectAllTicketsViewDataGridView.ClearSelection();
        }

        public MainForm()
        {
            InitializeComponent();
            driversManagementForm = new DriversManagementForm();
            settingsForm = new SettingsForm();
        }

        private void trucksButton_Click(object sender, EventArgs e)
        {
            filterByComboBox.SelectedIndex = 0;
        }

        private void driversButton_Click(object sender, EventArgs e)
        {

            driversManagementForm.ShowDialog();
            //tableAdapterManager.UpdateAll(this.db_Tables_DataSource);
            filterByComboBox.SelectedIndex = 0;

        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dB_Views_DataSource.SelectAllTicketsView' table. You can move, or remove it, as needed.
            //this.selectAllTicketsViewTableAdapter.Fill(this.dB_Views_DataSource.SelectAllTicketsView);

            updateAllComponents();




            if (filterByComboBox.Items.Count > 0)
            {
                filterByComboBox.SelectedIndex = 0;
            }

        }

        private void updateAllComponents()
        {

            // Prepare and connect Indicator through ModbusTCP/IP

            if (model1Context.SystemConfigs.Count() != 0)
            {
                //brandTextBox.Text = model1Context.SystemConfigs.
                //    Where(config => config.KeyName.Equals("IndicatorBrand")).First().Value;

                //modelTextBox.Text = model1Context.SystemConfigs.
                //    Where(config => config.KeyName.Equals("IndicatorModel")).First().Value;

                //companyNameLabel.Text = model1Context.SystemConfigs.
                //    Where(config => config.KeyName.Equals("companyName")).First().Value;

                //companyAddressLabel.Text = model1Context.SystemConfigs.
                //    Where(config => config.KeyName.Equals("companyAddress")).First().Value;

                //companyEmailLabel.Text = model1Context.SystemConfigs.
                //    Where(config => config.KeyName.Equals("companyEmail1")).First().Value;

                //companyPhoneLabel.Text = model1Context.SystemConfigs.
                //    Where(config => config.KeyName.Equals("companyPhone1")).First().Value;

            }

            // Update DateTimePickers with current time
            fromDateTimePicker.Value = DateTime.Today.Date;
            toDateTimePicker.Value = DateTime.Now;

            // Update Tickets in DataGrid from Database
            List<SelectAllTicketsView> tickets;
            tickets = model2Context.SelectAllTicketsViews.
                Where(ticket =>
                    ticket.DateTimeIn.Value >= fromDateTimePicker.Value.Date &&
                    ticket.DateTimeIn.Value <= toDateTimePicker.Value)
                .ToList();
            selectAllTicketsViewDataGridView.DataSource = tickets;
            selectAllTicketsViewDataGridView.ClearSelection();

        }

        private void filterByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<SelectAllTicketsView> tickets;

            equalToComboBox.Items.Clear();

            switch (filterByComboBox.SelectedIndex)
            {
                case 0:
                    equalToComboBox.Text = "None";
                    tickets = model2Context.SelectAllTicketsViews.
                        Where(ticket => ticket.Id >= 0).ToList();
                    break;

                case 1:
                    List<Material> materials = model1Context.Materials.
                        Where(material => material.Id >= 0).ToList();

                    foreach (var material in materials)
                    {
                        equalToComboBox.Items.Add(material.Name);
                    }
                    equalToComboBox.Text = "-- Select --";
                    break;

                case 2:
                    List<Truck> trucks = model1Context.Trucks.
                        Where(truck => truck.Id >= 0).ToList();

                    foreach (var truck in trucks)
                    {
                        equalToComboBox.Items.Add(truck.PlateNumber);
                    }
                    equalToComboBox.Text = "-- Select --";
                    break;

                case 3:
                    List<TicketStatus> ticketStatuses = model1Context.TicketStatus.
                        Where(ticketStatus => ticketStatus.Id >= 0).ToList();

                    foreach (var ticketStatus in ticketStatuses)
                    {
                        equalToComboBox.Items.Add(ticketStatus.Status);
                    }
                    equalToComboBox.Text = "-- Select --";
                    break;

                case 4:
                    List<Customer> customers = model1Context.Customers.
                        Where(customer => customer.Id >= 0).ToList();

                    foreach (var customer in customers)
                    {
                        equalToComboBox.Items.Add(customer.Name);
                    }
                    equalToComboBox.Text = "-- Select --";
                    break;

                default:
                    break;

            }

        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {
            applyFilters();

        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            filterByComboBox.SelectedIndex = 0;

            fromDateTimePicker.ResetText();
            toDateTimePicker.ResetText();
            fromDateCheckBox.Checked = false;
            categoryCheckBox.Checked = false;

        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            filterByComboBox.SelectedIndex = 0;

        }

        private void selectAllTicketsViewDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                selectedTicketId = (int)selectAllTicketsViewDataGridView[0, e.RowIndex].Value;
            }


        }



        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }

        private void materialsButton_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fromDateTimePicker.Enabled = fromDateCheckBox.Checked;
            toDateTimePicker.Enabled = fromDateCheckBox.Checked;
        }

        private void categoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filterByComboBox.Enabled = categoryCheckBox.Checked;
            equalToComboBox.Enabled = categoryCheckBox.Checked;

        }


        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            //if (addNewTicketManagementForm.ShowDialog() == DialogResult.OK)
            //{
            //    //List<SelectAllTicketsView> tickets = model2Context.SelectAllTicketsViews.
            //    //    Where(ticket => ticket.Id >= 0).ToList();
            //    //selectAllTicketsViewDataGridView.DataSource = tickets;

            //    applyFilters();

            //};
        }



        private void nowButton_Click(object sender, EventArgs e)
        {
            toDateTimePicker.Value = DateTime.Now;
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            //if (selectedRowIndex >= 0)
            //{
            //    EditTicketForm editTicketForm = new EditTicketForm(selectedTicketId);
            //    if (editTicketForm.ShowDialog() == DialogResult.OK)
            //    {
            //        applyFilters();
            //    }

            //}
        }

        private void selectAllTicketsViewDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editToolStripButton_Click(sender, e);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(selectedTicketId);
            reportForm.Show();
        }


    }
}
