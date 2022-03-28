using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyFWeek5.DemoDay1
{
    internal static class Demo
    {
        internal static void DemoTipiBase()
        {
            int age = 18;
            //int age = null;
            bool y = true; //false;
            string s1 = "Hello";
            string s2 = null;
            string s3 = "";
            string s4 = s1;
            Console.WriteLine(s4);
            s1 = "Ciao";
            Console.WriteLine(s4);

            object obj1 = new object();
            object obj2 = null;
            object obj3 = obj1;

            Person p1 = new Person() { Nome = "Renata", Cognome = "Carriero" };
            Person p2 = p1;
            p2.Nome = "Maria";
            Console.WriteLine($"{p1.Nome} - {p1.Cognome}");

            //Dichiarazione
            string a, b, c;

            //Inizializzazione
            //int i = 1;
            //int j = 2;
            int i = 1, j = 2;

            //Costanti
            const double Pi = 3.14;

            //Type inference
            int numero = 120;
            var secondoNumero = 12.4;
            var nome = "Antonia";
            //var nome2 = null;

        }

        

        internal static void Enum()
        {
            Genere sex = Genere.donna;
            GiornoDellaSettimana giorno = GiornoDellaSettimana.martedì;

            //Casting
            int y = 0;
            long z = 34;
            z = y; //cast implicito
            int k = (int)z; //cast esplicito
            double risultato = (double)3 / 2; //risultato =1.5
            Console.WriteLine(risultato);

            int s = (int)sex;
            Console.WriteLine(s);
            int s2 = (int)Genere.donna;

            int a = 1;
            Genere sesso = (Genere)a;
            Console.WriteLine(sesso);

            Console.WriteLine("Ciao, sei uomo (1) o donna (2)?");
            int scelta = int.Parse(Console.ReadLine());
            Genere sessoScelto = (Genere)scelta;
            Console.WriteLine($"Hai scelto: {sessoScelto}");
        }

        enum GiornoDellaSettimana
        {
            lunedì = 1,
            martedì,
            mercoledì,
            giovedì,
            venerdì,
            sabato,
            domenica
        }
        enum Genere
        {
            uomo = 1,
            donna
        }

        internal static void Operazioni()
        {
            bool x, y = true;
            x = true;
            x = !y;
            Console.WriteLine($"x: {x} - y: {y}");
            x = !(1 == 3);

            //interi
            int i, j, k;
            i = 2;
            j = 135678907 % 6; // + - * / %
            Console.WriteLine(j);

            //Operazioni con string
            string s = "Ciao";
            string s2 = "Renata";
            Console.WriteLine(s + " " + s2);

        }

        internal static void Cicli()
        {
            //numeri da 1 a 10 
            const int N = 10;

            //ciclo for
            Console.WriteLine("Stampa da 1 a 10 con for--------------------------");
            for (int i = 0; i < N; i++)  //i=i+1;
            {
                Console.WriteLine(i + 1);
            }

            //numeri da 1 a 10 pari

            //ciclo for
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i <= N; i = i + 2)  //i=i+2;
            {
                if (i != 0) //per escludere lo zero
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i <= N; i++)
            {
                if (i % 2 == 0  && i!=0)
                {
                    Console.WriteLine(i);
                }
            }


            //ciclo while
            Console.WriteLine("Stampa da 1 a 10 con while--------------------------");
            int j = 0;
            while (j < N)
            {
                Console.WriteLine(j + 1);
                j++;
            }


            ////do-while
            //bool interruzione = true;
            //do
            //{
            //    Console.WriteLine("Sono entrato nel Do-While!");
            //    Console.WriteLine("Vuoi interrompere? SI/NO");
            //    string risposta= Console.ReadLine();
            //    if (risposta == "SI")
            //    {
            //        Console.WriteLine("Ciclo Interrotto");
            //        interruzione = false;
            //    }
            //} while (interruzione);


            //do-while
            
            do
            {
                Console.WriteLine("Sono entrato nel Do-While!");
                Console.WriteLine("Vuoi interrompere? SI/NO");
                
                
            } while (Console.ReadLine() != "SI");


            //Ho un menu e le possibili scelte sono 1,2, 3
            string risposta;
            do
            {
                Console.WriteLine("Scegli tra le possibili opzioni (a, b, c)");
                risposta=Console.ReadLine();

            } while (!(risposta== "a" || risposta == "b" || risposta == "c"));

            Console.WriteLine("Ciaone");
        }

        internal static void Array()
        {

            int[] primoArray = new int[5];
            primoArray[0] = 1;
            primoArray[1] = 23;
            //primoArray[2] = 45;
            primoArray[3] = 67;
            primoArray[4] = 566;

            Console.WriteLine("----Stampa primo Array-----");
            //for (int i = 0; i < primoArray.Length; i++)
            //{
            //    Console.WriteLine($"Nella posizione {i} c'è il valore {primoArray[i]}");

            //}
            StampaArray(primoArray);

            int[] numeri = { 1, 5, 7, 34, 23, 56 };
            Console.WriteLine("-----Stampa array numeri----");
            StampaArray(numeri);


            string[] nomi = { "Renata", "Enrica", "Federica" };
            Console.WriteLine("-----Stampa array Nomi----");
            StampaArray(nomi);
        }

        static void StampaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Nella posizione {i} c'è il valore {array[i]}");
            }
        }
        static void StampaArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Nella posizione {i} c'è il valore {array[i]}");
            }
        }

        internal static void FunzioniInOutRef()
        {
            int x = 2;
            int y = 3;

            int risultato=Somma(x, y);
            Console.WriteLine($"La somma di {x} e {y} è uguale a {risultato}");
            Somma(8 , 3);

            Console.WriteLine($"La variabile x vale: {x}");
            Test(ref x);
            Console.WriteLine($"La variabile x vale: {x}");

            int z = 5;

            int s;
            Somma2(x, y, z, out s);
            Console.WriteLine($"{s}");
            
            bool esitoVerifica= int.TryParse(Console.ReadLine(), out int miaScelta);
            Console.WriteLine($"l'esito della conversione è : {esitoVerifica}. La variabile sceltaUtente vale: {miaScelta}");


        }

        static int Somma(int a, int b)
        {
            int c= a + b;
            return c;
            //return a + b;
        }

        static void Somma2(int a , int b, int c, out int sum)
        {
            sum = a + b + c;
        }

        static void Test(ref int a)
        {
            a = 11;
            
        }

        static int SommaEProdotto(int a, int b, out int prodotto)
        {
            prodotto = a * b;
            int somma = a + b;            
            return somma;
        }
    }
}
