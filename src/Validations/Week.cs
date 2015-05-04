using System;

namespace BM.Validations
{
    public static partial class ValidatorHelper
    {
        /// <summary>
        /// Garante que a data é um certo dia da semana.
        /// </summary>
        /// <param name="dayOfWeek"></param>
        /// <param name="date"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirDiaDaSemana(DateTime date, DayOfWeek dayOfWeek, string errorMessage)
        {
            GarantirVerdadeiro(() => date.DayOfWeek == dayOfWeek, errorMessage);
        }

        /// <summary>
        /// Garante que a data não é em um final de semana.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirNaoFimDeSemana(DateTime date, string errorMessage)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;
            GarantirFalso(() => dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday, errorMessage);
        }

        /// <summary>
        /// Garante que a data é em um final de semana.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirFimDeSemana(DateTime date, string errorMessage)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;
            GarantirVerdadeiro(() => dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday, errorMessage);
        }
    }
}
