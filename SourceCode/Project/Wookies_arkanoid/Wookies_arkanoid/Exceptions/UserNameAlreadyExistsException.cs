using System;

namespace Wookies_arkanoid.Exceptions
{
    public class UserNameAlreadyExistsException : Exception
    {
        public UserNameAlreadyExistsException(string message) : base(message) {}
    }
}