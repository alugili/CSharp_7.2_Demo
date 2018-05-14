using System;

namespace CSharp_7._2_Demo
{
  class ConditionalRefOperatorDemo
  {
    internal static void ConditionalRefOperator()
    {
      // Simple Example
      var var1 = 1;
      var var2 = 2;

      ref var refTest = ref (var1 < 2 ? ref var1 : ref var2);

      refTest = 10;

      Console.WriteLine(var1);
      Console.ReadLine();

      // Array Example
      var firstArray = new int[5];
      var firstItemTmp = new int[5];

      firstArray[0] = 1;
      firstItemTmp[0] = 1;

      ref var firstItem = ref (firstArray.Length > 1 ? ref firstArray[0] : ref firstItemTmp[0]);

      Console.WriteLine(firstItem);
      Console.ReadLine();
    }
  }
}