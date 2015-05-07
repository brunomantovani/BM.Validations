using System.Text.RegularExpressions;

namespace BM.Validations
{
    public static partial class ValidatorHelper
    {
        /// <summary>
        /// Garante que o valor foi preenchido.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirValorPreenchido(string value, string errorMessage)
        {
            GarantirFalso(() => string.IsNullOrEmpty(value.Trim()), errorMessage);
        }

        /// <summary>
        /// Garante o tamanho mínimo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirTamanhoMinimo(string value, int minimum, string errorMessage)
        {
            GarantirVerdadeiro(() => value.Length >= minimum, errorMessage);
        }

        /// <summary>
        /// Garante o tamanho máximo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maximum"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirTamanhoMaximo(string value, int maximum, string errorMessage)
        {
            GarantirVerdadeiro(() => value.Length <= maximum, errorMessage);
        }

        /// <summary>
        /// Garante o tamanho mínimo e máximo.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirTamanho(string value, int minimum, int maximum, string errorMessage)
        {
            if (string.IsNullOrEmpty(value.Trim()))
                value = string.Empty;

            var length = value.Length;
            GarantirVerdadeiro(() => length >= minimum && length <= maximum, errorMessage);
        }

        /// <summary>
        /// Garante que o valor esteja de acordo com o regex.
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="value"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirRegex(string value, string pattern, string errorMessage)
        {
            GarantirVerdadeiro(() => Regex.IsMatch(value, pattern), errorMessage);
        }

        /// <summary>
        /// Garante que o valor tenha apenas números
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirNumerico(string value, string errorMessage)
        {
            GarantirRegex(value, "^[0-9]*$", errorMessage);
        }

        /// <summary>
        /// Garante que o valor tenha apenas letras
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirAlfa(string value, string errorMessage)
        {
            GarantirRegex(value, "^[a-zA-Z]*$", errorMessage);
        }

        public static void GarantirAlfaNumerico(string value, string errorMessage)
        {
            GarantirRegex(value, "^[a-zA-Z0-9]*$", errorMessage);
        }
    }
}