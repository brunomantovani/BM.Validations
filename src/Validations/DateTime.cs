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
        public static void GarantirMaiorQue(DateTime startDate, DateTime endDate, string errorMessage)
        {
            GarantirVerdadeiro(() => startDate > endDate, errorMessage);
        }

        /// <summary>
        /// Garante que a primeira data não é menor do que a segunda.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMenorQue(DateTime startDate, DateTime endDate, string errorMessage)
        {
            GarantirVerdadeiro(() => startDate < endDate, errorMessage);
        }

        /// <summary>
        /// Garante que a primeira data seja maior ou igual do que a segunda.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMaiorOuIgualQue(DateTime startDate, DateTime endDate, string errorMessage)
        {
            GarantirVerdadeiro(() => startDate >= endDate, errorMessage);
        }

        /// <summary>
        /// Garante que a primeira data seja menor ou igual do que a segunda.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirMenorOuIgualQue(DateTime startDate, DateTime endDate, string errorMessage)
        {
            GarantirVerdadeiro(startDate <= endDate, errorMessage);
        }

        /// <summary>
        /// Garante que a primeira data seja igual à segunda.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirIgual(DateTime startDate, DateTime endDate, string errorMessage)
        {
            GarantirVerdadeiro(() => startDate == endDate, errorMessage);
        }

        /// <summary>
        /// Garante que a lista não contém uma data e hora.
        /// </summary>
        /// <param name="dateList"></param>
        /// <param name="date"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirQueNaoContem(IList<DateTime> dateList, DateTime date, string errorMessage)
        {
            if (dateList == null) return;
            GarantirFalso(() => dateList.Any(x => x == date), errorMessage);
        }
    }
}