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
        private static string connessione = "Data Source = localhost; Initial Catalog = videogames_query; Integrated Security = True";

        public static List<Videogioco> GetVideogiochi()
        {
            List<Videogioco> videogioco = new List<Videogioco>();
            using (SqlConnection nuovaConnessione = new SqlConnection(connessione))
            {
                try
                {
                    nuovaConnessione.Open();

                    string query = "SELECT id, name,overview, release_date, software_house_id FROM videogames";
                    using (SqlCommand cmd = new SqlCommand(query, nuovaConnessione))
                    using (SqlDataReader data = cmd.ExecuteReader())
                    {
                        while (data.Read())
                        {
                            Videogioco videogiocoLetto = new Videogioco(data.GetInt64(0), data.GetString(1), data.GetString(2), data.GetDateTime(3), data.GetInt64(4));
                            videogioco.Add(videogiocoLetto);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
                return videogioco;
            }
        }

        public static bool InserisciVideogioco(Videogioco videogiocoAggiunto)
        {
            using (SqlConnection nuovaConnessione = new SqlConnection(connessione))
            {
                try
                {
                    nuovaConnessione.Open();

                    string query = "INSERT INTO videogames (name, overview, release_date, software_house_id) VALUES (@Name, @Overview, @Release_date, @Software_house)";
                    SqlCommand cmd = new SqlCommand(query, nuovaConnessione);
                    cmd.Parameters.Add(new SqlParameter("@Name", videogiocoAggiunto.Name));
                    cmd.Parameters.Add(new SqlParameter("@Overview", videogiocoAggiunto.Overview));
                    cmd.Parameters.Add(new SqlParameter("@Release_date", videogiocoAggiunto.Release_date));
                    cmd.Parameters.Add(new SqlParameter("@Software_house", videogiocoAggiunto.Sofware_house_id));


                    int rows = cmd.ExecuteNonQuery();

                    if(rows > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return false;
            }
        }
    }
}
