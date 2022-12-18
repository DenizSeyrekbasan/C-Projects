using System.Globalization;

namespace iki_sayi_arasi_asal_sayilar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);

            for (int i = sayi1; i < sayi2; i++)
            {
                int kontrol = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        kontrol++;
                    }
                }
                if (kontrol == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}