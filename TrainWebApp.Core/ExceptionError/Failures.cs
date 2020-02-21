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

    public class UnitIdNotFound : ExceptionTermFailure
    {
        public UnitIdNotFound() : base(ExceptionTerm.UnitIdNotFound)
        {
        }
    }

    public class EmptyList : ExceptionTermFailure
    {
        public EmptyList() : base(ExceptionTerm.EmptyList)
        {
        }
    }
}
