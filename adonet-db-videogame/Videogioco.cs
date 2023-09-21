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

        public long Sofware_house_id { get; private set; }

        public Videogioco(long id, string name,string overview, DateTime release_date, long software_house_id )
        {
            Id = id;
            Name = name;
            Overview = overview;
            Release_date = release_date;
            Sofware_house_id = software_house_id;
        }

        public override string ToString()
        {
            return $"ID: {Id} ---- videogioco: {Name} ---- rilasciato il: {Release_date} ---- rilasciato da: {Sofware_house_id}";
        }
    }
}
