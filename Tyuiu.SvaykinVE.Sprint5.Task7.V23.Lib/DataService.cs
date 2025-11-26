using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
namespace Tyuiu.SvaykinVE.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            string pathf = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V23.txt");
            FileInfo fileInfo = new FileInfo(pathf);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(pathf);
            }
            string res = "";
            using (StreamReader reader = new StreamReader(path))

            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!((line[i] >= 'А' && line[i] <= 'Я') || (line[i] >= 'а' && line[i] <= 'я') || line[i] == 'ё' || line[i] == 'Ё'))
                        {
                            res = res + line[i];
                        }
                    }
                    File.AppendAllText(pathf, res);
                }
            }
            return (pathf);
        }
    }
}
