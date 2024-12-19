using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SilinEV.Sprint6.Task5.V13.Lib
{
    public class DataService : ISprint6Task5V13
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] a = File.ReadAllText(path).Replace(".", ",").Split(" " + Environment.NewLine);

            double[] s = new double[1];
            int d = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (Convert.ToDouble(a[i]) < 10)
                {
                    s[d] = Convert.ToDouble(a[i]);
                    d++;
                    Array.Resize(ref s, d + 1);
                }
            }

            Array.Resize(ref s, d);

            return s;
        }
    }
}
