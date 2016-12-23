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
    public partial class frmQ400 : Form
    {
        #region Propierties
        private Q400_Fuel_lbs _mjcQ400_lbs;
        private Q400_Fuel_kgs _mjcQ400_kgs;
        private string _lang;
        private string _error;
        private string _cruiseError;

        public string CruiseError
        {
            get { return _cruiseError; }
            set { _cruiseError = value; }
        }

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public string Lang
        {
            get { return _lang; }
            set { _lang = value; }
        }
        public Q400_Fuel_lbs MjcQ400_lbs
        {
            get { return _mjcQ400_lbs; }
            set { _mjcQ400_lbs = value; }
        }
        public Q400_Fuel_kgs MjcQ400_kgs
        {
            get { return _mjcQ400_kgs; }
            set { _mjcQ400_kgs = value; }
        }
        #endregion

        public frmQ400()
        {
            InitializeComponent();
            this.LoadForm();
        }

        private void LoadForm ()
        {
            this.CleanForm();
            cmbUnits.Items.Add("Imperial");
            cmbUnits.Items.Add("Metric");
            cmbUnits.SelectedIndex = 0;
            this.Error = "Please check that every field contains *integer* numbers only.";

            foreach (int altitude in this.LoadAltitudes())
            {
                cmbAltitude.Items.Add(altitude);
            }
            cmbAltitude.SelectedIndex = 10;
            this.CruiseError = "Please be aware that, based on our calculations, you won't be able to climb to " + cmbAltitude.Text + "ft. in time.";

        }
        private List<int> LoadAltitudes()
        {
            List<int> _altitudes = new List<int>();

            for (int i = 15000; i <= 25000; i = i + 1000)
            {
                _altitudes.Add(i);
            }

            return _altitudes;
        }

        private void CleanForm ()
        {
            txtAlternate.Text = "0";
            txtExtra.Text = "30";
            txtFlight.Text = "0";
            txtTaxi.Text = "0";
            lblTOCant.Text = "0";
            lblTripCant.Text = "0";
            lblTotalCant.Text = "0";
            txtFinalReserve.Text = "0";
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            if (cmbUnits.SelectedIndex == 0)
            {
                try
                {
                    MjcQ400_lbs = new Q400_Fuel_lbs();

                    MjcQ400_lbs.CalculateAll_lbs(Convert.ToInt32(cmbAltitude.Text),
                        Convert.ToInt32(txtFlight.Text),
                        Convert.ToDouble(txtTaxi.Text),
                        Convert.ToDouble(txtExtra.Text),
                        Convert.ToDouble(txtAlternate.Text),
                        Convert.ToDouble(txtFinalReserve.Text));

                    lblTOCant.Text = Convert.ToString(Convert.ToInt32(MjcQ400_lbs.TOFuel));
                    lblTotalCant.Text = Convert.ToString(Convert.ToInt32(MjcQ400_lbs.TotalFuel));
                    lblTripCant.Text = Convert.ToString(Convert.ToInt32(MjcQ400_lbs.TripFuel));

                    if(MjcQ400_lbs.CruiseTime<3)
                    {
                        if(this.Lang=="ES")
                        {
                            this.CruiseError = "Por favor note que, basado en nuestros calculos, no podrá alcanzar la altitud de " + cmbAltitude.Text + "ft. deseada a tiempo.";
                        }
                        else
                        {
                            this.CruiseError = "Please be aware that, based on our calculations, you won't be able to climb to " + cmbAltitude.Text + "ft. in time.";
                        }

                        MessageBox.Show(CruiseError, "Watch out!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MjcQ400_lbs = null;
                }
                catch (Exception)
                {
                    MessageBox.Show(Error, "This shouldn't be happening", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if(cmbUnits.SelectedIndex == 1)
            {
                try
                {
                    MjcQ400_kgs = new Q400_Fuel_kgs();

                    MjcQ400_kgs.CalculateAll_kgs(Convert.ToInt32(cmbAltitude.Text),
                        Convert.ToInt32(txtFlight.Text),
                        Convert.ToDouble(txtTaxi.Text),
                        Convert.ToDouble(txtExtra.Text),
                        Convert.ToDouble(txtAlternate.Text),
                        Convert.ToDouble(txtFinalReserve.Text));

                    lblTOCant.Text = Convert.ToString(Convert.ToInt32(MjcQ400_kgs.TOFuel));
                    lblTotalCant.Text = Convert.ToString(Convert.ToInt32(MjcQ400_kgs.TotalFuel));
                    lblTripCant.Text = Convert.ToString(Convert.ToInt32(MjcQ400_kgs.TripFuel));

                    if (MjcQ400_kgs.CruiseTime < 3)
                    {
                        if (this.Lang == "ES")
                        {
                            this.CruiseError = "Por favor note que, basado en nuestros calculos, no podrá alcanzar la altitud de " + cmbAltitude.Text + "ft. deseada a tiempo.";
                        }
                        else
                        {
                            this.CruiseError = "Please be aware that, based on our calculations, you won't be able to climb to " + cmbAltitude.Text + "ft. in time.";
                        }

                        MessageBox.Show(CruiseError, "Watch out!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MjcQ400_kgs = null;
                }
                catch (Exception)
                {
                    MessageBox.Show(Error, "This shouldn't be happening", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cmbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbUnits.SelectedIndex==0)
            {
                lblUnitTOFuel.Text = "lbs.";
                lblUnitTripFuel.Text = "lbs.";
                lblUnitFinal.Text = "lbs.";
                lblUnitTotalFuel.Text = "lbs.";
                lblTotalCant.Text = "0";
                lblTripCant.Text = "0";
                lblTOCant.Text = "0";
                txtFinalReserve.Text = "0";

            }

            if(cmbUnits.SelectedIndex==1)
            {
                lblUnitTOFuel.Text = "kgs.";
                lblUnitTripFuel.Text = "kgs.";
                lblUnitFinal.Text = "kgs.";
                lblUnitTotalFuel.Text = "kgs.";
                lblTotalCant.Text = "0";
                lblTripCant.Text = "0";
                lblTOCant.Text = "0";
                txtFinalReserve.Text = "0";
            }
        }

        private void lnkCalTrip_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFlightTimeCal frmFTC = new frmFlightTimeCal(this.Lang,this.Error);
            frmFTC.ShowDialog();
            txtFlight.Text = frmFTC.TripTime.ToString();

        }
        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Lang = "ES";
            this.Error = "Por favor verifica que cada campo contenga sólo números *enteros*.";
            lblUnits.Text = "Tipo de unidades";
            lblAltitude.Text = "Altitud de crucero";
            lblTripTime.Text = "Tiempo total del vuelo";
            lnkCalTrip.Text = "¿Cómo lo calculo?";
            lblTaxi.Text = "Tiempo de rodaje";
            lblAlternate.Text = "Dist. alternativo";
            lblExtra.Text = "Comb. contingencia";
            lblFinalReserve.Text = "Reserva final";
            btnCalculate.Text = "Calcular";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Lang = "EN";
            this.Error = "Please check that every field contains *integer* numbers only.";
            lblUnits.Text = "Select unit system";
            lblAltitude.Text = "Select cruise altitude";
            lblTripTime.Text = "Total flight time";
            lnkCalTrip.Text = "I don't know it";
            lblTaxi.Text = "Taxi time";
            lblAlternate.Text = "Alternate airport";
            lblExtra.Text = "Contingency fuel";
            lblFinalReserve.Text = "Final reserve";
            btnCalculate.Text = "Calculate";
        }

        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string about = "Created by Neucoas.\n\n" +
                "Please read the document included with the app.\n\n"+
                "I hope you guys of the /r/flightsim community enjoy it.\n\n" +
                "Special thanks to everyone who contribuited to this project.\n\n" +
                "\"I found a bug!\"\nIf you have any questions or suggestions to improve the app, you can find me on reddit.com/u/neucoas.\n\n" +
                "Current version: v1.0.";
                
            MessageBox.Show(about,"About the app.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
