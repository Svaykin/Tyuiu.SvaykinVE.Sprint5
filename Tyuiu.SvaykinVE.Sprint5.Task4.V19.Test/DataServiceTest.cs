using Tyuiu.SvaykinVE.Sprint5.Task4.V19.Lib;
using System.IO;
namespace Tyuiu.SvaykinVE.Sprint5.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V19.txt");

            FileInfo inf = new FileInfo(path);
            bool ex = inf.Exists;
            bool wait = true;

            Assert.AreEqual(wait, ex);
        }
    }
}
