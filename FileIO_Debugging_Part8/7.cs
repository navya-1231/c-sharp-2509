using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Debugging_Part8
{
    public class FileTooLargeException : Exception
    {
        public FileTooLargeException(string message) : base(message) { }
    }
}
