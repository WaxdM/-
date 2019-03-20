using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public static string formula(DataTable dt, Random number, int difficulty, string[] operatos, string[] operatos1, int shu)
        {
            string number1 = number.Next(0, difficulty).ToString();//运算公式自然数
            string results = number1;//用于输出
            string results1 = number1;//用于计算
            for (int s = 0; s < shu; s++)
            {
                int number_op = number.Next(0, 4);//随机一次运算符
                number1 = number.Next(1, difficulty).ToString();//随机一个自然数
                results += operatos[number_op] + number1;//把运算符和自然数添加进用于计算的字符串
                results1 += operatos1[number_op] + number1;//把运算符和自然数添加进用于输出的字符串
            }
            double st = double.Parse(dt.Compute(results1, "null").ToString());//计算字符串类型公式的结果
            results += "=" + st.ToString();//把运算结果添加输出字符串
            if (st < 0 || st.ToString() == "∞")//判断结果 如果小于0或无穷大 则重新运行一次
            {
                results = formula(dt, number, difficulty, operatos, operatos1, shu);
            }

            return results;//把最终的输出公式返回
        }
    }
}
