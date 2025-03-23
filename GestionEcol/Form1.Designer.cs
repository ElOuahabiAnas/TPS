﻿namespace GestionEcol
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1, label2, label3, label4;
        private System.Windows.Forms.TextBox t_nom, t_prenom, t_ville, t_specialite;
        private System.Windows.Forms.Button b_Ajouter, b_Rechercher, b_Supprimer;
        private System.Windows.Forms.DataGridView DataEleve;
        private System.Windows.Forms.Button b_Modifier;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.t_nom = new TextBox();
            this.t_prenom = new TextBox();
            this.t_ville = new TextBox();
            this.t_specialite = new TextBox();
            this.b_Ajouter = new Button();
            this.b_Rechercher = new Button();
            this.b_Supprimer = new Button();
            this.DataEleve = new DataGridView();
            
            ((System.ComponentModel.ISupportInitialize)(this.DataEleve)).BeginInit();
            this.SuspendLayout();

            // Labels
            int labelX = 50, textBoxX = 200, topSpacing = 30, textBoxWidth = 250;

            label1.Text = "Nom";
            label1.Location = new System.Drawing.Point(labelX, topSpacing);
            label2.Text = "Prénom";
            label2.Location = new System.Drawing.Point(labelX, topSpacing + 40);
            label3.Text = "Ville";
            label3.Location = new System.Drawing.Point(labelX, topSpacing + 80);
            label4.Text = "Spécialité";
            label4.Location = new System.Drawing.Point(labelX, topSpacing + 120);

            // Textboxes
            t_nom.Location = new System.Drawing.Point(textBoxX, topSpacing);
            t_nom.Size = new System.Drawing.Size(textBoxWidth, 25);
            t_prenom.Location = new System.Drawing.Point(textBoxX, topSpacing + 40);
            t_prenom.Size = new System.Drawing.Size(textBoxWidth, 25);
            t_ville.Location = new System.Drawing.Point(textBoxX, topSpacing + 80);
            t_ville.Size = new System.Drawing.Size(textBoxWidth, 25);
            t_specialite.Location = new System.Drawing.Point(textBoxX, topSpacing + 120);
            t_specialite.Size = new System.Drawing.Size(textBoxWidth, 25);

            // Boutons
            b_Ajouter.Text = "Ajouter";
            b_Ajouter.Location = new System.Drawing.Point(500, topSpacing);
            b_Ajouter.Size = new System.Drawing.Size(120, 35);

            b_Rechercher.Text = "Rechercher";
            b_Rechercher.Location = new System.Drawing.Point(500, topSpacing + 50);
            b_Rechercher.Size = new System.Drawing.Size(120, 35);

            b_Supprimer.Text = "Supprimer";
            b_Supprimer.Location = new System.Drawing.Point(500, topSpacing + 100);
            b_Supprimer.Size = new System.Drawing.Size(120, 35);
            b_Supprimer.BackColor = System.Drawing.Color.Red;
            b_Supprimer.ForeColor = System.Drawing.Color.White;
            
            // Bouton "Modifier"
            b_Modifier = new Button();
            b_Modifier.Text = "Modifier";
            b_Modifier.Location = new System.Drawing.Point(500, 180);
            b_Modifier.Size = new System.Drawing.Size(120, 35);
            b_Modifier.BackColor = System.Drawing.Color.Orange;
            b_Modifier.ForeColor = System.Drawing.Color.White;
            b_Modifier.Click += b_Modifier_Click;
            Controls.Add(b_Modifier);


            // DataGridView
            DataEleve.Location = new System.Drawing.Point(50, topSpacing + 180);
            DataEleve.Size = new System.Drawing.Size(600, 250);
            DataEleve.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            DataEleve.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            DataEleve.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            DataEleve.RowHeadersVisible = false;
            DataEleve.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Ajout des éléments à la fenêtre
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(t_nom);
            this.Controls.Add(t_prenom);
            this.Controls.Add(t_ville);
            this.Controls.Add(t_specialite);
            this.Controls.Add(b_Ajouter);
            this.Controls.Add(b_Rechercher);
            this.Controls.Add(b_Supprimer);
            this.Controls.Add(DataEleve);

            // Fenêtre principale
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Text = "Gestion des Élèves";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
