using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillTheBoat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int totalLoad = 0;
        int capacity = 239;
        int truckload = 0;
        int carload = 0;
        int mcload = 0;
        int traincarload = 0;
        int truckvalue = 11;
        int carvalue = 5;
        int mcvalue = 3;
        int traincarvalue = 17;

        private void sldMC_Scroll(object sender, ScrollEventArgs e)
        {
            lblMCCount.Text = sldMC.Value.ToString();
            calculate();
        }

        private void sldT_Scroll(object sender, ScrollEventArgs e)
        {
            lblTCount.Text = sldT.Value.ToString();
            calculate();
        }

        private void sldC_Scroll(object sender, ScrollEventArgs e)
        {
            lblCCount.Text = sldC.Value.ToString();
            calculate();
        }

        private void sldTC_Scroll(object sender, ScrollEventArgs e)
        {
            lblTCCount.Text = sldTC.Value.ToString();
            calculate();
        }

        private void calculate()
        {
            
            truckload = truckvalue* sldT.Value;
            carload = carvalue* sldC.Value;
            mcload = mcvalue* sldMC.Value;
            traincarload = traincarvalue* sldTC.Value;
            totalLoad = truckload + carload + mcload + traincarload;
            lblResult.Text = "Capacity : 239, current load : " + totalLoad.ToString();
            progressBar1.Value = (totalLoad >= progressBar1.Maximum)? progressBar1.Maximum: totalLoad;
            if (totalLoad<capacity)
            {
                progressBar1.ForeColor = Color.Brown;
                progressBar1.Style= ProgressBarStyle.Continuous;
            }
            else if (totalLoad == capacity)
            {
                progressBar1.ForeColor = Color.Green;
                progressBar1.Style= ProgressBarStyle.Continuous;
            }
            else
            {
                progressBar1.ForeColor = Color.Red;
                progressBar1.Style= ProgressBarStyle.Continuous;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sldMC.Value=0;
            sldT.Value=0;
            sldC.Value=0;
            sldTC.Value=0;
            lblTCCount.Text = sldTC.Value.ToString();
            lblCCount.Text = sldC.Value.ToString();
            lblMCCount.Text = sldMC.Value.ToString();
            lblTCount.Text = sldT.Value.ToString();

            calculate();
        }
    }
}
