namespace CSharp_7._2_Demo.Structs
{
  struct PointExtended
  {
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public PointExtended(int x, int y, int z)
    {
      X = x;
      Y = y;
      Z = z;
    }

    public PointExtended(PointExtended other)
    {
      this = other;
    }

    public PointExtended Replace(PointExtended other)
    {
      this = other;
      return other;
    }

    public void UpdateValues(int x, int y, int z)
    {
      X = x;
      Y = y;
      Z = z;
    }
  }
}