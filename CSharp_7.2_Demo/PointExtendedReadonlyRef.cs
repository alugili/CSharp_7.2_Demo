using System.Runtime.InteropServices;
// ref struct is the stack-only value type that:
// Represents a sequential struct layout;
// Can be used stack-only.i.e.method parameters and local variables;
// Cannot be static or instance members of a class or normal struct;
// Cannot be method parameter of async methods or lambda expressions;
// Cannot be dynamic binding, boxing, unboxing, wrapping or converting.
// ref struct is also called embedded reference.


namespace CSharp_7._2_Demo
{
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
}

// Example for a sequential struct!
[StructLayout(LayoutKind.Sequential)]
public struct Point
{
  public int x;
  public int y;
}

[StructLayout(LayoutKind.Explicit)]
public struct Rect
{
  [FieldOffset(0)] public int left;
  [FieldOffset(4)] public int top;
  [FieldOffset(8)] public int right;
  [FieldOffset(12)] public int bottom;
}