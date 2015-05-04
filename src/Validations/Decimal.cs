namespace BM.Validations
{
    public static partial class ValidatorHelper
    {
        /// <summary>
        /// Garante que o primeiro número seja maior que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMaiorQue(decimal value, decimal comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value > comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número é menor que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMenorQue(decimal value, decimal comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value < comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número é maior ou igual que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMaiorOuIgualQue(decimal value, decimal comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value >= comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número é menor ou igual que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMenorOuIgualQue(decimal value, decimal comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value <= comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o número seja positivo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirPositivo(decimal value, string errorMessage)
        {
            GarantirVerdadeiro(() => value >= decimal.Zero, errorMessage);
        }

        /// <summary>
        /// Garante um range de números.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirLimite(decimal value, decimal minimum, decimal maximum, string errorMessage)
        {
            GarantirVerdadeiro(() => value >= minimum && value <= maximum, errorMessage);
        }
    }
}