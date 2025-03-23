namespace TP21.Models
{
    public class Directeur
    {
        private static Directeur instance;
        private GestionEmployes gestionEmployes;

        private Directeur() { }

        public static Directeur Instance
        {
            get
            {
                if (instance == null)
                    instance = new Directeur();
                return instance;
            }
        }

        public void SetGestionEmployes(GestionEmployes gestion)
        {
            gestionEmployes = gestion;
        }

        public double ObtenirSalaireTotal()
        {
            if (gestionEmployes != null)
                return gestionEmployes.CalculerSalaireTotal();
            return 0;
        }
        

        public double ObtenirSalaireMoyen()
        {
            if(gestionEmployes != null)
                return gestionEmployes.CalculerSalaireMoyen();
            return 0;
        }

        public void AfficherInfosEntreprise()
        {
            System.Console.WriteLine($"Salaire Total: {ObtenirSalaireTotal()} DH");
            System.Console.WriteLine($"Salaire Moyen: {ObtenirSalaireMoyen()} DH");
        }
    }
}