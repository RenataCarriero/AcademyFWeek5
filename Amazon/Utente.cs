using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    internal class Utente
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Carrello Carrello { get; set; }= new Carrello();


        public Utente()
        {

        }
        public Utente(string nome, string cognome, string username, string password)
        {
            Nome = nome;
            Cognome = cognome;
            Username = username;
            Password = password;
            //Carrello = new Carrello();
        }

        public void StampaUtente()
        {
            Console.WriteLine($"Utente {Username}: {Nome} {Cognome}");
        }
    }
}
