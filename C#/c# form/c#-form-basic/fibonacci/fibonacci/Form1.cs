namespace fibonacci
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
            int a = 1;
            int b = 1;
            int c;

            listBox1.Items.Add(a);
            listBox1.Items.Add(b);

            for(int i = 1; i <= sayi; i++)
            {
                c = a + b;
                a = b;
                b = c;
                listBox1.Items.Add(c);
            }
        }
    }
}