namespace lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double ans = 0;
        public int n;
        private void button1_Click(object sender, EventArgs e)
        {
            ans = 0;
            for (int i = 0; i < n; i++)
            {
                ans += Math.Pow(-1, i) * (2 * i + 1);
            }
            textBox1.Text = $"Ответ при n = {n}: {ans}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ans = Math.Pow(-1, (n - 1)) * ((n - 1) + 1);
            textBox1.Text = $"Ответ при n = {n}: {ans}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = vScrollBar1.Value.ToString();
            n = vScrollBar1.Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = $"Значение n={n}";
            button1.Text = "Вычисление в цикле";
            button2.Text = "Вычисление по формуле";
            textBox1.Text = "Ответ";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
