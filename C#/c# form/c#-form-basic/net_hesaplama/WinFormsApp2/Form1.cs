namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Td = Convert.ToDouble(textBox1.Text);
            double Ty = Convert.ToDouble(textBox2.Text);

            double Md = Convert.ToDouble(textBox4.Text);
            double My = Convert.ToDouble(textBox5.Text);

            double Fd = Convert.ToDouble(textBox7.Text);
            double Fy = Convert.ToDouble(textBox8.Text);


            double türkceNet = Td - (Ty / 4);
            textBox3.Text = türkceNet.ToString();

            double matNet = Md - (My / 4);
            textBox6.Text = matNet.ToString();

            double fizNet = Fd - (Fy / 4);
            textBox9.Text = fizNet.ToString();



        }
    }
}