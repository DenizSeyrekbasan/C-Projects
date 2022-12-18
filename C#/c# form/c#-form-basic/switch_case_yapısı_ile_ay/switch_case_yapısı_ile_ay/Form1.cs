namespace switch_case_yapısı_ile_ay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = int.Parse(textBox1.Text);
            switch (ay)
            {
                case 1 : MessageBox.Show("1. ay ocak");break;
                case 2: MessageBox.Show("2. ay şubat");break;
                case 3: MessageBox.Show("3. ay mart");break;
                case 4: MessageBox.Show("4. ay nisan"); break;
                case 5: MessageBox.Show("5. ay mayıs"); break;
                case 6: MessageBox.Show("6. ay haziran"); break;
                case 7: MessageBox.Show("7. ay temmuz"); break;
                case 8: MessageBox.Show("8. ay ağustos"); break;
                case 9: MessageBox.Show("9. ay eylül"); break;
                case 10: MessageBox.Show("10. ay ekim"); break;
                case 11: MessageBox.Show("11. ay kasım"); break;
                case 12: MessageBox.Show("12. ay aralık"); break;
                default:MessageBox.Show("tanımsız !"); break;


            }
        }
    }
}