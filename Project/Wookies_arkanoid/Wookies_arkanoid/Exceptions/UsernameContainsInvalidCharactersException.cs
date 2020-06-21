using System;

namespace Wookies_arkanoid.Exceptions
{
    public class UsernameContainsInvalidCharactersException: Exception
    {
        public UsernameContainsInvalidCharactersException(string message) : base(message) {}
    }
}