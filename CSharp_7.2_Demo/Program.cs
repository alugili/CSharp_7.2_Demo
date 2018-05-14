using CSharp_7._2_Demo.PrivateProtected;

namespace CSharp_7._2_Demo
{
  class Program
  {
    static void Main(string[] args)
    {
      DigitSeparatorAfterBaseSpecifierDemo.DigitSeparatorAfterBaseSpecifier();

      NonTrailingNamedArguments.FormatLogs("Write Formatted Logs!");

      PrivateProtectedDemo.PrivateProtected();

      ConditionalRefOperatorDemo.ConditionalRefOperator();

      StructsDemo.Structs();

      SpanDemo.Span();

    }
  }
}