namespace MainProgram.Tests;

public static class Function {
  public static void Run() {
//    Console.WriteLine($"{Select(DummyF1).ToString()}");

//    Console.WriteLine($"{Select((new DummyFunction()).Predicate).ToString()}");
    var f = (new DummyFunction()).Predicate;
    Console.WriteLine($"{Select(f)}");
    var g = (Judge) Delegate.CreateDelegate(typeof(Judge), new DummyFunction(), "Predicate");
    Console.WriteLine($"{Select(g)}");
  }

  private static bool DummyF1(int i) {
    return true;
  }

  private static string Select(Func<int, bool> f) {
    return "a";
  }

  private static string Select(Predicate<int> f) {
    return "b";
  }
  private static string Select(Judge f) {
    return "c";
  }

}

public class DummyFunction {
  private static bool B = false;
  public bool Predicate(int i) {
    return B;
  }
}

public delegate bool Judge(int i);
