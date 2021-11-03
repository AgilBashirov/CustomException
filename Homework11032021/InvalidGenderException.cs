using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11032021
{
    class InvalidGenderException : Exception
    {
        public InvalidGenderException (string msj) : base (msj)
        {

        }
    }
}
