using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Validations.Tests.Helpers
{
    public static class AssertHelper
    {
        internal static void IsValidException(ApplicationException resultException, string errroMessage)
        {
            Assert.IsNotNull(resultException);
            Assert.AreEqual(resultException.Message, errroMessage);
            Assert.IsNull(resultException.InnerException);
        }
    }
}
