using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZIOFINALE
{
    public interface IBici
    {
        string Modello { get; set; }
        string Tipotelaio { get; set; }
        string Tipocambio { get; set; }
        string Colore { get; set; }
        string Peso { get; set; }
        string Visualizza();

    }
}

