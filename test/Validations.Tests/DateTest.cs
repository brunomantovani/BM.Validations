using System;
using System.Collections.Generic;
using BM.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validations.Tests.Helpers;

namespace Validations.Tests
{
    [TestClass]
    public sealed class DateTest
    {
        private const string ErrorMessage = "Error Message";

        private readonly DateTime _hoje = DateTime.Now;
        private readonly DateTime _amanha = DateTime.Now.AddDays(1);

        [TestMethod]
        public void QuandoGarantirDataMaiorQue()
        {
            //arrange
            ApplicationException resultExceptionMaior;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionMaior =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDataMaiorQue(_amanha, _hoje, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDataMaiorQue(_hoje, _amanha, ErrorMessage));

            //assert
            Assert.IsNull(resultExceptionMaior);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirDataMenorQue()
        {
            //arrange
            ApplicationException resultExceptionMenor;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionMenor =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDataMenorQue(_hoje, _amanha, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDataMenorQue(_amanha, _hoje, ErrorMessage));

            //assert
            Assert.IsNull(resultExceptionMenor);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirDataMaiorOuIgualQue()
        {
            //arrange
            ApplicationException resultExceptionMaior;
            ApplicationException resultExceptionIgual;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionMaior =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDataMaiorOuIgualQue(_amanha, _hoje, ErrorMessage));
            resultExceptionIgual =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDataMaiorOuIgualQue(_hoje, _hoje, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDataMaiorOuIgualQue(_hoje, _amanha, ErrorMessage));


            //assert
            Assert.IsNull(resultExceptionMaior);
            Assert.IsNull(resultExceptionIgual);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirDataMenorOuIgualQue()
        {
            //arrange
            ApplicationException resultExceptionMenor;
            ApplicationException resultExceptionIgual;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionMenor =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDataMenorOuIgualQue(_hoje, _amanha, ErrorMessage));
            resultExceptionIgual =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDataMenorOuIgualQue(_hoje, _hoje, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDataMenorOuIgualQue(_amanha, _hoje, ErrorMessage));

            //assert
            Assert.IsNull(resultExceptionMenor);
            Assert.IsNull(resultExceptionIgual);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirDataIgual()
        {
            //arrange
            ApplicationException resultExceptionIgual;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionIgual =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDataIgual(_hoje, _hoje, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirDataIgual(_hoje, _amanha, ErrorMessage));

            //assert
            Assert.IsNull(resultExceptionIgual);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirQueNaoContemData()
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
                    () => ValidatorHelper.GarantirQueNaoContemData(listOfDates, ontem, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirQueNaoContemData(listOfDates, _hoje, ErrorMessage));

            //assert
            Assert.IsNull(resultExceptionNaoContem);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }
    }
}
