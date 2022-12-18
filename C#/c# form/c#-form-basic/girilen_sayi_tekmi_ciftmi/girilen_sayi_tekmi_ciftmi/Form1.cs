namespace girilen_sayi_tekmi_ciftmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);

            if (sayi%2==0)
            {
                MessageBox.Show("Sayý Çift");
            }
            else
            {
                MessageBox.Show("Sayý Tek");
            }
        }
    }
}