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
        public static void GarantirMaiorQue(float value, float comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value > comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número é menor que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMenorQue(float value, float comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value < comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número é maior ou igual que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMaiorOuIgualQue(float value, float comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value >= comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número é menor ou igual que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMenorOuIgualQue(float value, float comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value <= comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o número seja positivo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirPositivo(float value, string errorMessage)
        {
            GarantirVerdadeiro(() => value >= 0, errorMessage);
        }

        /// <summary>
        /// Garante um range de números.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirLimite(float value, float minimum, float maximum, string errorMessage)
        {
            GarantirVerdadeiro(() => value >= minimum && value <= maximum, errorMessage);
        }
    }
}