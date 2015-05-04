using System;
using BM.Validations.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validations.Tests.Arranges;

namespace Validations.Tests.Factories
{
    [TestClass]
    public sealed class ExceptionFactoryTest
    {
        private const string ErrorMessage = "Error Message";
        private const string InnerErrorMessage = "Inner Error Message";

        [TestMethod]
        public void QuandoEuFabricarUmaException()
        {
            //arrange
            Type exceptionType = typeof(CustomException);
            CustomException resultException;

            //act
            resultException =
                ExceptionFactory
                    .Create<CustomException>(ErrorMessage);

            //assert
            Assert.IsNotNull(resultException);
            Assert.AreEqual(resultException.GetType(), exceptionType);
            Assert.AreEqual(resultException.Message, ErrorMessage);

            Assert.IsNull(resultException.InnerException);
        }

        [TestMethod]
        public void QuandoEuFabricarUmaExceptionComInnerException()
        {
            //arrange
            CustomException innerCustomException = new CustomException(InnerErrorMessage);
            Type exceptionType = typeof(CustomException);
            CustomException resultException;

            //act
            resultException =
                ExceptionFactory
                    .Create<CustomException>(ErrorMessage, innerCustomException);

            //assert
            Assert.IsNotNull(resultException);
            Assert.AreEqual(resultException.GetType(), exceptionType);
            Assert.AreEqual(resultException.Message, ErrorMessage);

            Assert.IsNotNull(resultException.InnerException);
            Assert.AreEqual(resultException.InnerException, innerCustomException);
            Assert.AreEqual(resultException.InnerException.Message, InnerErrorMessage);
        }
    }
}
