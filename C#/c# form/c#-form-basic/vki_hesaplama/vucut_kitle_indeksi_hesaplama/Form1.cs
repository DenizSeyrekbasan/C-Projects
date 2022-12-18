namespace vucut_kitle_indeksi_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(textBox1.Text);
            double kilo = Convert.ToDouble(textBox2.Text);

            double vki = kilo / (boy * boy);
            listBox1.Items.Add("Vücut Kitle Ýndeksiniz : " + vki);
        }
    }
}