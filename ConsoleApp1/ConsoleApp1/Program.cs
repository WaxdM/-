using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DataTable dt = new DataTable();
            Random number = new Random(); //实例化一个随机数           
            string[] operatos = new string[] { "＋", "－", "×", "÷" };
            string[] operatos1 = new string[] { "+", "-", "*", "/" };
            Console.WriteLine("要生成多少题，最多支持10000题");
            int draw = Convert.ToInt32(Console.ReadLine()); //获取出题量
            Console.WriteLine("要生多少以内的计算题(0~100之内)");
            int difficulty = Convert.ToInt32(Console.ReadLine()); //获取出题量 
           
            var str = "";
            for (int s = 0; s < draw; s++)
            {

                int nubere_shu = number.Next(1, 4);
                Console.WriteLine(Class1.formula(dt, number, difficulty, operatos, operatos1, nubere_shu));
                str = Class1.formula(dt, number, difficulty, operatos, operatos1, nubere_shu)+"\r\n";

            }
            var newTxtPathT = "E:\\Exercise.txt";
            var newTxtPathD = "E:\\Answer.txt";
            StreamWriter sw1 = new StreamWriter(newTxtPathT, false, Encoding.Default);
            StreamWriter sw2 = new StreamWriter(newTxtPathD, false, Encoding.Default);

            sw1.Write(str);

            sw1.Flush();
            sw1.Close();

            sw2.Write(str);
            sw2.Flush();
            sw2.Close();


            Console.ReadKey();


        }
    }
}
