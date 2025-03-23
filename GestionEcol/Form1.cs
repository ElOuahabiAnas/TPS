using System;
using System.Windows.Forms;
using Gestion_Ecole;

namespace GestionEcol
{
    public partial class Form1 : Form
    {
        private DAOEleve daoEleve;

        public Form1(DAOEleve dao)
        {
            InitializeComponent();
            this.daoEleve = dao;

            // Associer les événements
            b_Ajouter.Click += b_Ajouter_Click;
            b_Rechercher.Click += b_Rechercher_Click;
            b_Supprimer.Click += b_Supprimer_Click;
            DataEleve.SelectionChanged += DataEleve_SelectionChanged;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataEleve.DataSource = daoEleve.findAll();
        }

        private void b_Ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(t_nom.Text) || string.IsNullOrWhiteSpace(t_prenom.Text) ||
                string.IsNullOrWhiteSpace(t_ville.Text) || string.IsNullOrWhiteSpace(t_specialite.Text))
            {
                MessageBox.Show("Tous les champs sont obligatoires !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Eleve eleve = new Eleve(0, t_nom.Text.Trim(), t_prenom.Text.Trim(), t_ville.Text.Trim(), t_specialite.Text.Trim());
            int result = daoEleve.insert(eleve);

            if (result > 0)
            {
                MessageBox.Show("Élève ajouté avec succès !");
                DataEleve.DataSource = daoEleve.findAll();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b_Supprimer_Click(object sender, EventArgs e)
        {
            if (DataEleve.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un élève à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(DataEleve.SelectedRows[0].Cells[0].Value);
            int rowsAffected = daoEleve.delete(id);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Élève supprimé avec succès !");
                DataEleve.DataSource = daoEleve.findAll();
            }
        }
        
        private void b_Rechercher_Click(object sender, EventArgs e)
        {
            string searchQuery = t_nom.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Veuillez entrer un nom à rechercher.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Recherche des élèves contenant le nom donné
            var result = daoEleve.find(new Eleve(0, searchQuery, "", "", ""));

            if (result.Count > 0)
            {
                DataEleve.DataSource = result;
            }
            else
            {
                MessageBox.Show("Aucun élève trouvé avec ce nom.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataEleve.DataSource = daoEleve.findAll(); // Recharge la liste complète
            }
        }
        
        private void b_Modifier_Click(object sender, EventArgs e)
        {
            if (DataEleve.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un élève à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(DataEleve.SelectedRows[0].Cells[0].Value);
            string nom = t_nom.Text.Trim();
            string prenom = t_prenom.Text.Trim();
            string ville = t_ville.Text.Trim();
            string specialite = t_specialite.Text.Trim();

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(ville) || string.IsNullOrWhiteSpace(specialite))
            {
                MessageBox.Show("Tous les champs sont obligatoires !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Eleve eleve = new Eleve(id, nom, prenom, ville, specialite);
            int result = daoEleve.update(eleve);

            if (result > 0)
            {
                MessageBox.Show("Élève modifié avec succès !");
                DataEleve.DataSource = daoEleve.findAll();
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void DataEleve_SelectionChanged(object sender, EventArgs e)
        {
            if (DataEleve.SelectedRows.Count > 0)
            {
                t_nom.Text = DataEleve.SelectedRows[0].Cells[1].Value.ToString();
                t_prenom.Text = DataEleve.SelectedRows[0].Cells[2].Value.ToString();
                t_ville.Text = DataEleve.SelectedRows[0].Cells[3].Value.ToString();
                t_specialite.Text = DataEleve.SelectedRows[0].Cells[4].Value.ToString();
            }
        }



    }
}
