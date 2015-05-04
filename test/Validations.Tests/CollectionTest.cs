using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BM.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validations.Tests.Helpers;

namespace Validations.Tests
{
    [TestClass]
    public sealed class CollectionTest
    {
        private const string ErrorMessage = "Error Message";

        [TestMethod]
        public void GarantirQueNaoContem()
        {
            //arrange
            const string contem1 = "1";
            const string contem2 = "2";
            const string naoContem = "3";
            ICollection<string> collectionOfStrings = new Collection<string>()
            {
                contem1,
                contem2
            };

            ApplicationException resultExceptionNaoContem;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionNaoContem =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirQueNaoContem(collectionOfStrings, naoContem, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirQueNaoContem(collectionOfStrings, contem1, ErrorMessage));

            //assert
            Assert.IsNull(resultExceptionNaoContem);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }

        [TestMethod]
        public void GarantirQueContem()
        {
            //arrange
            const string contem1 = "1";
            const string contem2 = "2";
            const string naoContem = "3";
            ICollection<string> collectionOfStrings = new Collection<string>()
            {
                contem1,
                contem2
            };

            ApplicationException resultExceptionContem;
            ApplicationException resultExceptionErro;

            //act
            resultExceptionContem =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirQueContem(collectionOfStrings, contem1, ErrorMessage));
            resultExceptionErro =
                ActHelper.GetApplicationException(
                    () => ValidatorHelper.GarantirQueContem(collectionOfStrings, naoContem, ErrorMessage));

            //assert
            Assert.IsNull(resultExceptionContem);
            AssertHelper.IsValidException(resultExceptionErro, ErrorMessage);
        }
    }
}
