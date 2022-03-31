namespace Amazon
{
    internal class Carrello
    {
        public List<DettaglioOrdine> DettagliOrdine { get; set; } = new List<DettaglioOrdine>();
        public double ImportoTotale { get { return CalcolaImportoTotale(); } }

        private double CalcolaImportoTotale()
        {
            double importo = 0;
            foreach (var item in DettagliOrdine)
            {
                importo += item.PrezzoScontato; //importo= importo + item.PrezzoScontato;
            }
            return importo;
        }

        public Carrello()
        {

        }

        public void StampaCarrello()
        {
            Console.WriteLine("Riepilogo Ordini nel tuo carrello: ");
            foreach (var item in DettagliOrdine)
            {
                Console.WriteLine(item.GetInfo());
            }
            Console.WriteLine($"\nTotale euro: {ImportoTotale}");
        }

    }
}