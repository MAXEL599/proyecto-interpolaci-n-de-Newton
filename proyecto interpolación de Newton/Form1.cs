using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;

namespace proyecto_interpolación_de_Newton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<double> ValorX = new List<double> { double.Parse(txtX1.Text),double.Parse(txtX2.Text), double.Parse(txtX3.Text), double.Parse(txtX4.Text)  };
            List<double> ValorY = new List<double> { double.Parse(txtY1.Text), double.Parse(txtY2.Text), double.Parse(txtY3.Text), double.Parse(txtY4.Text) };

            
            double[] coficientes = Calcular_Diferencia(ValorX, ValorY);

            
            string polinomio = Polinomio(coficientes, ValorX);

            
            txtResultado.Text = polinomio;

        }

        private double[] Calcular_Diferencia(List<double> x, List<double> y)
        {
            int n = x.Count;
            double[,] tabla = new double[n, n];

          
            for (int i = 0; i < n; i++) 
            {
                tabla[i, 0] = y[i];
            }

           
            for (int j = 1; j < n; j++)
            {
                for (int i = 0; i < n - j; i++)
                {
                    tabla[i, j] = (tabla[i + 1, j - 1] - tabla[i, j - 1]) / (x[i + j] - x[i]);
                }
            }

            double[] coficientes = new double[n];
            for (int i = 0; i < n; i++)

            {
                coficientes[i] = tabla[0, i];
            }

            return coficientes;
        }


        private string Polinomio(double[] coficientes, List<double> x)
        {
            int n = coficientes.Length;
            string polinomio = coficientes[0].ToString("F2");

            for (int i = 1; i < n; i++)
            {
                polinomio += " + " + coficientes[i].ToString("F2");
                for (int j = 0; j < i; j++)
                {
                    polinomio += "(x - " + x[j].ToString("F2") + ")";
                }
            }

            return polinomio;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtX1.Text = string.Empty;
            txtX2.Text = string.Empty;
            txtX3.Text = string.Empty;
            txtX4.Text = string.Empty;
            txtY1.Text = string.Empty;
            txtY2.Text = string.Empty;
            txtY3.Text = string.Empty;
            txtY4.Text = string.Empty;
            txtResultado.Text = string.Empty;
        }
    }
}
