using System;

namespace Wookies_arkanoid.Exceptions
{
    public class IncorrectPasswordException : Exception
    {
        public IncorrectPasswordException(string message) : base(message) {}
    }
}