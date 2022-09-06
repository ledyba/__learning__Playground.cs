namespace MainProgram.Tests;

public class Base {
  private protected int pp_ = 0;
}

public class Derived : Base {
  public Derived() {
  }
}

public abstract class Curious<T>
  where T : Curious<T> {
  public abstract void Run();
}

public class CuriousDerived : Curious<CuriousDerived> {
  public override void Run() {
    
  }
}

public static class DeriveTest {
  public static void Run() {
    var d = new Derived();
  }
}