namespace Daily
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp_ = "";
            float moneytoday = float.Parse(textBox1.Text);
            float money2, money3, money4, money6, money7, money8, money9, money10, money15, money20;
            money2 = moneytoday + (moneytoday * (float)0.02);
            money3 = moneytoday + (moneytoday * (float)0.03);
            money4 = moneytoday + (moneytoday * (float)0.04);
            money6 = moneytoday + (moneytoday * (float)0.06);
            money7 = moneytoday + (moneytoday * (float)0.07);
            money8 = moneytoday + (moneytoday * (float)0.08);
            money9 = moneytoday + (moneytoday * (float)0.09);
            money10 = moneytoday + (moneytoday * (float)0.10);
            money15 = moneytoday + (moneytoday * (float)0.15);
            money20 = moneytoday + (moneytoday * (float)0.20);
            textBox2.Text = $"2% >> {money2}\r3% >> {money3}\r4% >> {money4}\r6% >> {money6}\r7% >> {money7}\r8% >> {money8}\r9% >> {money9}\r10% >> {money10}\r15% >> {money15}\r20% >> {money20}\rToday Fund:: {moneytoday}\rToday:: {DateTime.Today.Year} / {DateTime.Today.Month} / {DateTime.Today.Day}";
            //textBox2.Text = temp_;
        }
    }
}