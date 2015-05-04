using System;
using System.Collections.Generic;
using System.Linq;

namespace BM.Validations
{
    public static partial class ValidatorHelper
    {
        /// <summary>
        /// Garante que a primeira data não é maior do que a segunda.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirDataMaiorQue(DateTime startDate, DateTime endDate, string errorMessage)
        {
            GarantirVerdadeiro(() => startDate.Date > endDate.Date, errorMessage);
        }

        /// <summary>
        /// Garante que a primeira data não é menor do que a segunda.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirDataMenorQue(DateTime startDate, DateTime endDate, string errorMessage)
        {
            GarantirVerdadeiro(() => startDate.Date < endDate.Date, errorMessage);
        }

        /// <summary>
        /// Garante que a primeira data seja maior ou igual do que a segunda.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirDataMaiorOuIgualQue(DateTime startDate, DateTime endDate, string errorMessage)
        {
            GarantirVerdadeiro(() => startDate.Date >= endDate.Date, errorMessage);
        }

        /// <summary>
        /// Garante que a primeira data seja menor ou igual do que a segunda.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirDataMenorOuIgualQue(DateTime startDate, DateTime endDate, string errorMessage)
        {
            GarantirVerdadeiro(startDate.Date <= endDate.Date, errorMessage);
        }

        /// <summary>
        /// Garante que a primeira data seja igual à segunda.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirDataIgual(DateTime startDate, DateTime endDate, string errorMessage)
        {
            GarantirVerdadeiro(() => startDate.Date == endDate.Date, errorMessage);
        }

        /// <summary>
        ///     Garante que a lista não contém uma data.
        ///     Obs: Não verifica a hora.
        /// </summary>
        /// <param name="dateList"></param>
        /// <param name="date"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirQueNaoContemData(IList<DateTime> dateList, DateTime date, string errorMessage)
        {
            if (dateList == null) return;
            GarantirFalso(() => dateList.Any(x => x.Date == date.Date), errorMessage);
        }
    }
}