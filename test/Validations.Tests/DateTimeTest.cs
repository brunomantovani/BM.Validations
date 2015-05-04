using System;
using System.Collections.Generic;
using BM.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validations.Tests.Helpers;

namespace Validations.Tests
{
    [TestClass]
    public sealed class DateTimeTest
    {
        private const string ErrorMessage = "Error Message";

        private readonly DateTime _hoje = DateTime.Now;
        private readonly DateTime _amanha = DateTime.Now.AddDays(1);

        [TestMethod]
        public void QuandoEuGarantirMaiorQue()
        {
            //arrange
            ApplicationException resultExceptionMaior;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionMaior =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirMaiorQue(_amanha, _hoje, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirMaiorQue(_hoje, _amanha, ErrorMessage));

            //assert
            Assert.IsNull(resultExceptionMaior);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirMenorQue()
        {
            //arrange
            ApplicationException resultExceptionMenor;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionMenor =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirMenorQue(_hoje, _amanha, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirMenorQue(_amanha, _hoje, ErrorMessage));

            //assert
            Assert.IsNull(resultExceptionMenor);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirMaiorOuIgualQue()
        {
            //arrange
            ApplicationException resultExceptionMaior;
            ApplicationException resultExceptionIgual;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionMaior =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirMaiorOuIgualQue(_amanha, _hoje, ErrorMessage));
            resultExceptionIgual =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirMaiorOuIgualQue(_hoje, _hoje, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirMaiorOuIgualQue(_hoje, _amanha, ErrorMessage));


            //assert
            Assert.IsNull(resultExceptionMaior);
            Assert.IsNull(resultExceptionIgual);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirMenorOuIgualQue()
        {
            //arrange
            ApplicationException resultExceptionMenor;
            ApplicationException resultExceptionIgual;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionMenor =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirMenorOuIgualQue(_hoje, _amanha, ErrorMessage));
            resultExceptionIgual =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirMenorOuIgualQue(_hoje, _hoje, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirMenorOuIgualQue(_amanha, _hoje, ErrorMessage));

            //assert
            Assert.IsNull(resultExceptionMenor);
            Assert.IsNull(resultExceptionIgual);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirIgual()
        {
            //arrange
            ApplicationException resultExceptionIgual;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionIgual =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirIgual(_hoje, _hoje, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirIgual(_hoje, _amanha, ErrorMessage));

            //assert
            Assert.IsNull(resultExceptionIgual);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirQueNaoContem()
        {
            //arrange
            DateTime ontem = _hoje.AddDays(-1);
            IList<DateTime> listOfDates = new List<DateTime>()
            {
                _hoje,
                _amanha
            };
            ApplicationException resultExceptionNaoContem;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionNaoContem =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirQueNaoContem(listOfDates, ontem, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirQueNaoContem(listOfDates, _hoje, ErrorMessage));

            //assert
            Assert.IsNull(resultExceptionNaoContem);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }
    }
}
