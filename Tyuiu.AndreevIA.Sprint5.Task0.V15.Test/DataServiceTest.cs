using System.IO;
using Tyuiu.AndreevIA.Sprint5.Task0.V15.Lib;
namespace Tyuiu.AndreevIA.Sprint5.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\krona\source\repos\Tyuiu.AndreevIA.Sprint5\Tyuiu.AndreevIA.Sprint5.Task0.V15\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
