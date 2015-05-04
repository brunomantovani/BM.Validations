using System;
using BM.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validations.Tests.Helpers;

namespace Validations.Tests
{
    [TestClass]
    public sealed class DecimalTest
    {
        private const string ErrorMessage = "Error Message";
        private const decimal Zero = 0;
        private const decimal Um = 1M;

        [TestMethod]
        public void QuandoEuGarantirMaiorQue()
        {
            //arrange
            ApplicationException applicationExceptionMaior;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMaior =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirMaiorQue(Um, Zero, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirMaiorQue(Zero, Um, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMaior);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirMenorQue()
        {
            //arrange
            ApplicationException applicationExceptionMenor;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMenor =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirMenorQue(Zero, Um, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirMenorQue(Um, Zero, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMenor);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirMaiorOuIgualQue()
        {
            //arrange
            ApplicationException applicationExceptionMaior;
            ApplicationException applicationExceptionIgual;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMaior =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirMaiorOuIgualQue(Um, Zero, ErrorMessage));
            applicationExceptionIgual =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirMaiorOuIgualQue(Zero, Zero, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirMaiorOuIgualQue(Zero, Um, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMaior);
            Assert.IsNull(applicationExceptionIgual);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirMenorOuIgualQue()
        {
            //arrange
            ApplicationException applicationExceptionMaior;
            ApplicationException applicationExceptionIgual;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMaior =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirMenorOuIgualQue(Zero, Um, ErrorMessage));
            applicationExceptionIgual =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirMenorOuIgualQue(Zero, Zero, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirMenorOuIgualQue(Um, Zero, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMaior);
            Assert.IsNull(applicationExceptionIgual);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirPositivo()
        {
            //arrange
            const decimal negativo = -1M;
            ApplicationException applicationExceptionMaior;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMaior =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirPositivo(Um, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirPositivo(negativo, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMaior);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirLimite()
        {
            //arrange
            const decimal value = 1M;
            ApplicationException applicationExceptionMaior;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMaior =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirLimite(value: value, minimum: Zero, maximum: Um, errorMessage: ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                () => ValidatorHelper.GarantirLimite(value: value, minimum: Zero, maximum: Zero, errorMessage: ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMaior);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }
    }
}
