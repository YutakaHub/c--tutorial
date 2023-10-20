using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
  class Vector2D
  {
    private double y;
    public void Add(Vector2D v)
    {
      X += v.X; Y += v.y;
    }
    public void Sub(Vector2D v)
    {
      X -= v.X; y -= v.y;
    }
    public void Mul(double k)
    {
      X *= k; y *= k;
    }
    public double DotProduct(Vector2D v)
    {
      return X * v.X + y * v.y;
    }
    //アクセス就職子について学習。プロパティを設定する。自動実装プロパティについても学習。
    public double Y
    {
      set { y = value; }
      get { return y; }
    }
    public double X
    {
      set; get;
    }
  }
}
