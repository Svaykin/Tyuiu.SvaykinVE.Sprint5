using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SvaykinVE.Sprint5.Task3.V8.Lib
{
    public class DataService : ISprint5Task3V8
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            double answer = Math.Round((Math.Pow(x, 2) + 1) / (3 * x + 4), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(answer));
            }
            return path;
        }
    }
}
