using System.Collections.Generic;
using System.Linq;

namespace BM.Validations
{
    public static partial class ValidatorHelper
    {
        /// <summary>
        /// Garante que a lista não contém o item.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="t"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirQueNaoContem<T>(IList<T> list, T t, string errorMessage)
        {
            if (list == null) return;
            GarantirVerdadeiro(() => !list.Any(item => item.Equals(t)), errorMessage);
        }

        /// <summary>
        /// Garante que a lista contém o item.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="t"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirQueContem<T>(IList<T> list, T t, string errorMessage)
        {
            if (list == null) return;
            GarantirVerdadeiro(() => list.Any(item => item.Equals(t)), errorMessage);
        }
    }
}
