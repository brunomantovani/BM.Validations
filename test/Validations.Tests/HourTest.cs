using System;
using BM.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validations.Tests.Helpers;

namespace Validations.Tests
{
    [TestClass]
    public sealed class HourTest
    {
        private const int OneHour = 1;
        private const int TwoHours = 2;
        private const string ErrorMessage = "Error Message";


        [TestMethod]
        public void QuandoEuGarantirHoraMaiorQue()
        {
            //arrange
            ApplicationException applicationExceptionMaior;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMaior =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirHoraMaiorQue(TwoHours, OneHour, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirHoraMaiorQue(OneHour, TwoHours, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMaior);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirHoraMenorQue()
        {
            //arrange
            ApplicationException applicationExceptionMenor;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMenor =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirHoraMenorQue(OneHour, TwoHours,ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirHoraMenorQue(TwoHours, OneHour, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMenor);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirHoraMaiorOuIgualQue()
        {
            //arrange
            ApplicationException applicationExceptionMaior;
            ApplicationException applicationExceptionIgual;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMaior =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirHoraMaiorOuIgualQue(TwoHours, OneHour, ErrorMessage));
            applicationExceptionIgual =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirHoraMaiorOuIgualQue(OneHour, OneHour, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirHoraMaiorOuIgualQue(OneHour, TwoHours, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMaior);
            Assert.IsNull(applicationExceptionIgual);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirHoraMenorOuIgualQue()
        {
            //arrange
            ApplicationException applicationExceptionMenor;
            ApplicationException applicationExceptionIgual;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionMenor =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirHoraMenorOuIgualQue(OneHour, TwoHours, ErrorMessage));
            applicationExceptionIgual =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirHoraMenorOuIgualQue(OneHour, OneHour, ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirHoraMenorOuIgualQue(TwoHours, OneHour, ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionMenor);
            Assert.IsNull(applicationExceptionIgual);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirHoraLimite()
        {
            //arrange
            const int limite = 2;
            const int tenHours = 10;
            ApplicationException applicationExceptionLimite;
            ApplicationException applicationExceptionErro;

            //act
            applicationExceptionLimite =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirHoraLimite(
                        startHour: OneHour, endHour: TwoHours, totalHoursAllowed: limite, errorMessage: ErrorMessage));
            applicationExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirHoraLimite(
                        startHour: OneHour, endHour: tenHours, totalHoursAllowed: limite, errorMessage: ErrorMessage));

            //assert
            Assert.IsNull(applicationExceptionLimite);
            AssertHelper.IsValidException(applicationExceptionErro, ErrorMessage);
        }
    }
}
