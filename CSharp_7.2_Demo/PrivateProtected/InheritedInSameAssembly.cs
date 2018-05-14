namespace CSharp_7._2_Demo.PrivateProtected
{
  public class InheritedInSameAssembly : BasePrivateProtected
  {
    public string GetDataFromBase()
    {
      return base.DoAnything();
    }
  }
}