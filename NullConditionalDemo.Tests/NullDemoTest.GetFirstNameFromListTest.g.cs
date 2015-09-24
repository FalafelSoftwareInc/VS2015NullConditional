using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NullConditionalDemo;
// <copyright file="NullDemoTest.GetFirstNameFromListTest.g.cs">Copyright ©  2015</copyright>
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
public void GetFirstNameFromListTest77401()
{
    NullDemo nullDemo;
    string s;
    nullDemo = NullDemoFactory.Create();
    s = this.GetFirstNameFromListTest(nullDemo, (IList<NullDemoData>)null);
    Assert.AreEqual<string>("No Name", s);
    Assert.IsNotNull((object)nullDemo);
}

[TestMethod]
[PexGeneratedBy(typeof(NullDemoTest))]
public void GetFirstNameFromListTest15001()
{
    NullDemo nullDemo;
    string s;
    nullDemo = NullDemoFactory.Create();
    NullDemoData[] nullDemoDatas = new NullDemoData[1];
    s = this.GetFirstNameFromListTest(nullDemo, (IList<NullDemoData>)nullDemoDatas);
    Assert.AreEqual<string>("No Name", s);
    Assert.IsNotNull((object)nullDemo);
}

[TestMethod]
[PexGeneratedBy(typeof(NullDemoTest))]
public void GetFirstNameFromListTest75501()
{
    NullDemo nullDemo;
    string s;
    nullDemo = NullDemoFactory.Create();
    NullDemoData[] nullDemoDatas = new NullDemoData[1];
    NullDemoData s0 = new NullDemoData();
    s0.Id = 0;
    s0.Name = (string)null;
    nullDemoDatas[0] = s0;
    s = this.GetFirstNameFromListTest(nullDemo, (IList<NullDemoData>)nullDemoDatas);
    Assert.AreEqual<string>("No Name", s);
    Assert.IsNotNull((object)nullDemo);
}

[TestMethod]
[PexGeneratedBy(typeof(NullDemoTest))]
public void GetFirstNameFromListTest57701()
{
    NullDemo nullDemo;
    string s;
    nullDemo = NullDemoFactory.Create();
    NullDemoData[] nullDemoDatas = new NullDemoData[1];
    NullDemoData s0 = new NullDemoData();
    s0.Id = 0;
    s0.Name = "";
    nullDemoDatas[0] = s0;
    s = this.GetFirstNameFromListTest(nullDemo, (IList<NullDemoData>)nullDemoDatas);
    Assert.AreEqual<string>("", s);
    Assert.IsNotNull((object)nullDemo);
}

[TestMethod]
[PexGeneratedBy(typeof(NullDemoTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void GetFirstNameFromListTestThrowsArgumentOutOfRangeException93201()
{
    NullDemo nullDemo;
    string s;
    nullDemo = NullDemoFactory.Create();
    NullDemoData[] nullDemoDatas = new NullDemoData[0];
    s = this.GetFirstNameFromListTest(nullDemo, (IList<NullDemoData>)nullDemoDatas);
}
    }
}
