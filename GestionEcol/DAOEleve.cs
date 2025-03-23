using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Gestion_Ecole
{
    public  class DAOEleve : IDAO<Eleve>
    {
        private readonly IConnexion connexion;

        public DAOEleve(IConnexion connexion)
        {
            this.connexion = connexion;
        }

        public int delete(int id)
        {
            string sql = "DELETE FROM eleve WHERE id=@id";
            Dictionary<string, object> param = new Dictionary<string, object>() { { "@id", id } };
            return connexion.iud(sql, param);
        }



        public List<Eleve> findAll()
        {
            List<Eleve> list = new List<Eleve>();
            using (IDataReader reader = connexion.select("SELECT * FROM eleve", null))
            {
                while (reader.Read())
                {
                    list.Add(new Eleve(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4)));
                }
            }
            return list;
        }

        public int insert(Eleve o)
        {
            string sql = "INSERT INTO eleve(nom, prenom, ville, specialite) VALUES(@nom, @prenom, @ville, @specialite)";
            Dictionary<string, object> param = new Dictionary<string, object>()
            {
                { "@nom", o.Nom },
                { "@prenom", o.Prenom },
                { "@ville", o.Ville },
                { "@specialite", o.Specialite },
            };
            return connexion.iud(sql, param);
        }
        
        public List<Eleve> find(Eleve o)
        {
            List<Eleve> list = new List<Eleve>();
            string sql = "SELECT * FROM eleve WHERE 1=1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(o.Nom))
            {
                sql += " AND nom = @nom";
                parameters["@nom"] = o.Nom;
            }
            if (!string.IsNullOrEmpty(o.Prenom))
            {
                sql += " AND prenom = @prenom";
                parameters["@prenom"] = o.Prenom;
            }
            if (!string.IsNullOrEmpty(o.Ville))
            {
                sql += " AND ville = @ville";
                parameters["@ville"] = o.Ville;
            }
            if (!string.IsNullOrEmpty(o.Specialite))
            {
                sql += " AND specialite = @specialite";
                parameters["@specialite"] = o.Specialite;
            }

            using (IDataReader reader = connexion.select(sql, parameters))
            {
                while (reader.Read())
                {
                    list.Add(new Eleve(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4)));
                }
            }
            return list;
        }
        
        public Eleve findById(int id)
        {
            string sql = "SELECT * FROM eleve WHERE id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>() { { "@id", id } };

            using (IDataReader reader = connexion.select(sql, parameters))
            {
                if (reader.Read()) // Si un résultat est trouvé
                {
                    return new Eleve(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4));
                }
            }
            return null; // Retourne `null` si l'élève n'existe pas
        }
        
        public int update(Eleve o)
        {
            string sql = "UPDATE eleve SET nom=@nom, prenom=@prenom, ville=@ville, specialite=@specialite WHERE id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "@id", o.Id },
                { "@nom", o.Nom },
                { "@prenom", o.Prenom },
                { "@ville", o.Ville },
                { "@specialite", o.Specialite }
            };

            return connexion.iud(sql, parameters);
        }
        
        




    }
}