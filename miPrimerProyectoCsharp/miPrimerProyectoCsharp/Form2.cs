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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
 
        }


        double[][] valores = new double[][]
        {
            new double[]
            {1, 0.0929, 0.6987, 0.8361, 437.5, 6988, 10000}
        };

        private double conversion(double cantidad, int tipo, int a)
        {
            double m = cantidad * valores[0][tipo];

            double resultado = m / valores[0][a];

            return resultado;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double cantidad = double.Parse(txtCantidad.Text);
                    int tipo = cboMedidaOrigen.SelectedIndex;
                    int a = cboMedidaObtener.SelectedIndex;

                    double respuesta = conversion(cantidad, tipo, a);

                    lblResultadoConversion.Text = "Conversion: " + respuesta.ToString("F2");
                }
                catch
                {
                    MessageBox.Show("Por favor, ingrese un valor valido");
                    txtCantidad.Text = string.Empty;
                }
            }
        }
    }
}
