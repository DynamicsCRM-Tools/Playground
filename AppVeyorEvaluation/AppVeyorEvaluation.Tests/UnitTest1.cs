using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppVeyorEvaluation.Tests {
  [TestClass]
  public class UnitTest1 {
    [TestMethod]
    public void TestMethod1() {
      Class1 class1 = new Class1();

      Assert.IsNull(class1.Name);
    }
  }
}