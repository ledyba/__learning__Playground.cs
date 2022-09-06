using System.Buffers;

namespace MainProgram.Tests; 

public static class Span {
  public static void Run() {
    Span<int> span = stackalloc int[] { 0, 1, 2 };
    var chr = "123".AsSpan()[1..];
    Console.WriteLine(int.Parse(chr));
  }
}