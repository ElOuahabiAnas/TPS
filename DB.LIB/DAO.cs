using System;
using System.Collections.Generic;
using System.Data;

namespace DB.LIB
{
    public class DAO : Connexion, IDAO<object>
    {
        public int id = 0;
        private string sql = "";
        
        public DAO(string db_name, string host = "localhost", string username = "root", string password = "")
            : base(db_name, host, username, password)  // Passe les paramètres au constructeur de Connexion
        {
        }

        public Dictionary<string, object> ObjectToDictionary(object obj)
        {
            var dict = new Dictionary<string, object>();
            
            if (obj is Eleve eleve)
            {
                dict.Add("Code", eleve.Code);
                dict.Add("Nom", eleve.Nom);
                dict.Add("Prenom", eleve.Prenom);
                dict.Add("Niveau", eleve.Niveau);
                dict.Add("code_Fil", eleve.code_Fil);
            }

            return dict;
        }

        public object DictionaryToObject(Dictionary<string, object> dico)
        {
            var eleve = new Eleve();
            
            if (dico.ContainsKey("Code")) eleve.Code = dico["Code"].ToString();
            if (dico.ContainsKey("Nom")) eleve.Nom = dico["Nom"].ToString();
            if (dico.ContainsKey("Prenom")) eleve.Prenom = dico["Prenom"].ToString();
            if (dico.ContainsKey("Niveau")) eleve.Niveau = dico["Niveau"].ToString();
            if (dico.ContainsKey("code_Fil")) eleve.code_Fil = dico["code_Fil"].ToString();
            
            return eleve;
        }

        // Méthode pour insérer un nouvel objet
        public int insert()
        {
            // Exemple d'insertion, à ajuster en fonction de votre schéma de base de données
            sql = "INSERT INTO Eleve (Code, Nom, Prenom, Niveau, code_Fil) VALUES (@Code, @Nom, @Prenom, @Niveau, @code_Fil)";
            
            var parameters = new Dictionary<string, object>
            {
                { "@Code", this.id },
                { "@Nom", "Nom de l'élève" },
                { "@Prenom", "Prénom de l'élève" },
                { "@Niveau", "Niveau de l'élève" },
                { "@code_Fil", "Code de la filière" }
            };

            return iud(sql, parameters); // Utilise la méthode iud de la classe Connexion pour exécuter l'insert
        }

        // Méthode pour mettre à jour un objet
        public int update()
        {
            sql = "UPDATE Eleve SET Nom = @Nom, Prenom = @Prenom, Niveau = @Niveau, code_Fil = @code_Fil WHERE Code = @Code";

            var parameters = new Dictionary<string, object>
            {
                { "@Code", this.id },
                { "@Nom", "Nouveau Nom" },
                { "@Prenom", "Nouveau Prénom" },
                { "@Niveau", "Nouveau Niveau" },
                { "@code_Fil", "Nouveau code de filière" }
            };

            return iud(sql, parameters); // Utilise la méthode iud de la classe Connexion pour exécuter l'update
        }

        // Méthode pour supprimer un objet
        public int delete()
        {
            sql = "DELETE FROM Eleve WHERE Code = @Code";

            var parameters = new Dictionary<string, object>
            {
                { "@Code", this.id }
            };

            return iud(sql, parameters); // Utilise la méthode iud de la classe Connexion pour exécuter le delete
        }

        // Méthode pour trouver un objet par son ID
        public object findById()
        {
            sql = "SELECT * FROM Eleve WHERE Code = @Code";
            
            var parameters = new Dictionary<string, object>
            {
                { "@Code", this.id }
            };

            IDataReader reader = select(sql, parameters);
            if (reader.Read())
            {
                var eleve = new Eleve
                {
                    Code = reader["Code"].ToString(),
                    Nom = reader["Nom"].ToString(),
                    Prenom = reader["Prenom"].ToString(),
                    Niveau = reader["Niveau"].ToString(),
                    code_Fil = reader["code_Fil"].ToString()
                };
                return eleve;
            }

            return null; // Aucun résultat trouvé
        }

        // Méthode pour trouver tous les objets
        public List<object> findAll()
        {
            sql = "SELECT * FROM Eleve";
            var resultList = new List<object>();

            IDataReader reader = select(sql, null);
            while (reader.Read())
            {
                var eleve = new Eleve
                {
                    Code = reader["Code"].ToString(),
                    Nom = reader["Nom"].ToString(),
                    Prenom = reader["Prenom"].ToString(),
                    Niveau = reader["Niveau"].ToString(),
                    code_Fil = reader["code_Fil"].ToString()
                };
                resultList.Add(eleve);
            }

            return resultList;
        }

        // Méthode pour effectuer une recherche avec des critères
        public List<object> find()
        {
            // Exemple d'une recherche simple
            sql = "SELECT * FROM Eleve WHERE Niveau = @Niveau";
            
            var parameters = new Dictionary<string, object>
            {
                { "@Niveau", "Niveau spécifique" }
            };

            var resultList = new List<object>();
            IDataReader reader = select(sql, parameters);
            while (reader.Read())
            {
                var eleve = new Eleve
                {
                    Code = reader["Code"].ToString(),
                    Nom = reader["Nom"].ToString(),
                    Prenom = reader["Prenom"].ToString(),
                    Niveau = reader["Niveau"].ToString(),
                    code_Fil = reader["code_Fil"].ToString()
                };
                resultList.Add(eleve);
            }

            return resultList;
        }
    }
}
