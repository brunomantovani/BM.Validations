using System;
using BM.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validations.Tests.Helpers;

namespace Validations.Tests
{
    [TestClass]
    public sealed class BooleanTest
    {
        private const string ErrorMessage = "Error Message";

        [TestMethod]
        public void QuandoEuGarantirFalso()
        {
            //arrange
            const bool @false = true;

            ApplicationException resultException;

            //act
            resultException = 
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirFalso(@false, ErrorMessage));
            
            //assert
            AssertHelper.IsValidException(resultException, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirFalsoComDelegate()
        {
            //arrange
            const bool @false = true;

            ApplicationException resultException;

            //act
            resultException =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirFalso(() => @false, ErrorMessage));

            //assert
            AssertHelper.IsValidException(resultException, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirVerdadeiro()
        {
            //arrange
            const bool @true = false;

            ApplicationException resultException;

            //act
            resultException = 
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirVerdadeiro(@true, ErrorMessage));
            
            //assert
            AssertHelper.IsValidException(resultException, ErrorMessage);
        }

        [TestMethod]
        public void QuandoEuGarantirVerdadeiroComDelegate()
        {
            //arrange
            const bool @true = false;

            ApplicationException resultException;

            //act
            resultException =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirVerdadeiro(() => @true, ErrorMessage));

            //assert
            AssertHelper.IsValidException(resultException, ErrorMessage);
        }
    }
}