using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullConditionalDemo;
// <copyright file="NullDemoTest.GetIdFromItemTest.g.cs">Copyright ©  2015</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace NullConditionalDemo.Tests
{
    public partial class NullDemoTest
    {

[TestMethod]
[PexGeneratedBy(typeof(NullDemoTest))]
public void GetIdFromItemTest610()
{
    NullDemo nullDemo;
    int? nulli;
    nullDemo = NullDemoFactory.Create();
    nulli = this.GetIdFromItemTest(nullDemo, (NullDemoData)null);
    Assert.IsNotNull((object)nulli);
    Assert.AreEqual<int>(0, (int)((object)nulli));
    Assert.IsNotNull((object)nullDemo);
}

[TestMethod]
[PexGeneratedBy(typeof(NullDemoTest))]
public void GetIdFromItemTest350()
{
    NullDemo nullDemo;
    int? nulli;
    nullDemo = NullDemoFactory.Create();
    NullDemoData s0 = new NullDemoData();
    s0.Id = 0;
    s0.Name = (string)null;
    nulli = this.GetIdFromItemTest(nullDemo, s0);
    Assert.IsNotNull((object)nulli);
    Assert.AreEqual<int>(0, (int)((object)nulli));
    Assert.IsNotNull((object)nullDemo);
}
    }
}
