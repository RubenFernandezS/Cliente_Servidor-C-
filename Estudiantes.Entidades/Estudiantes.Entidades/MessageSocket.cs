using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.Entidades
{
    [Serializable]
    public class MessageSocket<T>
    {
        public string Method { get; set; }
        public T Entity { get; set; }
    }
}
