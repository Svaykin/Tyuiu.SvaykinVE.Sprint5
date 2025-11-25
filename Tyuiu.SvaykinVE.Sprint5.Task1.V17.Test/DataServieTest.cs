using Tyuiu.SvaykinVE.Sprint5.Task1.V17.Lib;
using System.IO;
namespace Tyuiu.SvaykinVE.Sprint5.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServieTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                string path = Path.GetTempFileName();
                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
        }
    }
}
