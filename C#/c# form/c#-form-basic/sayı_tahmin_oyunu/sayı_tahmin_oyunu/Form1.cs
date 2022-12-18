namespace sayı_tahmin_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        
        private void button1_Click(object sender, EventArgs e)
        {
            int randomSayi = rnd.Next(1, 11);
            int tahmin = int.Parse(textBox1.Text);
            
            if (randomSayi==tahmin)
            {
                MessageBox.Show("Tahminiz doğru !");
            }
            else
            {
                MessageBox.Show("Yanlış tahmin !");
            }
            
        }
    }
}