namespace CSharp_7._2_Demo.Structs
{

  // All members(properties, fields) must be read-only;
  // I’ll need to initialize the members in the public parameterized constructor; 
  // “this” parameter will be read-only in other place except in constructor.
  // You cannot define “field-like” events;
  readonly struct PointExtendedReadonly
  {
    public int X { get; }
    public int Y { get; }
    public int Z { get; }

    internal PointExtendedReadonly(int x, int y, int z)
    {
      X = x;
      Y = y;
      Z = z;
    }

    internal PointExtendedReadonly(PointExtendedReadonly pointExtendedReadonly)
    {
      this = pointExtendedReadonly;
    }

    internal void UpdateValues(int x, int y, int z)
    {
      // Not possible because it is read only!
      //X = x;
      //Y = y;
      //Z = z;
    }
  }
}