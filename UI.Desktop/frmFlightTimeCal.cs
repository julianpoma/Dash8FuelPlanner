using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class.Fuel;

namespace UI.Desktop
{
    public partial class frmFlightTimeCal : Form
    {
        private int _tripTime;
        public int TripTime
        {
            get { return _tripTime; }
            set { _tripTime = value; }
        }

        private string _error;
        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }
        public frmFlightTimeCal(string lang, string error)
        {
            InitializeComponent();

            if(lang=="ES")
            {
                lblDistance.Text = "Distancia de vuelo";
                lblWindDirection.Text = "Direccion del viento";
                lblWindSpeed.Text = "Velocidad del viento";
                lblTimeComp.Text = "Compensacion";
                btnAceptar.Text = "Aceptar";
                lnkEditTAS.Text = "Editar TAS";
            }

            this.Error=error;
            this.LoadForm();
        }

        private void LoadForm ()
        {
            this.CleanForm();
            txtTAS.Text = "330";
            txtTAS.Enabled = false;
            numWindDirection.Maximum = 360;
        }

        private void CleanForm()
        {
            txtDistance.Text = "0";
            txtWindSpeed.Text = "0";
            txtTimeComp.Text = "0";
        }

        private void lnkEditTAS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtTAS.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Q400_Fuel_lbs calc = new Q400_Fuel_lbs();
                TripTime = Convert.ToInt32(
                    calc.CalcTripTime(
                    Convert.ToInt32(txtDistance.Text),
                    Convert.ToInt32(numWindDirection.Value),
                    Convert.ToInt32(txtWindSpeed.Text),
                    Convert.ToInt32(txtTimeComp.Text),
                    Convert.ToInt32(txtTAS.Text)));
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show(Error, "This shouldn't be happening", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
