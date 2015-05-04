namespace BM.Validations
{
    public static partial class ValidatorHelper
    {
        /// <summary>
        /// Garante que o objeto não seja nulo.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirNaoNulo(object obj, string errorMessage)
        {
            GarantirFalso(() => obj == null, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro objeto seja igual o segundo.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirIgual(object object1, object object2, string errorMessage)
        {
            GarantirVerdadeiro(() => object1.Equals(object2), errorMessage);
        }
        
        /// <summary>
        /// Garante que o primeiro objeto seja diferente o segundo.
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirDiferente(object object1, object object2, string errorMessage)
        {
            GarantirFalso(() => object1.Equals(object2), errorMessage);
        }
    }
}
