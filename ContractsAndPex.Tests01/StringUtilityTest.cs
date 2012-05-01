// <copyright file="StringUtilityTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>

using System;
using ContractsAndPex;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContractsAndPex
{
    [TestClass]
    [PexClass(typeof(StringUtility))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StringUtilityTest
    {
        [PexMethod]
        public string SubString(
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
