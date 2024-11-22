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
        public static int cont = 1;

        private int codiceBici;
        private string modello;
        private string marca;

        private int potenza;

        private double prezzo;
        private double peso;

        private string tipotelaio;
        private string tipocambio;
        private string colore;



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

        //SCELTI DA CMB
        public string Marca { get => marca; set => marca = value; }
        public string Modello { get => modello; set => modello = value; }
        public string Potenza
        {
            get => potenza.ToString(); set
            {
                //int pot=Convert.ToInt32(value);
                //if (pot<= 750 && pot>= 250) potenza=pot;
                if (!int.TryParse(value, out potenza) || potenza > 750 || potenza < 250) throw new Exception("Numero non valido o maggiore di 750 o minore di 250");
            }
        }
        //PROPERTY con ERRORE
        public string Tipotelaio
        {
            get => tipotelaio; set
            {
                tipotelaio = ControlloAlmeno2Lettere(value," per il TELAIO");
            }
        }
        public string Tipocambio
        {
            get => tipocambio; set
            {
                tipocambio = ControlloAlmeno2Lettere(value, " per il CAMBIO");

            }
        }

        private string ControlloAlmeno2Lettere(string value,string more="")
        {
            if (Regex.IsMatch(value, @"^\w{2,}$")) return value;
            else throw new Exception("Almeno 2 Carattei ALfanumerici"+more);
        }

        public string Colore
        {
            get => colore; set
            {
                if (!Regex.IsMatch(value, @"^(bianco|nero|giallo|blu|altro)$", RegexOptions.IgnoreCase)) throw new Exception("Colore non valido");
                else colore = value;
            }
        }
        public string Peso
        {
            get => peso.ToString(); set
            {
                if (!Regex.IsMatch(value, @"^\d+[.,]\d{2}$")) throw new Exception("Numero decimale non valido per il PESO");
                else peso = Convert.ToDouble(value);
            }
        }
        public string Prezzo
        {
            get => prezzo.ToString(); set
            {
                if (!Regex.IsMatch(value, @"^\d+[.,]\d{2}$")) throw new Exception("Numero decimale non valido per il PREZZO");
                else
                    prezzo = Convert.ToDouble(value);
            }
        }
        

        public string CodiceBici { get => codiceBici.ToString(); }

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
            return ((IBici)this).Visualizza() + " | " + ((IMotore)this).Visualizza();
        }
    }
}