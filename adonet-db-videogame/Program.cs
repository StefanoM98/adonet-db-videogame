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
                1: Visualizza tutti i videogiochi
                2: Inserisci un nuovo videogioco
                3: Ricerca un videogioco per ID
                4: ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input
                5: Cancellare un videogioco
                6: Chiudi il programma");

                Console.Write("Seleziona l'opzione che desideri: ");
                int opzioneSelezionata = int.Parse(Console.ReadLine());

                switch (opzioneSelezionata)
                {
                    case 1:
                        Console.WriteLine("Hai scelto di vedere tutti i videogiochi");

                        List<Videogioco> videogiochi = ManagerDBVideogame.GetVideogiochi();

                        Console.WriteLine("Ecco la lista dei videogiochi");
                        foreach(Videogioco videogioco in videogiochi)
                        {
                            Console.WriteLine($"{videogioco}");
                        }
                        Console.WriteLine();

                        break;

                    case 2:

                        Console.WriteLine("Hai scelto di inserire un nuovo videogioco");

                        Console.WriteLine("Inserisci il nome del videogioco");

                        string nome = Console.ReadLine();

                        Console.WriteLine("Inserisci la overview del videogioco");

                        string overview = Console.ReadLine();

                        Console.WriteLine("Inserisci la data di rilascio");

                        DateTime release_date = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Inserisci la Software House con ID");

                        long software_house_id = long.Parse(Console.ReadLine());

                        Videogioco nuovoGioco = new Videogioco(0, nome, overview, release_date, software_house_id);

                        bool inserito = ManagerDBVideogame.InserisciVideogioco(nuovoGioco);

                        if (inserito)
                        {
                            Console.WriteLine("Videogioco inserito con successo");
                        } else
                        {
                            Console.WriteLine("Errore!!");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Hai scelto di ricercare un videogioco per il suo id");
                        break;
                    case 4:
                        Console.WriteLine("Hai scelto di ricercare il videogioco per una parola chiave");
                        break;
                    case 5:
                        Console.WriteLine("Hai scelto di cancellare un gioco");
                        break;
                    case 6:
                        Console.WriteLine("Hai scelto di chiudere il programma");
                        break;
                }
            }
        }
    }
}