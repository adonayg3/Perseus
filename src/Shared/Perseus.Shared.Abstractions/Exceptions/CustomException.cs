using System;

namespace Perseus.Shared.Abstractions.Exceptions
{
    public class CustomException : Exception
    {
        protected CustomException(string message) : base(message)
        {
        }
    }
}