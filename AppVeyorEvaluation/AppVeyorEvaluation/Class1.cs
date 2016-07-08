using System;
using System.Diagnostics.Contracts;

namespace AppVeyorEvaluation {
  public class Class1 {
    public string Name { get; }

    public Class1(string name) {
      Contract.Requires<ArgumentNullException>(name != null);
      Name = name;
    }
  }
}