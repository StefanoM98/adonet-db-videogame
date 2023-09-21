using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet_db_videogame
{
    public class Videogioco
    {
        public long Id { get; private set; }
        public string Name { get; private set; }

        public string Overview { get; private set; }

        public DateTime Release_date { get; private set; }

        public Videogioco(long id, string name, DateTime release_date)
        {
            Id = id;
            Name = name;
            Release_date = release_date;
        }

        public override string ToString()
        {
            return $"ID: {Id} ---- videogioco: {Name} ---- rilasciato il: {Release_date}";
        }
    }
}
