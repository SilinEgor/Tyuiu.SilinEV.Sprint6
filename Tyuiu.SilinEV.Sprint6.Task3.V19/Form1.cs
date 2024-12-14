using Tyuiu.SilinEV.Sprint6.Task3.V19.Lib;

namespace Tyuiu.SilinEV.Sprint6.Task3.V19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] a = ds.Calculate(ds.qwe("4  32  -20  27  21  17  15  -1  -2  -1  -3  18  12  -10  29  7  -15  2  -8  12  -10  25  5  27  21"));
            this.dataGridView1.Rows.Clear();

            try
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(a[i, 0]), Convert.ToString(a[i, 1]), Convert.ToString(a[i, 2]), Convert.ToString(a[i, 3]), Convert.ToString(a[i, 4]));
                }
            }
            catch
            {

            }
        }
    }
}
