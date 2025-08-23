using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String[] serie = txrSerie.Text.Split(','); //5,10,15 => ("5","10,"15")

            int suma = 0;
            for (int i = 0; i < serie.Length; i++){
                suma = suma + int.Parse(serie[i]);
            }
            lblSuma.Text = "Suma: " + suma;
            //lblSuma.Text = " Serie: " + serie.Sum();
        }
    }
}

