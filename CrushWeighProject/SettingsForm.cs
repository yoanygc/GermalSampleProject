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
    public partial class SettingsForm : Form
    {
        Model1Container model1Context;
        List<SystemConfig> configs;

        public SettingsForm()
        {
            InitializeComponent();

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

            model1Context = new Model1Container();

            configs = model1Context.SystemConfigs.
                Where(config => config.Id >= 0).ToList();

            brandTextBox.Text = configs.
                Where(config => config.KeyName.Equals("IndicatorBrand")).First().Value;

            modelTextBox.Text = configs.
                Where(config => config.KeyName.Equals("IndicatorModel")).First().Value;

            iP_AddressTextBox.Text = configs.
                Where(config => config.KeyName.Equals("IndicatorIP")).First().Value;

            portTextBox.Text = configs.
                Where(config => config.KeyName.Equals("IndicatorPort")).First().Value;


        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

            configs.Where(config => config.KeyName.Equals("IndicatorBrand")).First().Value = brandTextBox.Text;

            configs.Where(config => config.KeyName.Equals("IndicatorModel")).First().Value = modelTextBox.Text;

            configs.Where(config => config.KeyName.Equals("IndicatorIP")).First().Value = iP_AddressTextBox.Text;

            configs.Where(config => config.KeyName.Equals("IndicatorPort")).First().Value = portTextBox.Text;

            model1Context.SaveChanges();
        }
    }
}
