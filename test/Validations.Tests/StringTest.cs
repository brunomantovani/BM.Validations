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

        [TestMethod]
        public void QuandoEuGarantirNumerico()
        {
            //arrange
            const string valueOk = "123";
            const string valueError = "A123";
            ApplicationException applicationExceptionNumerico;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionNumerico =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirNumerico(valueOk, ErrorMessage));

            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirNumerico(valueError, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionNumerico);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirAlfa()
        {
            //arrange
            const string valueOk = "AbCd";
            const string valueError = "AbCb1";
            ApplicationException applicationExceptionAlfa;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionAlfa =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirAlfa(valueOk, ErrorMessage));

            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirAlfa(valueError, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionAlfa);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirAlfaNumerico()
        {
            //arrange
            const string valueOk = "A1B2";
            const string valueError = "A1_B2";
            ApplicationException applicationExceptionAlfaNumerico;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionAlfaNumerico =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirAlfaNumerico(valueOk, ErrorMessage));

            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirAlfaNumerico(valueError, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionAlfaNumerico);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

    }
}
