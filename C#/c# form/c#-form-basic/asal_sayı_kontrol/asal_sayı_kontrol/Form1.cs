namespace asal_sayı_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);

            for(int i = 2; i < sayi; i++)
            {
                if (sayi%i==0)
                {
                    sayac++;
                }
            }
            if (sayac!=0)
            {
                MessageBox.Show("Girilen sayı asal değildir !");
            }
            else
            {
                MessageBox.Show("Girilen sayı asaldır !");
            }
        }
    }
}