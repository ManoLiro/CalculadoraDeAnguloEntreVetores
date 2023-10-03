using System.Globalization;
using System.Numerics;

namespace CalculadoraDeAnguloEntreVetores
{
    public partial class CalculadoraDeAngulo : Form
    {
        public CalculadoraDeAngulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] VetorA123 = VetorU.Text.Split('.');
            string[] VetorB123 = VetorV.Text.Split('.');

            int vetorA1 = Convert.ToInt32(VetorA123[0]);
            int vetorA2 = Convert.ToInt32(VetorA123[1]);
            int vetorA3 = Convert.ToInt32(VetorA123[2]);
            int vetorB1 = Convert.ToInt32(VetorB123[0]);
            int vetorB2 = Convert.ToInt32(VetorB123[1]);
            int vetorB3 = Convert.ToInt32(VetorB123[2]);

            double[] vectorA = { vetorA1, vetorA2, vetorA3 };
            double[] vectorB = { vetorB1, vetorB2, vetorB3 };

            double angle = Calculos.AngleBetweenVectors(vectorA, vectorB);
            PrimeiroCalculo.Text = Calculos.DotProductString(vectorA, vectorB);
            SegundoCalculoVetorA.Text = "Vetor U = " + Calculos.VectorMagnitude5tring(vectorA);
            SegundoCalculoVetorB.Text = "Vetor V = " + Calculos.VectorMagnitude5tring(vectorB);
            CosTheta.Text = "Cos Theta = " + Calculos.cosThetaString(vectorA, vectorB);
            ConvertendoGraus.Text = Calculos.AngleBetweenVectorsString(vectorA, vectorB);
            TextAngulo.Text = $"O ângulo entre os vetores U e V é de {angle.ToString("N2", new CultureInfo("pt-BR"))} graus.";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrimeiroCalculo.Text = ".";
            SegundoCalculoVetorA.Text = ".";
            SegundoCalculoVetorB.Text = ".";
            CosTheta.Text = ".";
            ConvertendoGraus.Text = ".";
            TextAngulo.Text = ".";
            VetorU.Text = "";
            VetorV.Text = "";
        }
    }
}