using System;

namespace Wookies_arkanoid.Exceptions
{
    public class NonMatchingPasswordValidationException : Exception
    {
        public NonMatchingPasswordValidationException(string message) : base(message) {}
    }
}