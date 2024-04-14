namespace WinFormsApp_лаба_11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int suma = 0;
            if (n >= 0)
            {
                while (n > 0)
                {
                    suma += 2 * n;
                    n--;
                }
                MessageBox.Show(suma.ToString());
            }
            else
            {
                MessageBox.Show("Неверный формат!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int suma = 0;
            if (n >= 0)
            {
                suma = n * (n + 1);
                MessageBox.Show(suma.ToString());
            }
            else
            {
                MessageBox.Show("Неверный формат!");
            }
        }
    }
}
