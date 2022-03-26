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
    public partial class DriversManagementForm : Form
    {
        public DriversManagementForm()
        {
            InitializeComponent();
        }



        private void DriversManagementForm_Load(object sender, EventArgs e)
        {
            this.driversTableAdapter.FillWithoutSelect(this.dB_Tables_DataSource.Drivers);

        }

        private void driversBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.driversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_Tables_DataSource);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
