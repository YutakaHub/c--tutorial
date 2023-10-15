using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample101
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Hello");
      Console.WriteLine("World");

      //四則演算
      Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2);
      Console.WriteLine("{0} - {1} = {2}", 5, 2, 5 - 2);
      Console.WriteLine("{0} * {1} = {2}", 5, 2, 5 * 2);
      //変数を使用する
      int a;
      double b = 2;
      a = (int)7.9;  //キャストで代入
      double avg;
      avg = a / b;
      Console.WriteLine("{0} / {1} = {2}", a, b, avg);
      string str1 = Console.ReadLine();
      string str2 = Console.ReadLine();
      Console.WriteLine(str1 + str2);

    }
  }
}
