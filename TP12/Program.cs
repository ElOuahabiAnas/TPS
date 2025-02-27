using System;
using TP2;


class Program
{
    static void Main()
    {
        Console.Write("Entrez le code du projet : ");
        string code = Console.ReadLine();
        Console.Write("Entrez le sujet du projet : ");
        string sujet = Console.ReadLine();
        Console.Write("Entrez la duree du projet en semaines : ");
        int duree = int.Parse(Console.ReadLine());

        Projet projet = new Projet(code, sujet, duree);

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Ajouter un programmeur");
            Console.WriteLine("2. Rechercher un programmeur");
            Console.WriteLine("3. Afficher un programmeur");
            Console.WriteLine("4. Afficher tous les programmeurs");
            Console.WriteLine("5. Supprimer un programmeur");
            Console.WriteLine("6. Ajouter consommation de cafe");
            Console.WriteLine("7. Changer bureau d'un programmeur");
            Console.WriteLine("8. Afficher total de cafe consomme en une semaine");
            Console.WriteLine("9. Quitter");
            Console.Write("Votre choix : ");
            int choix = int.Parse(Console.ReadLine());

            try
            {
                switch (choix)
                {
                    case 1:
                        Console.Write("Nom : ");
                        string nom = Console.ReadLine();
                        Console.Write("Prenom : ");
                        string prenom = Console.ReadLine();
                        projet.AjouterProgrammeur(new Programmeur(nom, prenom, duree));
                        break;

                    case 2:
                        Console.Write("Nom du programmeur : ");
                        string rech = Console.ReadLine();
                        Programmeur p = projet.RechercherProgrammeur(rech);
                        Console.WriteLine(p != null ? p.ToString() : "Programmeur non trouve.");
                        break;

                    case 3:
                        Console.Write("Nom du programmeur : ");
                        string affichNom = Console.ReadLine();
                        projet.AfficherProgrammeur(affichNom);
                        break;

                    case 4:
                        projet.AfficherTousProgrammeurs();
                        break;

                    case 5:
                        Console.Write("Nom du programmeur a supprimer : ");
                        string nomSuppr = Console.ReadLine();
                        projet.SupprimerProgrammeur(nomSuppr);
                        break;

                    case 6:
                        Console.Write("Nom du programmeur : ");
                        string nomC = Console.ReadLine();
                        Console.Write("Semaine : ");
                        int semaine = int.Parse(Console.ReadLine());
                        Console.Write("Tasses de cafe : ");
                        int tasses = int.Parse(Console.ReadLine());
                        projet.AjouterConsommationCafe(nomC, semaine, tasses);
                        break;

                    case 7:
                        Console.Write("Nom du programmeur : ");
                        string nomB = Console.ReadLine();
                        Console.Write("Nouveau bureau : ");
                        string bureau = Console.ReadLine();
                        projet.ChangerBureau(nomB, bureau);
                        break;

                    case 8:
                        Console.Write("Semaine : ");
                        int sem = int.Parse(Console.ReadLine());
                        projet.TotalCafeSemaine(sem);
                        break;

                    case 9:
                        return;

                    default:
                        Console.WriteLine("Choix invalide.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }
    }
}
