using System;

namespace CSharp_7._2_Demo
{
  readonly struct PointExtendedReadonly
  {
    public int X { get; }
    public int Y { get; }
    public int Z { get; }

    public PointExtendedReadonly(int x, int y, int z)
    {
      X = x;
      Y = y;
      Z = z;
    }

  }

  readonly ref struct PointExtendedReadonlyRef
  {
    public int X { get; }
    public int Y { get; }
    public int Z { get; }

    public PointExtendedReadonlyRef(int x, int y, int z)
    {
      X = x;
      Y = y;
      Z = z;
    }
  }

  struct PointExtended
  {
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public void UpdateValues(int x, int y, int z)
    {
      X = x;
      Y = y;
      Z = z;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {

      var myPoint = new PointExtended { X = 1, Y = 1, Z = 1 };
      Console.WriteLine($"Before: X {myPoint.X}, Y {myPoint.Y}, Z {myPoint.Z}");
      UpdateValues(myPoint);
      UpdateValuesWithoutIn(myPoint);

      Console.WriteLine($"After: X {myPoint.X}, Y {myPoint.Y}, Z {myPoint.Z}");

      var pointExtendedReadonly = new PointExtendedReadonly(1, 1, 1);
      Console.WriteLine($"ReadOnly: X {pointExtendedReadonly.X}, Y {pointExtendedReadonly.Y}, Z {pointExtendedReadonly.Z}");

      var pointExtendedReadonlyRef = new PointExtendedReadonlyRef(1, 1, 1);
      Console.WriteLine($"ReadOnlyRef: X {pointExtendedReadonlyRef.X}, Y {pointExtendedReadonlyRef.Y}, Z {pointExtendedReadonlyRef.Z}");


      Console.ReadLine();
    }


    static void UpdateValuesWithoutIn(PointExtended myPoint)
    {
      myPoint.UpdateValues(2, 2, 2);
    }


    static void UpdateValues(in PointExtended myPoint)
    {
      // In protected you from this use case!
      //myPoint.X = 2;

      // In dose not protected you from this use case!
      myPoint.UpdateValues(2, 2, 2);
    }
  }
}
