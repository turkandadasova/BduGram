using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BduGram.BL.Exceptions
{
    public interface IBaseException
    {
        int StatusCode { get; }
        string ErrorMessage { get; }
    }
}
