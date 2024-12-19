using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SilinEV.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string str, string path)
        {
            string a = "";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    a += line[line.Length - 1] + " ";
                }
            }

            return a.Trim();
        }
    }
}
