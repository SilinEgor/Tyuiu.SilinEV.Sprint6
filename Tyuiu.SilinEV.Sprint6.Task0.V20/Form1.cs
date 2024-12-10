using Tyuiu.SilinEV.Sprint6.Task0.V20.Lib;

namespace Tyuiu.SilinEV.Sprint6.Task0.V20
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox1.Text)));
        }
    }
}
