using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra_OOP
{
    internal class Utente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }
        public int Eta { get {return DateTime.Now.Year - DataDiNascita.Year; } }

        public Utente()
        {
            
        }

        public Utente(string nome, string cognome, DateTime dataNascita)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataNascita;            
        }

        public string StampaInfoUtente()
        {
            return $"{Nome} {Cognome} nato/a il {DataDiNascita.ToShortDateString()} - Età: {Eta} anni";
        }

    }
}

