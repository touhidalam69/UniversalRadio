using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RadioProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            try
            {
                InitializeComponent();

                ListRadio objListRadio = new ListRadio();
                List<RadioChannel> lst = objListRadio.GetAllCountry();
                lst.Insert(0, new RadioChannel { Country = "Select...", Name = "Select...", Url = "" });
                cmbCountry.DataSource = lst;
                cmbCountry.DisplayMember = "Country";
                cmbCountry.ValueMember = "Country";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListRadio objListRadio = new ListRadio(cmbCountry.SelectedValue.ToString());
                List<RadioChannel> lst = objListRadio.GetCountryWiseRadio();
                lst.Insert(0, new RadioChannel { Country = "Select...", Name = "Select...", Url = "" });
                cmbChannel.DataSource = lst;
                cmbChannel.DisplayMember = "Name";
                cmbChannel.ValueMember = "Url";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void Play_Click(object sender, EventArgs e)
        {
            try
            {
                WindowsMediaPlayer1.URL = cmbChannel.SelectedValue.ToString();
                WindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
