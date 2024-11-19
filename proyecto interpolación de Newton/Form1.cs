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
            // Obtener los datos de entrada
            List<double> xValues = new List<double> { double.Parse(txtX1.Text), double.Parse(txtX2.Text), double.Parse(txtX3.Text), double.Parse(txtX4.Text) };
            List<double> yValues = new List<double> { double.Parse(txtY1.Text), double.Parse(txtY2.Text), double.Parse(txtY3.Text), double.Parse(txtY4.Text) };

            // Calcular las diferencias divididas
            double[] coeficientes = CalcularDiferenciasDivididas(xValues, yValues);

            // Evaluar el polinomio en un punto dado (por ejemplo, en el primer punto)
            double x = xValues[0];
            double resultado = EvaluarPolinomio(coeficientes, xValues, x);

            // Mostrar el resultado
            txtResultado.Text = resultado.ToString();
        }

        private double[] CalcularDiferenciasDivididas(List<double> x, List<double> y)
        {
            int n = x.Count;
            double[,] tabla = new double[n, n];

            // Inicializar la primera columna con los valores de y
            for (int i = 0; i < n; i++)
            {
                tabla[i, 0] = y[i];
            }

            // Calcular las diferencias divididas
            for (int j = 1; j < n; j++)
            {
                for (int i = 0; i < n - j; i++)
                {
                    tabla[i, j] = (tabla[i + 1, j - 1] - tabla[i, j - 1]) / (x[i + j] - x[i]);
                }
            }

            // Extraer los coeficientes
            double[] coeficientes = new double[n];
            for (int i = 0; i < n; i++)
            {
                coeficientes[i] = tabla[0, i];
            }

            return coeficientes;
        }

        private double EvaluarPolinomio(double[] coeficientes, List<double> x, double valor)
        {
            int n = coeficientes.Length;
            double resultado = coeficientes[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                resultado = resultado * (valor - x[i]) + coeficientes[i];
            }

            return resultado;
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
