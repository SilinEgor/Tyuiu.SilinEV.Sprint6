using System.Net.Http.Headers;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SilinEV.Sprint6.Task1.V28.Lib
{
    public class DataService : ISprint6Task1V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] a = new double[stopValue -  startValue + 1];
            int s = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                a[s] = Math.Round(Math.Cos(i) + 2 * i - Math.Sin(i) * 3 * i, 2);
                s++;
            }

            return a;
        }
    }
}
