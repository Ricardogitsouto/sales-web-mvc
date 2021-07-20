using System;

namespace SalesWebMvc.Services.Exception
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException()
        {
        }

        public NotFoundException(string message) : base(message)
        {

        }
    }
}
