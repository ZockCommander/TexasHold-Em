using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Console;

namespace TexasHold_Em
{
    static class SQLManager
    {
       
        private static MySqlConnection con = new MySqlConnection("server=web.hak-kitz.eu; UID=alexander.ortner; pwd=MyDatabase061; database=alexander.ortner");
        private static MySqlCommand cmd = new MySqlCommand("", con);
        private static MySqlDataReader reader;


        public static bool doesUserExist(string username)
        {
            con.Open();
            cmd.CommandText = "select * from swp_benutzer where name = '" + username + "'";
            reader = cmd.ExecuteReader();
            bool userExists = false;
            if (reader.HasRows)
            {
                userExists = true;
            }
            con.Close();
            return userExists;
        }
        public static void newUser(string username, string pw)
        {
            con.Open();
            cmd.CommandText = "insert into swp_benutzer (name, pw) values ('" + username + "', '" + pw + "')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "insert into swp_stats (username) values ('" + username + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static string getPassword(string username)
        {
            con.Open();
            cmd.CommandText = "select pw from swp_benutzer where name='" + username + "'";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string password = reader.GetString(0);
                con.Close();
                return password;
            }
            else
            {
                con.Close();
                return "Not found";
            }
        }

        public static List<int> getPlayerStats(string username) 
        {
            con.Open();
            cmd.CommandText = "select playedg, balance, lvl from swp_stats where username = '" + username + "'";
            reader = cmd.ExecuteReader();
            reader.Read();
            List<int> stats = new List<int>();
            stats.Add(reader.GetInt32(0));
            stats.Add(reader.GetInt32(1));
            stats.Add(reader.GetInt32(2));

            con.Close();
            return stats;
        }

        public static float getPlayerLevelProgress(string username)
        {
            con.Open();
            cmd.CommandText = "select lvlProgress from swp_stats where username = '" + username + "'";
            reader = cmd.ExecuteReader();
            reader.Read();
            float progress = reader.GetFloat(0);
            con.Close();
            return progress;
        }
    }
}
