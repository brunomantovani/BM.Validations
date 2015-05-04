using System.Collections.Generic;
using System.Linq;

namespace BM.Validations
{
    public static partial class ValidatorHelper
    {
        /// <summary>
        /// Garante que a coleção não contém o item.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="t"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirQueNaoContem<T>(ICollection<T> collection, T t, string errorMessage)
        {
            if (collection == null) return;
            GarantirVerdadeiro(() => !collection.Any(item => item.Equals(t)), errorMessage);
        }

        /// <summary>
        /// Garante que a coleção contém o item.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="t"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirQueContem<T>(ICollection<T> collection, T t, string errorMessage)
        {
            if (collection == null) return;
            GarantirVerdadeiro(() => collection.Any(item => item.Equals(t)), errorMessage);
        }
    }
}
