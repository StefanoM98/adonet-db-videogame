namespace adonet_db_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel gestionale di Sony");

            while (true)
            {
                Console.WriteLine(@"
                1: Inserisci un nuovo videogioco
                2: Ricerca un videogioco per ID
                3: ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input
                4: Cancellare un videogioco
                5: Chiudi il programma");

                Console.Write("Seleziona l'opzione che desideri: ");
                int opzioneSelezionata = int.Parse(Console.ReadLine());

                switch (opzioneSelezionata)
                {
                    case 1:
                        Console.WriteLine("Hai scelto di inserire un nuovo videogioco");
                        break;
                    case 2:
                        Console.WriteLine("Hai scelto di ricercare un videogioco per il suo id");
                        break;
                    case 3:
                        Console.WriteLine("Hai scelto di ricercare il videogioco per una parola chiave");
                        break;
                    case 4:
                        Console.WriteLine("Hai scelto di cancellare un gioco");
                        break;
                    case 5:
                        Console.WriteLine("Hai scelto di chiudere il programma");
                        break;
                }
            }
        }
    }
}