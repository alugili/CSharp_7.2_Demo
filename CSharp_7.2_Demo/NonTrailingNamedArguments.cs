using System;

namespace CSharp_7._2_Demo
{
  class NonTrailingNamedArguments
  {
    internal static void FormatLogs(string text, bool bold = false, bool centered = false)
    {
      Console.WriteLine($"text={text}, bold={bold}, centered={centered}");
    }
  }
}