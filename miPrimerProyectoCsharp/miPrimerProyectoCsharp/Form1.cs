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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);

            if (optSuma.Checked)
            {
                resultado = num1 + num2;
            }

            if (optResta.Checked)
            {
                resultado = num1 - num2;
            }

            if (optMultiplicacion.Checked)
            {
                resultado = num1 * num2;
            }

            if (optDivision.Checked)
            {
                resultado = num1 / num2;
            }
 
            if (optExponente.Checked)
            { 
                resultado = Math.Pow(num1, num2);
            }

            if (optPorcentaje.Checked)
            { 
                resultado = num1*num2 / 100;
            }

            if (optFactorial.Checked)
            {
                resultado = (int)num1;
                for (int i = (int)num1 - 1; i > 1; i--) { //5! = 5*4*3*2*1 = 120
                    resultado *= i;
                }
            }

            if (optModulo.Checked)
            {
                resultado = num1%num2;
            }
            lblResultado.Text = "Resultado: " + resultado;

            //Validar si es primo
            if (optPrimo.Checked)
            {
                int i = 1, acum = 0;
                while(i<=num1 && acum<3)
                {
                    if (num1%i==0)
                    {
                        acum++; //acum = acum + 1;
                    }
                    i++;
                }
                if (acum <= 2)
                {
                    lblResultado.Text = "Respuesta: " + num1 + " es primo";
                } else {
                    lblResultado.Text = "Respuesta: " + num1 + " no es primo";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            double num1, num2, respuesta = 0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);


            switch (cboOpciones.SelectedIndex)
            {
                case 0:
                    respuesta = num1 + num2;
                    lblRespuesta.Text = "Respuesta: " + respuesta;
                    break;
                case 1:
                    respuesta = num1 - num2;
                    lblRespuesta.Text = "Respuesta: " + respuesta;
                    break;
                case 2:
                    respuesta = num1 * num2;
                    lblRespuesta.Text = "Respuesta: " + respuesta;
                    break;
                case 3:
                    respuesta = num1 / num2;
                    lblRespuesta.Text = "Respuesta: " + respuesta;
                    break;
                case 4:
                    respuesta = (int)num1;
                    for (int i = (int)num1 - 1; i > 1; i--) //5! = 5*4*3*2*1 = 120
                        respuesta *= i;
                    lblRespuesta.Text = "Respuesta: " + respuesta;
                    break;

                case 5:
                    {
                        int i = 1, acum = 0;
                        while (i <= num1 && acum < 3)
                        {
                            if (num1 % i == 0)
                            {
                                acum++; //acum = acum + 1;
                            }
                            i++;
                        }
                        if (acum <= 2)
                        {
                            lblRespuesta.Text = "Respuesta: " + num1 + " es primo";
                        }
                        else
                        {
                            lblRespuesta.Text = "Respuesta: " + num1 + " no es primo";
                        }
                    }
                    break;
            }
        }
    }
}

