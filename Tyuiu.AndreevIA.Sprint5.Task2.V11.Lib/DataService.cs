using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AndreevIA.Sprint5.Task2.V11.Lib
{
    public class DataService : ISprint5Task2V11
    {
        public string SaveToFileTextData(int[,] m)
        {
            int rows, columns;
            rows = m.GetLength(0);
            columns = m.GetLength(1);


            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (m[i, j] % 2 != 0)
                    {
                        m[i, j] = 0;
                    }
                }
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += m[i, j] + ";";
                    }
                    else
                    {
                        str += m[i, j];
                    }
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";


            }
            return path;

        }
    }
}