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

            double resultado = 0;

            if (cboConversor.SelectedIndex >= 0)
            {
                double moneda = double.Parse(txtMoneda.Text);

                switch (cboConversor.SelectedIndex)
                {
                    case 0:
                        resultado = moneda * 36.80; //1 Dolar = 36.80 Córdoba
                        break;
                    case 1:
                        resultado = moneda * 26.30; //1 Dolar = 26.30 Lempiras
                        break;
                    case 2:
                        resultado = moneda * 1.0; //1 Dolar = 1 Balboa
                        break;
                    case 3:
                        resultado = moneda * 505.44; //1 Dolar = 505.44 Colones Costarricenses
                        break;
                    case 4:
                        resultado = moneda * 7.66; //1 Dolar= 7.66 Quetzales
                        break;
                    case 5:
                        resultado = moneda * 18.82; //1 Dolar = 18.82 Pesos
                        break;
                    case 6:
                        resultado = moneda * 3.54; //1 Dolar = 3.54 Soles
                        break;
                    case 7:
                        resultado = moneda * 0.86; //1 Dolar = 0.86 Euros
                        break;
                    case 8:
                        resultado = moneda * 147.60; //1 Dolar = 147.60 Yenes
                        break;
                    case 9:
                        resultado = moneda * 7.18; //1 Dolar = 7.18 Yuanes
                        break;
                }
                lblResultado.Text = "$" + moneda + " = " + resultado.ToString("F2") + " "
                    + cboConversor.SelectedItem.ToString();
            }

            else if (cboConversor2.SelectedIndex >= 0)
            {
                double masa = double.Parse(txtMasa.Text);

                switch (cboConversor2.SelectedIndex)
                {
                    case 0:
                        resultado = masa / 1000;
                        break;
                    case 1:
                        resultado = masa / 100;
                        break;
                    case 2:
                        resultado = masa / 6.350;
                        break;
                    case 3:
                        resultado = masa * 2.2046;
                        break;
                    case 4:
                        resultado = masa * 35.274;
                        break;
                    case 5:
                        resultado = masa * 10;
                        break;
                    case 6:
                        resultado = masa * 100;
                        break;
                    case 7:
                        resultado = masa * 1000;
                        break;
                    case 8:
                        resultado = masa * 1000000;
                        break;
                    case 9:
                        resultado = masa * 1000000000;
                        break;
                }
                lblResultado.Text = masa + "kg" + " = " + resultado.ToString("F2") + " "
                    + cboConversor2.SelectedItem.ToString();
            }

            else if (cboConversor3.SelectedIndex >= 0)
            {
                double volumen = double.Parse(txtVolumen.Text);

                switch (cboConversor3.SelectedIndex)
                {
                    case 0:
                        resultado = volumen / 1000;
                        break;
                    case 1:
                        resultado = volumen / 100;
                        break;
                    case 2:
                        resultado = volumen / 158.98;
                        break;
                    case 3:
                        resultado = volumen * 0.264;
                        break;
                    case 4:
                        resultado = volumen / 10;
                        break;
                    case 5:
                        resultado = volumen * 2.113;
                        break;
                    case 6:
                        resultado = volumen * 33.81;
                        break;
                    case 7:
                        resultado = volumen * 10;
                        break;
                    case 8:
                        resultado = volumen * 100;
                        break;
                    case 9:
                        resultado = volumen * 1000;
                        break;
                }
                lblResultado.Text = volumen + "L" + " = " + resultado.ToString("F2") + " "
                    + cboConversor3.SelectedItem.ToString();
            }

            else if (cboConversor4.SelectedIndex >= 0)
            {
                double longitud = double.Parse(txtLongitud.Text);

                switch (cboConversor4.SelectedIndex) 
                {
                    case 0:
                        resultado = longitud / 1000;
                        break;
                    case 1:
                        resultado = longitud / 100;
                        break;
                    case 2:
                        resultado = longitud / 10;
                        break;
                    case 3:
                        resultado = longitud * 10;
                        break;
                    case 4:
                        resultado = longitud * 100;
                        break;
                    case 5:
                        resultado = longitud * 1000;
                        break;
                    case 6:
                        resultado = longitud * 1000000;
                        break;
                    case 7:
                        resultado = longitud * 1000000000;
                        break;
                    case 8:
                        resultado = longitud / 0.0254;
                        break;
                    case 9:
                        resultado = longitud / 0.3048;
                        break;
                }
                lblResultado.Text = longitud + "m" + " = " + resultado.ToString("F2") + " "
                    + cboConversor4.SelectedItem.ToString();
            }
            else if (cboConversor5.SelectedIndex >= 0)
                {
                double almacenamiento = double.Parse(txtAlmacenamiento.Text);

                switch(cboConversor5.SelectedIndex)
                {
                    case 0:
                        resultado = almacenamiento * Math.Pow(10, 24);
                        break;
                    case 1:
                        resultado = almacenamiento * Math.Pow(10, 21);
                        break;
                    case 2:
                        resultado = almacenamiento * Math.Pow(10, 18);
                        break;
                    case 3:
                        resultado = almacenamiento * Math.Pow(10, 15);
                        break;
                    case 4:
                        resultado = almacenamiento * Math.Pow(10, 12);
                        break;
                    case 5:
                        resultado = almacenamiento * Math.Pow(10, 9);
                        break;
                    case 6:
                        resultado = almacenamiento * Math.Pow(10, 6);
                        break;
                    case 7:
                        resultado = almacenamiento * 1000;
                        break;
                    case 8:
                        resultado = almacenamiento * 100;
                        break;
                    case 9:
                        resultado = almacenamiento * 10;
                        break;
                }
                lblResultado.Text = almacenamiento + " " + cboConversor5.SelectedItem.ToString() +
                    " = " + resultado.ToString("G") + " B";
            }

            else if(cboConversor6.SelectedIndex >= 0)
            {
                double tiempo = double.Parse(txtTiempo.Text);

                switch (cboConversor6.SelectedIndex)
                {
                    case 0:
                        resultado = tiempo * 31536000;
                        break;
                    case 1:
                        resultado = tiempo * 2592000;
                        break;
                    case 2:
                        resultado = tiempo * 604800;
                        break;
                    case 3:
                        resultado = tiempo * 86400;
                        break;
                    case 4:
                        resultado = tiempo * 3600;
                        break;
                    case 5:
                        resultado = tiempo * 60;
                        break;
                    case 6:
                        resultado = tiempo / 1000;
                        break;
                    case 7:
                        resultado = tiempo / 1000000;
                        break;
                    case 8:
                        resultado = tiempo / 1000000000;
                        break;
                    case 9:
                        resultado = tiempo / 1000000000000;
                        break;
                }
                lblResultado.Text = tiempo + " " + cboConversor6.SelectedItem.ToString() +
                                    " = " + resultado.ToString("G") + " s";
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtMoneda.Text = "";
            txtMasa.Text = "";
            txtVolumen.Text = "";
            txtLongitud.Text = "";
            txtAlmacenamiento.Text = "";
            txtTiempo.Text = "";

            cboConversor.SelectedIndex = -1;
            cboConversor2.SelectedIndex = -1;
            cboConversor3.SelectedIndex = -1;
            cboConversor4.SelectedIndex = -1;
            cboConversor5.SelectedIndex = -1;
            cboConversor6.SelectedIndex = -1;

            lblResultado.Text = "Resultado: ?";
        }
    }
}

