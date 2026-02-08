using System.Diagnostics;
using System.Text;

namespace c_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             (a):
             strings in C# are immutable, which means they cannot be modified after creation
             each time the += operator is used, a new string object is created in memory, and the old one becomes eligible for garbage collection
            - when this happens repeatedly (5,000 times), it causes:
            excessive memory allocations ,increased garbage collection overhead, slower performance
         
            (b):
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 5000; i++)
            {
                sb.Append(i);
                sb.Append(",");
            }
            string result = sb.ToString();
              
         (c):
            // String version
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            string s = "";
            for (int i = 1; i <= 5000; i++)
            {
                s += i + ",";
            }
            sw1.Stop();
            long stringTime = sw1.ElapsedMilliseconds;

            // StringBuilder version
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 5000; i++)
            {
                sb.Append(i).Append(",");
            }

            sw2.Stop();
            long builderTime = sw2.ElapsedMilliseconds;
            Console.WriteLine($"String Time: {stringTime} ms");
            Console.WriteLine($"StringBuilder Time: {builderTime} ms");
            Console.WriteLine($"Time Difference: {stringTime - builderTime} ms");
       */
            #endregion
        }
    }
}
