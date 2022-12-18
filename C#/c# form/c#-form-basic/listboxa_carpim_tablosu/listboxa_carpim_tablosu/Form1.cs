namespace listboxa_carpim_tablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 10; i++)
            {
                for(int j=0;j<=10;j++)
                {
                    int sonuc = i * j;
                    listBox1.Items.Add(i + " * " + j + " = " + sonuc);
                }
            }
        }
    }
}