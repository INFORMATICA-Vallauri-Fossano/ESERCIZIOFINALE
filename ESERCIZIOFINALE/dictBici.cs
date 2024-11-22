using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZIOFINALE
{
    class dictBici
    {
        private static dictBici istance = null;
        private dictBici() { }
        public static dictBici Create()
        {
            if (istance == null) istance = new dictBici();
            return istance;
        }
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public void InserireBici(clsBiciElettrica bici)
        {
            try
            {
                dictionary.Add(bici.CodiceBici, bici.Modello + "-" + bici.Marca + "-" + bici.Prezzo);
            }
            catch (ArgumentException)
            {
                throw new Exception("Non puoi inserire la stessa bici");
            }
        }
        public string LeggerePrezzoPerChiave(string key)
        {
            string output="";
            if(!dictionary.TryGetValue(key, out output)) throw new Exception("VAlore non contenuto nel dizionario");
            output = output.Split('-')[2];
            return output;
        }
    }
}
