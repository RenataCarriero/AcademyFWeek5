using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyFWeek5.DemoDay2
{
    internal class Persona
    {
        public static int CodiceIniziale=100;
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; } 
        public Sex Sesso { get; set; }
        public Indirizzo IndirizzoResidenza { get; set; } = new Indirizzo();

        //public InfoDatiNascita DatiNascita { get; set; }
        //public class InfoDatiNascita
        //{
        //    public DateTime DataNascita { get; set; }
        //    public string ComuneNascita { get; set; }
        //}

        public Persona()
        {

        }
        public Persona(string nome,string cognome,int eta, Sex sesso)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
            Sesso = sesso;
            IndirizzoResidenza =new Indirizzo();
        }

        public Persona(string nome, string cognome, int eta, Sex sesso, Indirizzo indirizzo)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
            Sesso = sesso;
            IndirizzoResidenza = indirizzo;
        }

        public string StampaDati()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Età: {Eta}";
        }

        public string StampaDatiCompleti()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Età: {Eta}, Sesso: {Sesso} \nIndirizzo: {IndirizzoResidenza.Via} {IndirizzoResidenza.Civico} {IndirizzoResidenza.Citta} {IndirizzoResidenza.Nazione}";
        }

    }

    public enum Sex
    {
        uomo=1,
        donna
    }
}
