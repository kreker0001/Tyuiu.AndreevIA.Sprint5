using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AndreevIA.Sprint5.Task0.V15.Lib
{
    public class DataService : ISprint5Task0V15
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double y = x / (Math.Pow(x, 3) + 2);
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}