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
        public static void GarantirMaiorQue(double value, double comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value > comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número é menor que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMenorQue(double value, double comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value < comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número é maior ou igual que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMaiorOuIgualQue(double value, double comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value >= comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número é menor ou igual que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMenorOuIgualQue(double value, double comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value <= comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o número seja positivo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirPositivo(double value, string errorMessage)
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
        public static void GarantirLimite(double value, double minimum, double maximum, string errorMessage)
        {
            GarantirVerdadeiro(() => value >= minimum && value <= maximum, errorMessage);
        }
    }
}