namespace CalculadoraDeAnguloEntreVetores
{
    public partial class Form1 : Form
    {
        public Form1()
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
            TextAngulo.Text = $"O ângulo entre os vetores A e B é de {angle} graus.";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}