// <copyright file="StringUtilityTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using ContractsAndPex;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContractsAndPex
{
    /// <summary>This class contains parameterized unit tests for StringUtility</summary>
    [PexClass(typeof(StringUtility))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class StringUtilityTest
    {
        /// <summary>Test stub for SubString(String, Int32, Int32)</summary>
        [PexMethod]
        internal string SubString(
            [PexAssumeUnderTest]StringUtility target01,
            string target,
            int start,
            int end
        )
        {
            string result = target01.SubString(target, start, end);
            return result;
            // TODO: add assertions to method StringUtilityTest.SubString(StringUtility, String, Int32, Int32)
        }
    }
}
