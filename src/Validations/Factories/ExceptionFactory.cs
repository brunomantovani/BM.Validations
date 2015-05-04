using System;

namespace BM.Validations.Factories
{
#warning Alterar todos os throws para a Factory
    public static class ExceptionFactory
    {
        /// <summary>
        /// Cria uma instância de um ApplicationException (ou que herda).
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static ApplicationException Create(
            string errorMessage)
        {
            return new ApplicationException(errorMessage);
        }

        /// <summary>
        /// Cria uma instância de um ApplicationException (ou que herda).
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <param name="innerException"></param>
        /// <returns></returns>
        public static ApplicationException Create(
            string errorMessage, Exception innerException)
        {
            return new ApplicationException(errorMessage, innerException);
        }

        /// <summary>
        /// Cria uma instância de um ApplicationException (ou que herda).
        /// </summary>
        /// <typeparam name="TException"></typeparam>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static TException Create<TException>(
            string errorMessage)
            where TException : ApplicationException
        {
            return (TException)
                Activator.CreateInstance(typeof(TException), errorMessage);
        }

        /// <summary>
        /// Cria uma instância de um ApplicationException (ou que herda).
        /// </summary>
        /// <typeparam name="TException"></typeparam>
        /// <param name="errorMessage"></param>
        /// <param name="innerException"></param>
        /// <returns></returns>
        public static TException Create<TException>(
            string errorMessage, Exception innerException)
            where TException : ApplicationException
        {
            return (TException)
                Activator.CreateInstance(typeof(TException), errorMessage, innerException);
        }
    }
}
