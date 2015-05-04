using System;
using BM.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validations.Tests.Helpers;

namespace Validations.Tests
{
    [TestClass]
    public sealed class ObjectTest
    {
        private object _object;
        private const object ObjectNull = null;
        private const string ErrorMessage = "Error Message";

        [TestInitialize]
        public void Initialize()
        {
            _object = new object();
        }

        [TestMethod]
        public void QuandoEuGarantirNaoNulo()
        {
            //arrange
            ApplicationException applicationExceptionNaoNulo;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionNaoNulo =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirNaoNulo(_object, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirNaoNulo(ObjectNull, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionNaoNulo);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirIgual()
        {
            //arrange
            object object2 = new object();
            ApplicationException applicationExceptionIgual;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionIgual =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirIgual(_object, _object, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirIgual(_object, object2, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionIgual);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirDiferente()
        {
            //arrange
            object object2 = new object();
            ApplicationException applicationExceptionDiferente;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionDiferente =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDiferente(_object, object2, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDiferente(_object, _object, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionDiferente);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }
    }
}
