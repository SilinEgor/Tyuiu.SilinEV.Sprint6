using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SilinEV.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int[,] a = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 6 && matrix[i, j] % 5 == 0) a[i, j] = 2;
                    else a[i, j] = matrix[i, j];
                }
            }

            return a;
        }
    }
}
