using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.Exceptions
{
    public class NotFoundException :ApplicationException
    {
        public NotFoundException(string Name , object Key): base($"{Name} ({Key}) Was Not Found")
        {
            
        }
    }
}
