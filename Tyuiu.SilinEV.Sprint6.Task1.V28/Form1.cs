using Tyuiu.SilinEV.Sprint6.Task1.V28.Lib;

namespace Tyuiu.SilinEV.Sprint6.Task1.V28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            try
            {
                int a = Convert.ToInt32(textBox1.Text), s = Convert.ToInt32(textBox2.Text);
                double[] d = ds.GetMassFunction(a, s);
                for (int i = 0; i < d.Length; i++)
                {
                    textBox3.Text += $"{a} | {d[i]}" + Environment.NewLine;
                    a++;
                }
            }
            catch 
            {
                textBox3.Text = "Ошибка значений";
            }
        }
    }
}
