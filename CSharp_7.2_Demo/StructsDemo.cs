using System;

namespace CSharp_7._2_Demo
{
  class StructsDemo
  {
    internal static void Structs()
    {
      // Simple examples
      var myPoint = new PointExtended { X = 1, Y = 1, Z = 1 };
      Console.WriteLine($"Before: X {myPoint.X}, Y {myPoint.Y}, Z {myPoint.Z}");

      // Classic pass the struct by blue --> copy value type and slow and memory expensive!
      UpdateValues(myPoint);

      // In pass the struct by reference --> no-value-copy fast!
      UpdateValuesWithoutIn(myPoint);

      Console.WriteLine($"After: X {myPoint.X}, Y {myPoint.Y}, Z {myPoint.Z}");


      var pointExtendedReadonly = new PointExtendedReadonly(1, 1, 1);
      Console.WriteLine($"ReadOnly: X {pointExtendedReadonly.X}, Y {pointExtendedReadonly.Y}, Z {pointExtendedReadonly.Z}");
      UpdateValuesReadOnly(pointExtendedReadonly);

      var pointExtendedReadonlyRef = new PointExtendedReadonlyRef(1, 1, 1);
      Console.WriteLine($"ReadOnlyRef: X {pointExtendedReadonlyRef.X}, Y {pointExtendedReadonlyRef.Y}, Z {pointExtendedReadonlyRef.Z}");


      PointExtended firstPoint = new PointExtended(1, 1, 1);
      PointExtended otherPoint = firstPoint;

      otherPoint.X = 2;

      // The firstPoint.X still 1 the value type is always copied! 
      Console.WriteLine(firstPoint.X);
      Console.ReadLine();

      // I have replaced the firstPoint with the otherPoint! 
      otherPoint = firstPoint.Replace(otherPoint);

      Console.WriteLine(firstPoint.X);
      Console.ReadLine();

      var arEquals = firstPoint.Equals(otherPoint); // true.
      arEquals.ToString();

      Console.WriteLine(arEquals);
      Console.ReadLine();

      // Bug by overload is fixed!
      var buBugInOverlodaResolutiongIn = new BugInOverlodaResolution();
      var x = 5;

      buBugInOverlodaResolutiongIn.M(in x);
      //bugIn.M(y); // Working with version  VS 15.6 preview 2  or a later version!
    }

    static void UpdateValuesWithoutIn(PointExtended myPoint)
    {
      myPoint.UpdateValues(2, 2, 2);
    }

    static void UpdateValuesReadOnly(PointExtendedReadonly myPoint)
    {
      // !!!! Toto This cannot be work! The passed struct is a read-only! !!!!! The Code will not change the values!
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

  //// https://github.com/dotnet/roslyn/pull/23122 Silent Fix in VS 2017. 15.6 preview 2  
  public class BugInOverlodaResolution
  {
    public void M(int x) { }

    public void M(in int x) { }
  }
}