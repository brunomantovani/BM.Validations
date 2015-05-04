using System;
using BM.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validations.Tests.Helpers;

namespace Validations.Tests
{
    [TestClass]
    public sealed class WeekTest
    {
        private const string ErrorMessage = "Error Message";
        private readonly DateTime _thursday = new DateTime(2015, 1, 1);
        private readonly DateTime _saturday = new DateTime(2015, 1, 3);

        [TestMethod]
        public void QuandoEuGarantirDiaDaSemana()
        {
            //arrange
            const DayOfWeek thursday = DayOfWeek.Thursday;
            ApplicationException applicationExceptionDiaDaSemana;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionDiaDaSemana =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDiaDaSemana(_thursday, thursday, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDiaDaSemana(_saturday, thursday, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionDiaDaSemana);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirNaoFimDeSemana()
        {
            //arrange
            ApplicationException applicationExceptionNaoFimDeSemana;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionNaoFimDeSemana =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirNaoFimDeSemana(_thursday, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirNaoFimDeSemana(_saturday, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionNaoFimDeSemana);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirFimDeSemana()
        {
            //arrange
            ApplicationException applicationExceptionFimDeSemana;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionFimDeSemana =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirFimDeSemana(_saturday, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirFimDeSemana(_thursday, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionFimDeSemana);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }
    }
}
