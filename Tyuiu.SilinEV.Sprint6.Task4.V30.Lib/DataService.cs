using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SilinEV.Sprint6.Task4.V30.Lib
{
    public class DataService : ISprint6Task4V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] a = new double[stopValue - startValue + 1];
            int s = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                a[s] = Math.Round(((5 * i + 2.5) / (Math.Sin(i) + 2)) + 2 * i + 2, 2);
                s++;
            }

            return a;
        }
    }
}
