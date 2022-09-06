namespace MainProgram.Tests; 

public sealed class A {
  public void Deconstruct(out int a, out int b) {
    a = 1;
    b = 2;
  }
}

public delegate bool Predicate<in T>(T obj);

public sealed class B {
  public void Deconstruct(out int a, out int b) {
    a = 3;
    b = 4;
  }
}

public static class PatternMatching {
  public static void Run() {
    var (a, b) = new A();
    /*
    var obj = new A() as object;
    var (x,y) = obj switch {
      A (a,b) => (a,b),
      B (a,b) => (a,b),
    _ => (0,0),
    };
    */
    Console.WriteLine($"{a},{b}");
  }
}