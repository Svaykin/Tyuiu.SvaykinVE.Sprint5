using Tyuiu.SvaykinVE.Sprint5.Task0.V12.Lib;
using System.IO;
namespace Tyuiu.SvaykinVE.Sprint5.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait ,fileExists);
        }
    }
}
