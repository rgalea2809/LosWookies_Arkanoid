using System;

namespace Wookies_arkanoid.Exceptions
{
    public class EmptyFormFieldException: Exception
    {
        public EmptyFormFieldException(string message) : base(message) {}
    }
}