namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saat = 0;
        int dakika = 0;
        int saniye = 0;
        int salise = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            label8.Text = salise.ToString();

            if (salise==100)
            {
                saniye++;
                label7.Text = saniye.ToString();
                salise = 0;
            }
            else if (saniye==60)
            {
                dakika++;
                label7.Text = dakika.ToString();
                saniye = 0;
            }
            else if (dakika==60)
            {
                saat++;
                label6.Text = saat.ToString();
                dakika = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            listBox1.Items.Add(saat + " : " + dakika + " : " + saniye + " : " + salise );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            saat = 0;
            dakika = 0;
            saniye = 0;
            salise = 0;
            listBox1.Items.Clear();
        }
    }
}