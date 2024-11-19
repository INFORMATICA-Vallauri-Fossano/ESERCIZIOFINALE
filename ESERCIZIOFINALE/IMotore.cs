using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZIOFINALE
{
    public interface IMotore
    {
        string Potenza { get; set; }
        string Marca { get; set; }
        string Visualizza();
    }
}
