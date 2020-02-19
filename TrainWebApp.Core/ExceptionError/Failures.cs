using System;
using System.Collections.Generic;
using System.Text;

namespace TrainWebApp.Core.ExceptionError
{
    public class UserNotFoundFailure : ExceptionTermFailure
    {
        public UserNotFoundFailure() : base(ExceptionTerm.UserNotFoundFailure)
        {
        }
    }
}
