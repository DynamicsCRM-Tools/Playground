using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppVeyorEvaluation.Tests {
  [TestClass]
  public class UnitTest1 {
    [TestMethod]
    public void Class1DependsOnName() {
      string expectedName = "name1";

      Class1 class1 = new Class1(expectedName);

      Assert.AreEqual(expectedName, class1.Name);
    }

    [TestMethod, ExpectedException(typeof(ArgumentNullException))]
    public void NameMustBeAvailable() {
      Class1 class1 = new Class1(null);

      Assert.Fail();
    }
  }
}