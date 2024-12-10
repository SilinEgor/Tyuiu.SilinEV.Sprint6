using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SilinEV.Sprint6.Task0.V20.Lib
{
    public class DataService : ISprint6Task0V20
    {
        public double Calculate(int x)
        {
            double a = Convert.ToDouble(x);

            return Math.Round((3 * Math.Pow(a, 4) + 1) / Math.Pow(a, 3), 3);
        }
    }
}
