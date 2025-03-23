using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Gestion_Ecole
{
    internal class Connexion : IConnexion
    {
        private string chaine_cnx;


        public Connexion(string db_name, string host = "localhost", string username = "root", string password = "")
        {
            chaine_cnx = $"User Id={username};Password={password}; Host={host};Database={db_name}";
        }

        public void Connect(string db_name, string host = "localhost", string username = "root", string password = "")
        {
            chaine_cnx = $"User Id={username};Password={password}; Host={host};Database={db_name}";
        }

        
        public int iud(string sql, Dictionary<string, object> parameters = null)
        {
            try
            {
                using (MySqlConnection cnx = new MySqlConnection(chaine_cnx))
                {
                    cnx.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cnx))
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erreur SQL : {ex.Message}");
                return -1; // Indiquer une erreur
            }
        }

        public IDataReader select(string sql, Dictionary<string, object> parameters = null)
        {
            try
            {
                MySqlConnection cnx = new MySqlConnection(chaine_cnx);
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cnx);

                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erreur SQL : {ex.Message}");
                return null;
            }
        }
    }
}
