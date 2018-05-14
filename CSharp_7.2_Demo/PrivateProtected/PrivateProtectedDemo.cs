namespace CSharp_7._2_Demo.PrivateProtected
{
  class PrivateProtectedDemo
  {
    internal static void PrivateProtected()
    {
      var baseClass = new BasePrivateProtected();
       baseClass.DoAnything();

      var privateProtecedDemo = new InheritedInSameAssembly();
      privateProtecedDemo.GetDataFromBase();
    }
  }
}