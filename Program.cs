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
            #region Q2
            /*
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter day (1-7): ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Student ID? (yes/no): ");
            bool isStudent = Console.ReadLine().ToLower() == "yes";
            double price = 0;
            string breakdown = "";
            if (age < 5)
            {
                price = 0;
                breakdown = "free ticket";
            }
            else if (age <= 12)
            {
                price = 30;
                breakdown = "price: 30 LE";
            }
            else if (age <= 59)
            {
                price = 50;
                breakdown = "price: 50 LE";
            }
            else
            {
                price = 25;
                breakdown = "price: 25 LE";
            }

     
            if (price > 0 && (day == 6 || day == 7))
            {
                price += 10;
                breakdown += "\nweekend surcharge: +10 LE";
            }
            if (price > 0 && isStudent)
            {
                double discount = price * 0.2;
                price -= discount;
                breakdown += $"\nstudent discount: -{discount} LE";
            }

            Console.WriteLine("\n--- ticket breakdown ---");
            Console.WriteLine(breakdown);
            Console.WriteLine($"final price: {price} LE");
            */
            #endregion
            #region Q3
            // (a) A traditional switch statement:
            //string fileExtension = ".pdf";
            //string fileType;

            //switch (fileExtension)
            //{
            //    case ".pdf":
            //     fileType = "PDF document";
            //      break;

            //    case ".docx":
            //    case ".doc":
            //        fileType = "word document";
            //        break;

            //    case ".xlsx":
            //    case ".xls":
            //        fileType = "excel document";
            //        break;

            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "image document";
            //        break;

            //    default:
            //        fileType = "unknown file type";
            //        break;
            //}

            // (b) A switch expression:
            //string fileExtension = ".pdf";
            //string fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF document",
            //    ".docx" or ".doc" => "Word document",
            //    ".xlsx" or ".xls" => "excel document",
            //    ".jpg" or ".png" or ".gif" => "image document",
            //    _ => "Unknown file type"
            //};
            #endregion
            #region Q4
            //int temp = 35;
            //string weatherAdvice =
            //    temp < 0 ? "freezing! stay indoors" :
            //    temp < 15 ? "cold.wear a jacket" :
            //    temp < 25 ? "pleasant weather" :
            //    temp < 35 ? "warm. stay hydrated" : "hot! avoid sun exposure";
            //ternary operators are best used for simple and short conditions , like this code
            //if-else statements are more readable and maintainable for complex logic or when there are many conditions
            #endregion
            #region Q5
            //    int attempts = 0;
            //    do
            //    {
            //        attempts++;
            //        Console.WriteLine("enter your password");
            //        string password = Console.ReadLine();
            //        bool upperCaseLetter = false, digit = false, spaces = false;

            //        foreach (char c in password)
            //        {
            //            if (char.IsDigit(c))
            //                digit = true;
            //            if (char.IsUpper(c))
            //                upperCaseLetter = true;
            //            if (char.IsWhiteSpace(c))
            //                spaces = true;
            //        }
            //        if (password.Length >= 8 && upperCaseLetter == true && spaces == false && digit == true)
            //        {
            //            Console.WriteLine("Password accepted!");
            //            break;
            //        }
            //        if (!upperCaseLetter)
            //            Console.WriteLine("password must contain uppercase letter!");
            //        if (password.Length < 8)
            //            Console.WriteLine("minimum 8 characters!");
            //        if (!digit)
            //            Console.WriteLine("password must contain at least one digit!");
            //        if (spaces)
            //            Console.WriteLine("no spaces allowed");

            //        if (attempts == 5)
            //        {
            //            Console.WriteLine("account locked!");
            //            break;
            //        }

            //        #endregion
            //    }
            //    while (true);
            #endregion
            #region Q6
            int[] scores = { 85, 42, 67, 55, 78, 39, 88, 72, 95, 60, 48 };

            int A = 0, B = 0, C = 0, D = 0, F = 0;
            double sum = 0.0 , count = 0.0;
            foreach (int i in scores)
            {
                if(i < 50)
                    Console.WriteLine($"{i} : fail");
                if (i > 40)
                  {  sum += i;
                    count++;
                }

                if (i >= 90)
                    A++;
                else if (i >= 80)
                    B++;
                else if(i >=70)
                    C++;
                else if (i >= 60)
                    D++;
                else
                    F++;
            }
            Console.WriteLine($"average scores : {sum / count}");
            Console.WriteLine($"A : {A}\nB : {B}\nC : {C}\nD : {D}\nF : {F}");

            foreach (int i in scores)
            {
                if (i > 90)
                {
                    Console.WriteLine($"first above 90 : {i}");
                    break;
                }
            }
            #endregion
        }

    }
    }

