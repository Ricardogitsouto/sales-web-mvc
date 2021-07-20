using System;

namespace SalesWebMvc.Services.Exception
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException()
        {
        }

        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
