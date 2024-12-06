using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class FormatoNombreException : Exception
    {
       

        public FormatoNombreException(string? message) : base(message)
        {
        }

        
    }
}
