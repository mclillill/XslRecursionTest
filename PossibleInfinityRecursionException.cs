using System;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    internal class PossibleInfinityRecursionException : Exception
    {
        public PossibleInfinityRecursionException()
        {
        }

        public PossibleInfinityRecursionException(string message) : base(message)
        {
        }

        public PossibleInfinityRecursionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PossibleInfinityRecursionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}