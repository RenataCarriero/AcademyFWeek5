using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyFWeek5.DemoDay3
{
    internal static class Demo
    {
        internal static void DemoArrayApprofondimento()
        {
            var nomi = new string[]
            {
                "Renata", //nomi[0]
                "Antonia", //nomi[1]
                "Federica", //nomi[2]
                "Francesca", //nomi[3]
                "Gaia",
                "Enrica",
                "Valentina"
            };
            //primo elemento
            Console.WriteLine($"Il primo elemento è :{nomi[0]}");
            //ultimo elemento
            Console.WriteLine($"L'ultimo elemento è :{nomi[nomi.Length-1]}");
            //Accesso tramite index
            Index ultimo = ^1;
            Console.WriteLine($"L'ultimo elemento è :{nomi[ultimo]}"); //{nomi[^1]}
            //terzultimo
            Index terzultimo = ^3;
            Console.WriteLine($"Il terzultimo elemento è :{nomi[terzultimo]}");

            //RANGE
            Console.WriteLine("Dal secondo elemento al quinto elemento");
            Range range = 1..6; //estremo sinistro incluso, estremo destro escluso
            var sottoinsieme1 = nomi[range];
            foreach (var item in sottoinsieme1)
            {
                Console.WriteLine($"Elemento: {item}");
            }

            //Stampa tutti
            Console.WriteLine("Stampa tutti gli elementi");
            var sottoinsieme2 = nomi[..];

            foreach (var item in sottoinsieme2)
            {
                Console.WriteLine($"Elemento: {item}");
            }

            //Stampare tutti dal 3 in poi
            Console.WriteLine("Stampa tutti dal 3° elemento in poi");
            var sottoinsieme3 = nomi[2..];

            foreach (var item in sottoinsieme3)
            {
                Console.WriteLine($"Elemento: {item}");
            }

            // Stampare dal 2° elemento al penultimo - Mix range ed index

            Console.WriteLine("Stampa tutti dal 2° elemento al penultimo");
            var sottoinsieme4 = nomi[1..^1];

            foreach (var item in sottoinsieme4)
            {
                Console.WriteLine($"Elemento: {item}");
            }

            int[] numeri = { 10, 3, 5, 6, 9 };
            Console.WriteLine("Il mio array numeri è :");
            foreach (var item in numeri)
            {
                Console.WriteLine($"Elemento: {item}");
            }
            //cerco la posizione dell'elemento
            int posizione=Array.IndexOf(numeri, 5);
            Console.WriteLine($"La posizione del valore 5 è : {posizione}");

            //ordinamento
            Array.Sort(numeri);
            Console.WriteLine("Il mio array numeri ordinato è :");
            foreach (var item in numeri)
            {
                Console.WriteLine($"Elemento: {item}");
            }

            //ordinamento decrescente
            Array.Reverse(numeri);
            Console.WriteLine("Il mio array numeri ordinato decrescente è :");
            foreach (var item in numeri)
            {
                Console.WriteLine($"Elemento: {item}");
            }

            Console.WriteLine("Il mio array dopo resize 3 elementi");
            Array.Resize(ref numeri, 3);
            foreach (var item in numeri)
            {
                Console.WriteLine($"Elemento: {item}");
            }
        }

        internal static void DemoArrayList()
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(2);
            myArrayList.Add("Ciao");
            myArrayList.Add(10);

            //Accesso
            var valore= myArrayList[1];
            Console.WriteLine($"Elemento in posizione 1: {valore}");

            //Conteggio elementi
            int numeroElementi=myArrayList.Count;
            Console.WriteLine($"Ci sono {numeroElementi} elementi");

            //Rimuovere
            myArrayList.Remove(2); //cancella l'elemento con valore 2
            Console.WriteLine($"Ci sono {myArrayList.Count} elementi");

            //Verifica se un elemento esiste nel mio Array list
            bool esiste= myArrayList.Contains(10);
            Console.WriteLine($"Il valore 10 è contenuto nel mio arrayList? {esiste}");

        }
    }
}
