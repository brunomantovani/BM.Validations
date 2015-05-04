using System;

namespace BM.Validations
{
    public static partial class ValidatorHelper
    {
        /// <summary>
        /// Garante que o valor seja falso.
        /// </summary>
        /// <param name="boolValue"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirFalso(bool boolValue, string errorMessage)
        {
            GarantirFalso(() => boolValue, errorMessage);
        }

        /// <summary>
        /// Garante que o valor seja falso.
        /// </summary>
        /// <param name="boolFunc"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirFalso(Func<bool> boolFunc, string errorMessage)
        {
            if (boolFunc.Invoke())
                throw Factories.ExceptionFactory.Create(errorMessage);
        }

        /// <summary>
        /// Garante que o valor seja verdadeiro.
        /// </summary>
        /// <param name="boolValue"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirVerdadeiro(bool boolValue, string errorMessage)
        {
            GarantirVerdadeiro(() => boolValue, errorMessage);
        }

        /// <summary>
        /// Garante que o valor seja verdadeiro.
        /// </summary>
        /// <param name="boolFunc"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirVerdadeiro(Func<bool> boolFunc, string errorMessage)
        {
            if (!boolFunc.Invoke())
                throw Factories.ExceptionFactory.Create(errorMessage);
        }
    }
}
