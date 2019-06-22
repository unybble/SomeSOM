using System;
namespace SomeSOM.Services
{
    public class NotEnoughDataException : Exception
    {
        public NotEnoughDataException(string message)
           : base(message)
        {
        }
    }
}
