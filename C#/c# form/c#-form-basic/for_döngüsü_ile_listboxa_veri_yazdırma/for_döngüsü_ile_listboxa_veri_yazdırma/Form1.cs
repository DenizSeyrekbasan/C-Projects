namespace for_döngüsü_ile_listboxa_veri_yazdırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text.ToString();
            int tekrar = int.Parse(textBox2.Text);

            for(int a = 0; a < tekrar; a++)
            {
                listBox1.Items.Add(metin);
            }
        }
    }
}