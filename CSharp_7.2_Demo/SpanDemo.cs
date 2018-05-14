using System;
using NUnit.Framework;

namespace CSharp_7._2_Demo
{
  class SpanDemo
  {
    public static void Span()
    {
      // source https://msdn.microsoft.com/de-de/magazine/mt814808.aspx

      var arr = new byte[10];
      Span<byte> bytes = arr; // Implicit cast from T[] to Span<T>

      Span<byte> slicedBytes = bytes.Slice(start: 5, length: 2);

      slicedBytes[0] = 42;
      slicedBytes[1] = 43;

      Assert.AreEqual(42, slicedBytes[0]);
      Assert.AreEqual(43, slicedBytes[1]);
      Assert.AreEqual(arr[5], slicedBytes[0]);
      Assert.AreEqual(arr[6], slicedBytes[1]);

      //slicedBytes[2] = 44; // Throws IndexOutOfRangeException

      bytes[2] = 45; // OK
      Assert.AreEqual(arr[2], bytes[2]);
      Assert.AreEqual(45, arr[2]);


      Span<byte> bytes2 = stackalloc byte[2]; // Using C# 7.2 stackalloc support for spans

      bytes2[0] = 42;
      bytes2[1] = 43;

      Assert.AreEqual(42, bytes2[0]);
      Assert.AreEqual(43, bytes2[1]);
      //bytes[2] = 44; // throws IndexOutOfRangeException

      var str = "hello, world";
      var worldString = str.Substring(startIndex: 7, length: 5); // Allocates

      ReadOnlySpan<char> worldSpan = str.AsSpan().Slice(start: 7, length: 5); // No allocation

      Assert.AreEqual('w', worldSpan[0]);
      //worldSpan[0] = 'a'; // Error CS0200: indexer cannot be assigned to
    }
  }
}