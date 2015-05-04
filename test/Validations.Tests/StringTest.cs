using System;
using BM.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validations.Tests.Helpers;

namespace Validations.Tests
{
    [TestClass]
    public sealed class StringTest
    {
        private const string ErrorMessage = "Error Message";
        private const string ValorPreenchido = "Valor";
        private readonly string _empty = string.Empty;
        private const int Three = 3;
        private const int Five = 5;
        private const int Ten = 10;

        [TestMethod]
        public void QuandoEuGarantirValorPreenchido()
        {
            //arrange
            ApplicationException applicationExceptionPreenchido;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionPreenchido =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirValorPreenchido(ValorPreenchido, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirValorPreenchido(_empty, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionPreenchido);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirTamanhoMinimo()
        {
            //arrange
            //const string 
            ApplicationException applicationExceptionMinimo;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMinimo =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTamanhoMinimo(ValorPreenchido, Three, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTamanhoMinimo(ValorPreenchido, Ten, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMinimo);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirTamanhoMaximo()
        {
            //arrange
            ApplicationException applicationExceptionMaximo;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMaximo =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTamanhoMaximo(ValorPreenchido, Five, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTamanhoMaximo(ValorPreenchido, Three, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMaximo);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirTamanho()
        {
            //arrange
            ApplicationException applicationExceptionTamanho;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionTamanho =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTamanho(ValorPreenchido, Three, Five, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTamanho(ValorPreenchido, Ten, Ten, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionTamanho);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirRegex()
        {
            //arrange
            const string pattern = "^Valor$";
            const string value = "Value";
            ApplicationException applicationExceptionTamanho;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionTamanho =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirRegex(ValorPreenchido, pattern, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirRegex(value, pattern, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionTamanho);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

    }
}
