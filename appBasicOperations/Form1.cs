using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBasicOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double c,num1,num2;
        private void sumar(double a, double b)
        {
            c = a + b;
        }
        private void restar(double a, double b)
        {
            c = a - b;
        }
        private void multiplicar(double a, double b)
        {
            c = a * b;
        }
        private void dividir(double a, double b)
        {
            c = a / b;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnum1.TextLength == 0 || txtnum2.TextLength == 0)
                {
                    MessageBox.Show("Por favor introduzca los datos en todos los campos");
                }
                else
                {
                    num1 = double.Parse(txtnum1.Text);
                    num2 = double.Parse(txtnum2.Text);
                    if (rdSuma.Checked == true)
                    {
                        sumar(num1, num2);
                        MessageBox.Show("El resultado es " + num1 + " + " + num2 + " = " + c);
                    }
                    else
                    {
                        if (rdResta.Checked == true)
                        {
                            restar(num1, num2);
                            MessageBox.Show("El resultado es " + num1 + " - " + num2 + " = " + c);
                        }
                        else
                        {
                            if (rdMultiplicacion.Checked == true)
                            {
                                MessageBox.Show("El resultado es " + num1 + " * " + num2 + " = " + c);
                            }
                            else
                            {
                                if (rdDivision.Checked == true)
                                {
                                    MessageBox.Show("El resultado es " + num1 + " / " + num2 + " = " + c);
                                }
                                else
                                {
                                    MessageBox.Show("Por favor seleccione una operacion antes de continuar");
                                }
                            }
                        }
                    }

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato de la conversion ");

                throw;
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("Error aritmetico en la operacion");

                throw;
            }
        }
    }
}
