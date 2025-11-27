using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AndreevIA.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string filePath = Path.GetTempFileName();
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double f_x = CalculateFunction(x);

                    string result = FormatResult(f_x);

                    sw.WriteLine(result);

                    Console.WriteLine(result);
                }
            }

            return filePath;
        }

        private double CalculateFunction(int x)
        {
            try
            {
                double denominator = 2 * x - 1;
                if (denominator == 0)
                {
                    return 0; 
                }

                double result = ((2 * Math.Cos(x) + 2) / denominator) + Math.Cos(x) - 5 * x + 3;
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private string FormatResult(double value)
        {
            if (Math.Abs(value) < 0.01)
            {
                return "0";
            }

            return value.ToString("F2", CultureInfo.InvariantCulture).Replace('.', ',');
        }
    }
}