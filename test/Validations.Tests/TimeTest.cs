using System;
using BM.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validations.Tests.Helpers;

namespace Validations.Tests
{
    [TestClass]
    public sealed class TimeTest
    {
        private const string ErrorMessage = "Error Message";

        private readonly DateTime _fiveHours = new DateTime(1900, 1, 1, 5, 0, 0);
        private readonly DateTime _fiveHoursAndAHalf = new DateTime(1900, 1, 1, 5, 30, 0);

        [TestMethod]
        public void QuandoEuGarantirTimeMaiorQue()
        {
            //arrange
            ApplicationException applicationExceptionMaior;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMaior =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTimeMaiorQue(_fiveHoursAndAHalf, _fiveHours, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirMaiorQue(_fiveHours, _fiveHoursAndAHalf, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMaior);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);

        }

        [TestMethod]
        public void QuandoEuGarantirTimeMenorQue()
        {
            //arrange
            ApplicationException applicationExceptionMenor;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMenor =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTimeMenorQue(_fiveHours, _fiveHoursAndAHalf, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTimeMenorQue(_fiveHoursAndAHalf, _fiveHours, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMenor);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirTimeMaiorOuIgualQue()
        {
            //arrange
            ApplicationException applicationExceptionMaior;
            ApplicationException applicationExceptionIgual;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMaior =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTimeMaiorOuIgualQue(_fiveHoursAndAHalf, _fiveHours, ErrorMessage));
            applicationExceptionIgual =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTimeMaiorOuIgualQue(_fiveHoursAndAHalf, _fiveHoursAndAHalf, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTimeMaiorOuIgualQue(_fiveHours, _fiveHoursAndAHalf, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMaior);
            Assert.IsNull(applicationExceptionIgual);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirTimeMenorOuIgualQue()
        {
            //arrange
            ApplicationException applicationExceptionMenor;
            ApplicationException applicationExceptionIgual;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMenor =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTimeMenorOuIgualQue(_fiveHours, _fiveHoursAndAHalf, ErrorMessage));
            applicationExceptionIgual =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTimeMenorOuIgualQue(_fiveHoursAndAHalf, _fiveHoursAndAHalf, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTimeMenorOuIgualQue(_fiveHoursAndAHalf, _fiveHours, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMenor);
            Assert.IsNull(applicationExceptionIgual);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirTimeIgual()
        {
            //arrange
            ApplicationException applicationExceptionIgual;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionIgual =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTimeIgual(_fiveHoursAndAHalf, _fiveHoursAndAHalf, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirTimeIgual(_fiveHours, _fiveHoursAndAHalf, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionIgual);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }
    }
}
