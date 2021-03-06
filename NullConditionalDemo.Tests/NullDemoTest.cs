// <copyright file="NullDemoTest.cs">Copyright ©  2015</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NullConditionalDemo;

namespace NullConditionalDemo.Tests
{
    /// <summary>This class contains parameterized unit tests for NullDemo</summary>
    [PexClass(typeof(NullDemo))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class NullDemoTest
    {
        /// <summary>Test stub for GetIdFromItem(NullDemoData)</summary>
        [PexMethod]
        public int? GetIdFromItemTest([PexAssumeUnderTest]NullDemo target, NullDemoData item)
        {
            int? result = target.GetIdFromItem(item);
            return result;
        }

        /// <summary>Test stub for GetNameFromItem(NullDemoData)</summary>
        [PexMethod]
        public string GetNameFromItemTest([PexAssumeUnderTest]NullDemo target, NullDemoData item)
        {
            string result = target.GetNameFromItem(item);
            return result;
        }

        /// <summary>Test stub for GetFirstNameFromList(IList`1&lt;NullDemoData&gt;)</summary>
        [PexMethod]
        [PexAllowedException(typeof(ArgumentOutOfRangeException))]
        public string GetFirstNameFromListTest([PexAssumeUnderTest]NullDemo target, IList<NullDemoData> list)
        {
            string result = target.GetFirstNameFromList(list);
            return result;
        }

        /// <summary>Test stub for HandleEventWithError()</summary>
        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        public void HandleEventWithErrorTest([PexAssumeUnderTest]NullDemo target)
        {
            target.HandleEventWithError();
        }

        /// <summary>Test stub for HandleEvent()</summary>
        [PexMethod]
        public void HandleEventTest([PexAssumeUnderTest]NullDemo target)
        {
            target.RaiseEvent();
        }

        /// <summary>Test stub for HandleEventWithNullCheck()</summary>
        [PexMethod]
        public void HandleEventWithNullCheckTest([PexAssumeUnderTest]NullDemo target)
        {
            target.RaiseEventWithNullCheck();
        }
    }
}
