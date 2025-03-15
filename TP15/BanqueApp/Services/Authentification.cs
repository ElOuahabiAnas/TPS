

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TP15.BanqueApp.Models;
using TP15.BanqueApp.Models;

namespace TP15.BanqueApp.Services
{
    public class Authentification
    {
        private string usersFile = "users.json";

        public Utilisateur AuthentifierUtilisateur()
        {
            Console.WriteLine($"Chemin de recherche du fichier : {Path.GetFullPath(usersFile)}");

            
            if (!File.Exists(usersFile)) {
                Console.WriteLine("Fichier users.json introuvable !");
                return null;
            }
            
            
            var users = JsonConvert.DeserializeObject<List<Utilisateur>>(File.ReadAllText(usersFile));
            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Mot de passe: ");
            string password = Console.ReadLine();

            foreach (var user in users)
            {
                if (user.Login == login && user.Password == password)
                {
                    Console.WriteLine($"Bienvenue {user.Role} !");
                    return user;
                }
            }
            Console.WriteLine("Identifiants incorrects !");
            return null;
        }
    }
}
