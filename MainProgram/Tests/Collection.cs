using System.Collections;

namespace MainProgram.Tests; 

public static class CollectionTest {
  public static void Run() {
    var lst = new Sample {
      {1, 2},
      {1, 2},
      {1, 2},
      {1, 2},
    };
  }
}

internal static class Extend {
  public static void Add(this Sample sample, string s) {
    Console.WriteLine(s);
  }

  public static void Add(this Sample sample, int a, int b) {
    Console.WriteLine("pair");
  }
}

internal struct Pair<T1, T2> {
  private T1 a_;
  private T2 b_;

  public Pair(T1 a, T2 b) {
    a_ = a;
    b_ = b;
  }
}

internal class Sample : IEnumerable<int> {
  public void Test() {
    var str = new Sample {
      "a",
      "b",
      "c",
    };
  }

  public IEnumerator<int> GetEnumerator() {
    return new NullEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator() {
    return GetEnumerator();
  }
}

internal class NullEnumerator: IEnumerator<int> {
  public bool MoveNext() {
    return true;
  }

  public void Reset() {
  }

  public int Current { get; }

  object IEnumerator.Current => Current;

  public void Dispose() {
  }
}
