namespace ortalama_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int number3 = int.Parse(textBox3.Text);

            int ort=(number1+number2+number3)/3;

            if (ort>=50)
            {
                textBox4.Text = "Geçti/Ortalamanýz : " + ort;
            }
            else
            {
                textBox4.Text = "Kaldý/Ortalamanýz : " + ort;
            }

        }
    }
}