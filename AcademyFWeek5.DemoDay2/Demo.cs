using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyFWeek5.DemoDay2
{
    internal static class Demo
    {
        internal static void Condizioni()
        {
            int i = 4;
            bool isDispari;

            if (i % 2 == 0)
            {
                isDispari = false;
            }
            else
            {
                isDispari = true;
            }
            //operatore ternario

            isDispari = (i % 2 == 0) ? false : true;


            string x = "Pippo";
            string y = "Ciao";
            string z = x ?? y; // z= (x!=null) ? x : y 
            Console.WriteLine(z);
        }

       
        internal static void Matrici()
        {
            int[,] matrice1 = new int[2, 3];
            int[,] matrice2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            const int NumeroRighe = 3;
            const int NumeroColonne = 4;
            int[,] m = new int[NumeroRighe, NumeroColonne] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            for (int i = 0; i < NumeroRighe; i++)
            {
                for (int j = 0; j < NumeroColonne; j++)
                {
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        
        }

        internal static void Nullable()
        {
            int? a;
            a = null;

            if (a.HasValue) // if(a!=null)
            {
                Console.WriteLine($"Il valore di a è: {a.Value}");
            }
            else
            {
                Console.WriteLine("a non ha un valore");
            }
        }

        internal static void DemoTuple()
        {
            int[] myArray = { 1, 23, 45, 76, 78 };
            
            var (somma, numeroElementi, prodotto)=GetInfoArray(myArray);

            
            Console.WriteLine($"La somma degli elementi è: {somma}");
            Console.WriteLine($"Il prodotto degli elementi è: {prodotto}");
            Console.WriteLine($"L'array contiene {numeroElementi} elementi");
            

        }

        internal static (int sommaElementi, int numeroElementi, long prodottoElementi) GetInfoArray(int[] a)
        {
            int lunghezza= a.Length;
            int somma = 0;
            long prodotto = 1;

            for (int i = 0; i < a.Length; i++)
            {
                somma = somma + a[i];
                prodotto = prodotto * a[i];
            }
            return (somma, lunghezza, prodotto);
        }

        internal static void DemoClasse()
        {
            Persona person;
            Persona person2 = new Persona();
            person2.Nome = "Pippo";


            Persona p = new Persona();
            Console.WriteLine(p.StampaDati());
            p.Nome = "Mario";
            p.Cognome = "Rossi";
            p.Eta = 30;
            p.Sesso = Sex.uomo;
            p.IndirizzoResidenza.Citta = "Roma";
            p.IndirizzoResidenza.Nazione = "Italia";
            p.IndirizzoResidenza.Via = "Corso Italia";
            p.IndirizzoResidenza.Civico = 19;

            Console.WriteLine(p.StampaDati());
            Console.WriteLine(p.StampaDatiCompleti());

            Persona p2 = new Persona();
            p2.Nome = "Giuseppe";
            p2.Cognome = "Verdi";
            p2.Eta = 30;
            p2.Sesso = Sex.uomo;

            Indirizzo ind1=new Indirizzo();
            ind1.Via = "Mazzini";
            ind1.Civico = 19;
            ind1.Nazione = "Italia";
            ind1.Citta = "Milano";

            p2.IndirizzoResidenza = ind1;
            Console.WriteLine(p2.StampaDatiCompleti());

            Persona p3 = new Persona("Bianca", "Bianchi", 20, Sex.donna, ind1 );
            Console.WriteLine(p3.StampaDati());
            Console.WriteLine(p3.StampaDatiCompleti());

            Persona p4 = new Persona() { Nome = "Maria", Cognome = "Gialli", Eta = 22, Sesso = Sex.donna, IndirizzoResidenza= new Indirizzo() { Citta = "Roma", Nazione = "Italia", Via = "via Dante", Civico = 10 } };
        }

    }
}
