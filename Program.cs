using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
  class Program
  {
    //ベクトルの内容を表示するメソッド。静的メンバ（Static）、インスタンスメンバについて学習。
    static void Show(string name, Vector2D v)
    {
      Console.WriteLine("{0}={1},{2}", name, v.X, v.Y);
    }
    static void Main(string[] args)
    {
      Vector2D v1 = new Vector2D(1.0, 1.0);
      Show("v1", v1);
      Vector2D w = new Vector2D(1.0, -1.0);
      Vector2D v2 = new Vector2D(w);
      v2.X = 1.0; v2.Y = -1.0;
      Show("v2", v2);
      v1.Add(v2);
      Show("v1", v1);
      v1.Sub(v2);
      Show("v1", v1);
      v1.Mul(2.0);
      Show("v1", v1);

      Console.WriteLine("v1=,v2の内積：{0}", v1.DotProduct(v2));

    }
  }
}
