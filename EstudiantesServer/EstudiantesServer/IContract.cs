using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiantesServer
{
    public interface IContract
    {
        void Execute(string message);
    }
}
