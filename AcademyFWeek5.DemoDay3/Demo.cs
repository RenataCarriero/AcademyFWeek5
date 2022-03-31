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
            Console.WriteLine($"L'ultimo elemento è :{nomi[nomi.Length - 1]}");
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
            int posizione = Array.IndexOf(numeri, 5);
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
            var valore = myArrayList[1];
            Console.WriteLine($"Elemento in posizione 1: {valore}");

            //Conteggio elementi
            int numeroElementi = myArrayList.Count;
            Console.WriteLine($"Ci sono {numeroElementi} elementi");

            //Rimuovere
            myArrayList.Remove(2); //cancella l'elemento con valore 2
            Console.WriteLine($"Ci sono {myArrayList.Count} elementi");

            //Verifica se un elemento esiste nel mio Array list
            bool esiste = myArrayList.Contains(10);
            Console.WriteLine($"Il valore 10 è contenuto nel mio arrayList? {esiste}");

        }

        internal static void DemoHashtable()
        {
            var miaTabella = new Hashtable();

            miaTabella.Add(1, "uno");
            miaTabella.Add(2, 2000);
            miaTabella.Add("oggi", DateTime.Today.ToShortDateString());

            foreach (DictionaryEntry item in miaTabella)
            {
                Console.WriteLine($"Chiave: {item.Key}, valore: {item.Value}");
            }

            //Recuperare valore tramite la chiave
            var valore = miaTabella[1];
            Console.WriteLine($"Il valore corrispondente alla key 1 è : {valore}");
            var valore2 = miaTabella["oggi"];
            Console.WriteLine($"Il valore corrispondente alla key 'oggi' è : {valore2}");

            //Conteggio o dimensiose
            Console.WriteLine($"Ci sono {miaTabella.Count} elementi");

            //Rimuovere tramite key
            miaTabella.Remove(1);
            Console.WriteLine($"Ci sono {miaTabella.Count} elementi dopo la rimozione della coppia chiave valore con key=1");

            //Stamapare tutte le chiavi
            Console.WriteLine("Stampa di tutte le chiavi");
            foreach (var item in miaTabella.Keys)
            {
                Console.WriteLine(item);
            }

            //Stamapare tutte i valori
            Console.WriteLine("Stampa di tutti i valori");
            foreach (var item in miaTabella.Values)
            {
                Console.WriteLine(item);
            }

            //verifica se esiste la key
            bool esisteKey = miaTabella.Contains("oggi");
            Console.WriteLine($"La key 'oggi' esiste? {esisteKey}");
            //verifica se esiste un valore
            bool esisteValue = miaTabella.ContainsValue(3000);
            Console.WriteLine($"Il valore 3000 esiste? {esisteValue}");
        }


        internal static void DemoListe()
        {
            List<Utente> listaUtenti = new List<Utente>();
            Utente u1 = new Utente() { Nome = "Mario", Cognome = "Rossi", Eta=20 };
            listaUtenti.Add(u1);
            Utente u2 = new Utente();
            u2.Nome = "Bianca";
            u2.Cognome = "Bianchi";
            u2.Eta = 99;
            listaUtenti.Add(u2);            
            listaUtenti.Add(new Utente() { Nome = "Giuseppe", Cognome = "Verdi", Eta=40 });

            List<Utente> listaUtenti2 = new List<Utente>() { 
                new Utente() {Nome="Anna", Cognome="Neri", Eta=22},
                new Utente() { Nome="Pippo", Cognome="Disney", Eta=100},
                new Utente("Paperino", "Disney", 102)
            };


            var listaNomi= new List<string>()
            {
                "Alice",
                "Renata",
                "Antonia",
                "Arianna"
            };

            //Add
            listaNomi.Add("Anna");

            //insert
            listaNomi.Insert(1, "Mirko");

            foreach (var item in listaNomi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"La lista contiene {listaNomi.Count} elementi");

            var intArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var intList= new List<int> (intArray);
            intList.Add(9);
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }

        }

        internal static void DemoGenerics()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"a: {a} \t b: {b}");
            Scambio(ref a, ref b);
            Console.WriteLine($"a: {a} \t b: {b}");

            string nome1 = "Renata";
            string nome2 = "Alessandro";
            Console.WriteLine($"nome1: {nome1} \t nome2: {nome2}");
            ScambioGenerico<string>(ref nome1, ref nome2);
            Console.WriteLine($"nome1: {nome1} \t nome2: {nome2}");
            ScambioGenerico(ref a, ref b);
            Console.WriteLine($"a: {a} \t b: {b}");
        }

        private static void Scambio(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;            
        }

        private static void ScambioGenerico<T>(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }


        internal static void DemoDictionary()
        {
            //Dictionary<TKey,TValue>
            var festivita = new Dictionary<string, DateTime>();
            festivita.Add("Natale", new DateTime(2022, 12, 25));
            festivita.Add("Capodanno", new DateTime(2022, 01, 01));
            festivita.Add("Ferragosto", new DateTime(2022, 08, 15));

            var ragazze = new Dictionary<string, int>()
            {
                ["Renata"] = 34,
                ["Antonia"] = 20
            };

            if (ragazze.ContainsKey("Renata"))
            {
                Console.WriteLine("Renata c'è nell'elenco.");
                Console.WriteLine($"L'età di Renata è {ragazze["Renata"]}");
            }

            foreach (var item in ragazze)
            {
                Console.WriteLine($"Chiave: {item.Key} \t Valore: {item.Value}");
            }
           
        }
    }
}
