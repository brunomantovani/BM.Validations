namespace BM.Validations
{
    public static partial class ValidatorHelper
    {
        /// <summary>
        /// Garante que o número seja par.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirPar(int value, string errorMessage)
        {
            GarantirVerdadeiro(() => value % 2 == 0, errorMessage);
        }

        /// <summary>
        /// Garante que o número seja ímpar.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirImpar(int value, string errorMessage)
        {
            GarantirVerdadeiro(() => value % 2 == 1, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número seja maior que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMaiorQue(int value, int comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value > comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número é menor que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMenorQue(int value, int comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value < comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número é maior ou igual que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMaiorOuIgualQue(int value, int comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value >= comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro número é menor ou igual que o segundo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparer"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMenorOuIgualQue(int value, int comparer, string errorMessage)
        {
            GarantirVerdadeiro(() => value <= comparer, errorMessage);
        }

        /// <summary>
        /// Garante que o número seja positivo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirPositivo(int value, string errorMessage)
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
        public static void GarantirLimite(int value, int minimum, int maximum, string errorMessage)
        {
            GarantirVerdadeiro(() => value >= minimum && value <= maximum, errorMessage);
        }
    }
}