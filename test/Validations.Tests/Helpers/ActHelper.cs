using System;

namespace Validations.Tests.Helpers
{
    public static class ActHelper
    {
        public static ApplicationException GetApplicationException(Action action)
        {
            ApplicationException resultException = null;
            try
            {
                action.Invoke();
            }
            catch (ApplicationException exception)
            {
                resultException = exception;
            }
            return resultException;
        }
    }
}
