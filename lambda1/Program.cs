using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> func = new Func<int, int, int>((int a, int b) => { return a + b; });
            int res = func(300,400);
            Console.WriteLine(res);

            Func<string, string, string> func2 = new Func<string, string, string>((string x,string y)=> { return x + y; });
            string str = func2("a","b");
            Console.WriteLine(str);

            //DoSomeCalc<int>((int m, int n) => { return m * n; }, 200, 100);
            DoSomeCalc(( m,  n) => { return m * n; }, 200, 100);
            //m,n的数据类型可以由返回值类型推出，返回值类型又可以由200，100标准整形推出，故都可以省略         
        }

        static void DoSomeCalc<T>(Func<T, T, T> func, T m, T n)
        {
            T result = func(m,n );
            Console.WriteLine(result);
        }
    }
}
