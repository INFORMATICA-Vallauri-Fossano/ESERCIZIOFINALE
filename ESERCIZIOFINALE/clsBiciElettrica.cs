using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ESERCIZIOFINALE
{
    internal class clsBiciElettrica : IBici, IMotore
    {
        private string modello;
        private string tipotelaio;
        private string tipocambio;
        private string colore;
        private double peso;

        private string marca;
        private int potenza;

        private double prezzo;
        private int codiceBici;
        private static int cont = 1;
        public clsBiciElettrica(string modello, string tipotelaio, string tipocambio, string colore, string peso, string marca, string potenza, string prezzo)
        {
            Modello = modello;
            Tipotelaio = tipotelaio;
            Tipocambio = tipocambio;
            Colore = colore;
            Peso = peso;
            Marca = marca;
            Potenza = potenza;
            Prezzo = prezzo;
            codiceBici = cont++;
           
        }

        public string Modello { get => modello; set => modello = value; }
        public string Tipotelaio { get => tipotelaio; set {
                tipotelaio = ControlloAlmeno2Lettere(value);
            } }
        public string Tipocambio { get => tipocambio; set {
                tipotelaio = ControlloAlmeno2Lettere(value);

            }
        }

        private string ControlloAlmeno2Lettere(string value)
        {
            if (Regex.IsMatch(value, @"^\w{2,}$")) return value;
            else throw new Exception("Almeno 2 Carattei ALfanumerici");
        }

        public string Colore
        {
            get => colore; set
            {
                if (!Regex.IsMatch(value, @"^(bianco|nero|giallo|blu|altro)$",RegexOptions.IgnoreCase)) throw new Exception("Colore non valido");
                else colore = value;
            }
        }
        public string Marca { get => marca; set => marca = value; }
        public string Peso { get => peso.ToString(); set {
                if (!Regex.IsMatch(value, @"^\d+[.,]\d{2}$")) throw new Exception("Numero decimale non valido");
                else peso=Convert.ToDouble(value);
            } }
        public string Prezzo { get => prezzo.ToString(); set {
                if (!Regex.IsMatch(value, @"^\d+[.,]\d{2}$")) throw new Exception("Numero decimale non valido");
                else prezzo = Convert.ToDouble(value);
            } }
        public string Potenza { get => potenza.ToString(); set
            {
                if (!int.TryParse(value, out potenza) || potenza > 750 || potenza < 250) throw new Exception("Numero non valido o maggiore di 750 o minore di 250");
            }
        }
        string IBici.Visualizza()
        {
            return Modello + "-" + Tipotelaio + "-" + Tipocambio + "-" + Colore + "-" + Peso;

        }
        string IMotore.Visualizza()
        {
            return Marca + "-" + Potenza;

        }

        public string Visualizza()
        {
            return ((IBici)this).Visualizza() +" | "+ ((IMotore)this).Visualizza();
        }
    }
}