namespace comboboxtan_carpim_tablosu_yazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi = int.Parse(comboBox1.Text);
            for(int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(sayi + "*" + i + " = " + i * sayi);
            }
        }
    }
}