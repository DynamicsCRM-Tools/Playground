using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
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

    [TestMethod]
    public void Powershell() {
      PowerShell ps = PowerShell.Create();

      Collection<PSObject> result = ps.AddScript("$PSVersionTable;").Invoke();
      foreach (Hashtable hashtable in result.Select(p => p.BaseObject).Cast<Hashtable>()) {
        foreach (var key in hashtable.Keys) {
          Console.WriteLine("{0}: {1}", key, hashtable[key]);
        }
      }

      Assert.IsTrue(result.Any());
    }
  }
}