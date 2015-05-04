using System;

namespace BM.Validations
{
    public static partial class ValidatorHelper
    {
        /// <summary>
        /// Garante que o primeiro time é maior que o segundo.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirTimeMaiorQue(DateTime startTime, DateTime endTime, string errorMessage)
        {
            var compareStartDate = new DateTime(1900, 1, 1, startTime.Hour, startTime.Minute, startTime.Second);
            var compareEndDate = new DateTime(1900, 1, 1, endTime.Hour, endTime.Minute, endTime.Second);
            GarantirVerdadeiro(() => compareStartDate > compareEndDate, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro time é menor que o segundo.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirTimeMenorQue(DateTime startTime, DateTime endTime, string errorMessage)
        {
            var compareStartDate = new DateTime(1900, 1, 1, startTime.Hour, startTime.Minute, startTime.Second);
            var compareEndDate = new DateTime(1900, 1, 1, endTime.Hour, endTime.Minute, endTime.Second);

            GarantirVerdadeiro(() => compareStartDate < compareEndDate, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro time é maior ou igual que o segundo.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirTimeMaiorOuIgualQue(DateTime startTime, DateTime endTime, string errorMessage)
        {
            var compareStartDate = new DateTime(1900, 1, 1, startTime.Hour, startTime.Minute, startTime.Second);
            var compareEndDate = new DateTime(1900, 1, 1, endTime.Hour, endTime.Minute, endTime.Second);
            GarantirVerdadeiro(() => compareStartDate >= compareEndDate, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro time é menor que o segundo.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirTimeMenorOuIgualQue(DateTime startTime, DateTime endTime, string errorMessage)
        {
            var compareStartDate = new DateTime(1900, 1, 1, startTime.Hour, startTime.Minute, startTime.Second);
            var compareEndDate = new DateTime(1900, 1, 1, endTime.Hour, endTime.Minute, endTime.Second);
            GarantirVerdadeiro(() => compareStartDate <= compareEndDate, errorMessage);
        }

        /// <summary>
        /// Garante que o primeiro time seja igual que o segundo.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="errorMessage"></param>
        public static void GarantirTimeIgual(DateTime startTime, DateTime endTime, string errorMessage)
        {
            var compareStartDate = new DateTime(1900, 1, 1, startTime.Hour, startTime.Minute, startTime.Second);
            var compareEndDate = new DateTime(1900, 1, 1, endTime.Hour, endTime.Minute, endTime.Second);
            GarantirVerdadeiro(() => compareStartDate == compareEndDate, errorMessage);
        }
    }
}