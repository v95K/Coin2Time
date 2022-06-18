namespace Coin2Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a;
            a = Decimal.ToDouble(numericUpDown1.Value);
            double b;
            b = a - 1;
            b = b * 3;
            b = b + 4.5;
            TimeSpan t = TimeSpan.FromMinutes(b);
            double hours = t.TotalHours;
            label3.Text = t.ToString();
        }
    }
}