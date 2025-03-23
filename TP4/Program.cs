using System;
using TP4;

class Program
{
    static void Main()
    {
        ServiceBD service = new ServiceBD();
        int choix;

        do
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Ajouter un élève");
            Console.WriteLine("2. Lister les élèves");
            Console.WriteLine("3. Ajouter une absence");
            Console.WriteLine("4. Afficher absences d’un élève pour une semaine");
            Console.WriteLine("5. Afficher total des absences d’un élève");
            Console.WriteLine("0. Quitter");
            Console.Write("Choix : ");
            choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    Console.Write("Nom : ");
                    string nom = Console.ReadLine();
                    Console.Write("Prenom : ");
                    string prenom = Console.ReadLine();
                    Console.Write("Groupe : ");
                    string groupe = Console.ReadLine();
                    service.AjouterEleve(new Eleve(nom, prenom, groupe));
                    break;

                case 2:
                    var eleves = service.GetEleves();
                    foreach (var e in eleves)
                        Console.WriteLine($"{e.ID}: {e.Nom} {e.Prenom} - {e.Groupe}");
                    break;

                case 3:
                    Console.Write("ID de l'élève : ");
                    int id1 = int.Parse(Console.ReadLine());
                    Console.Write("Numéro de semaine : ");
                    int semaine = int.Parse(Console.ReadLine());
                    Console.Write("Nombre d'absences : ");
                    int nb = int.Parse(Console.ReadLine());
                    service.AjouterAbsence(new Absence(semaine, id1, nb));
                    break;

                case 4:
                    Console.Write("ID de l'élève : ");
                    int id2 = int.Parse(Console.ReadLine());
                    Console.Write("Semaine : ");
                    int sem = int.Parse(Console.ReadLine());
                    int abs = service.GetAbsenceSemaine(id2, sem);
                    Console.WriteLine($"Absences en semaine {sem} : {abs}");
                    break;

                case 5:
                    Console.Write("ID de l'élève : ");
                    int id3 = int.Parse(Console.ReadLine());
                    int total = service.GetTotalAbsences(id3);
                    Console.WriteLine($"Total des absences : {total}");
                    break;
            }

        } while (choix != 0);
    }
}
