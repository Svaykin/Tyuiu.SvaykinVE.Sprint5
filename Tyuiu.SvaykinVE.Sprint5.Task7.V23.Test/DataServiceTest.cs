using Tyuiu.SvaykinVE.Sprint5.Task7.V23.Lib;
using System.IO;
namespace Tyuiu.SvaykinVE.Sprint5.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "C:", "Users", "svayk", "AppData", "Local", "Temp", "OutPutDataFileTask7V23.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
