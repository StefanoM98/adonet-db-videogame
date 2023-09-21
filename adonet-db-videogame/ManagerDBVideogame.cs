using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet_db_videogame
{
    public class ManagerDBVideogame
    {
        private static string connesione = "Data Source = localhost; Initial Catalog = videogames_query; Integrated Security = True";

        public static List<Videogioco> GetVideogiochi()
        {
            List<Videogioco> videogioco = new List<Videogioco>();
            using (SqlConnection nuovaConnessione =  new SqlConnection(connesione))
            {
                try
                {
                    nuovaConnessione.Open();

                    string query = "SELECT id, name, release_date FROM videogames";
                    using(SqlCommand cmd = new SqlCommand(query, nuovaConnessione))
                    using(SqlDataReader data = cmd.ExecuteReader())
                    {
                        while (data.Read())
                        {
                            Videogioco videogiocoLetto = new Videogioco(data.GetInt64(0), data.GetString(1), data.GetDateTime(2));
                            videogioco.Add(videogiocoLetto);
                        }
                    }
                        
                } 
                catch(Exception ex)
                {
                    Console.Write(ex.Message);
                }
                return videogioco;
            }
        }
    }
}
