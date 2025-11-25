using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SvaykinVE.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();
            bool fiex = File.Exists(path);
            if (fiex == true)
            { File.Delete(path); }
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                strY = null;
                y = Math.Round((2*x - 4 + ((2*x-1)/(Math.Sin(x)+1))), 2);
                if ((Math.Sin(x) + 1)==0)
                { y = 0; }
                strY = Convert.ToString(y);
                if (x != stopValue)
                { File.AppendAllText(path, strY + Environment.NewLine); }
                else;
                { File.AppendAllText(path, strY); }
            }
            return path;
        }
    }
}
