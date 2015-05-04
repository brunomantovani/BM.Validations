namespace BM.Validations
{
    public static partial class ValidatorHelper
    {
        /// <summary>
        /// Garante que a primeira hora é maior que a segunda.
        /// </summary>
        /// <param name="startHour"></param>
        /// <param name="endHour"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirHoraMaiorQue(int startHour, int endHour, string errorMessage)
        {
            GarantirVerdadeiro(() => startHour > endHour, errorMessage);
        }

        /// <summary>
        /// Garante que a primeira hora é menor que a segunda.
        /// </summary>
        /// <param name="startHour"></param>
        /// <param name="endHour"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirHoraMenorQue(int startHour, int endHour, string errorMessage)
        {
            GarantirVerdadeiro(() => startHour < endHour, errorMessage);
        }

        /// <summary>
        /// Garante que a primeira hora é maior ou igual que a segunda.
        /// </summary>
        /// <param name="startHour"></param>
        /// <param name="endHour"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirHoraMaiorOuIgualQue(int startHour, int endHour, string errorMessage)
        {
            GarantirVerdadeiro(() => startHour >= endHour, errorMessage);
        }

        /// <summary>
        /// Garante que a primeira hora é menor ou igual que a segunda.
        /// </summary>
        /// <param name="startHour"></param>
        /// <param name="endHour"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirHoraMenorOuIgualQue(int startHour, int endHour, string errorMessage)
        {
            GarantirVerdadeiro(() => startHour <= endHour, errorMessage);
        }

        /// <summary>
        /// Garante que o total de horas é menor do que o permitido.
        /// </summary>
        /// <param name="startHour"></param>
        /// <param name="endHour"></param>
        /// <param name="totalHoursAllowed"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirHoraLimite(int startHour, int endHour, int totalHoursAllowed,
            string errorMessage)
        {
            GarantirVerdadeiro(() => (endHour - startHour) <= totalHoursAllowed, errorMessage);
        }
    }
}