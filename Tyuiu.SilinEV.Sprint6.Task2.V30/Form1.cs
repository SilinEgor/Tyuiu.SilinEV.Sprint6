using Tyuiu.SilinEV.Sprint6.Task2.V30.Lib;

namespace Tyuiu.SilinEV.Sprint6.Task2.V30
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
            this.chart1.Titles.Add("������ �-���");
            this.chart1.ChartAreas[0].AxisX.Title = "��� �";
            this.chart1.ChartAreas[0].AxisY.Title = "��� Y";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.Rows.Clear();
                this.chart1.Series[0].Points.Clear();

                int a = Convert.ToInt32(textBox1.Text), s = Convert.ToInt32(textBox2.Text);
                double[] d = ds.GetMassFunction(a, s);


                for (int i = 0; i < d.Length; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(a), Convert.ToString(d[i]));
                    this.chart1.Series[0].Points.AddXY(a, d[i]);
                    a++;
                }
            }
            catch
            {
            }
        }
    }
}
