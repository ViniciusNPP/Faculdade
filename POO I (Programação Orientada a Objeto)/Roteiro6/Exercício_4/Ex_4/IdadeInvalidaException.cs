using System;

namespace Ex_4
{
    internal class IdadeInvalidaException : Exception
    {
        public IdadeInvalidaException(string message) : base(message) {}
    }
}
