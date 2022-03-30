using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palestra_OOP
{
    internal class Abbonamento
    {
        private static double quotaFissaMensile = 30;
        private static double quotaFissaGiovani = 20;
        private static double quotaFissaAdulti = 50;


        public TipoAbbonamento Tipo { get; set; }

        public Utente Utente { get; set; } = new Utente();

        public int Mesi { get { return (int)Tipo; } }

        public double AbbonamentoTotale { get { return CalcolaAbbonamento(); } }

        private double CalcolaAbbonamento()
        {
            double totale = Mesi * quotaFissaMensile;
            if (Utente.Eta <= 25)
            {
                totale += quotaFissaGiovani;
            }
            else
            {
                totale += quotaFissaAdulti;
            }

            return totale;
        }

        public Abbonamento()
        {

        }

        public Abbonamento(Utente utente, TipoAbbonamento tipo)
        {
            Tipo = tipo;
            Utente = utente;
        }
        public void StampaAbbonamento()
        {
            Console.WriteLine($"\n\nPreventivo abbonamento {Tipo} di: {Utente.StampaInfoUtente()}");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine($"Totale da pagare (euro): {AbbonamentoTotale}");
            Console.WriteLine("\nDettaglio:");
            if (Utente.Eta <= 25)
            {
                Console.WriteLine($"Età: {Utente.Eta} quindi quota fissa: {quotaFissaGiovani} euro"); ;
            }
            else
            {
                Console.WriteLine($"Età: {Utente.Eta} quindi quota fissa: {quotaFissaAdulti} euro"); ;
            }
            Console.WriteLine($"A cui va aggiunta la quota mensile {quotaFissaMensile} euro per {Mesi} mesi ovvero: {Mesi * quotaFissaMensile} euro");

        }

    }

    enum TipoAbbonamento
    {
        Annuale = 12,
        Semestrale = 6,
        Trimestrale = 3,
        Mensile = 1
    }



}