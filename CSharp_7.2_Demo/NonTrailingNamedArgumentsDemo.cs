using System;

namespace CSharp_7._2_Demo
{
  class NonTrailingNamedArgumentsDemo
  {
    // Method call
    public static void NonTrailingNamedArguments()
    {
      // Method call
      FormatLogs("Hello world", centered: true);

      FormatLogs("Hello world", true, true); // Difficult to understand
      FormatLogs("Hello world", bold: true, centered: true); // Better
      FormatLogs("Hello world", centered: true, bold: true); // Different order
      FormatLogs("Hello world", bold: true, true); // Mixed
    }

    internal static void FormatLogs(string text, bool bold = false, bool centered = false)
    {
      Console.WriteLine($"text={text}, bold={bold}, centered={centered}");
    }
  }
}