using CSharp_7._2_Demo.PrivateProtected;

namespace PrivateProtectedDemo
{
  public class InheritedInOtherAssembly : BasePrivateProtected
  {
    public string GetDataFromBase()
    {
       return base.DoAnything();
    }
  }
}
