namespace TP4
{
    using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class ServiceBD
{
    private string connStr = "server=localhost;user=root;password=;database=absences_db;";
    private MySqlConnection conn;

    public ServiceBD()
    {
        conn = new MySqlConnection(connStr);
        conn.Open();
    }

    public void AjouterEleve(Eleve e)
    {
        string query = "INSERT INTO Eleves(nom, prenom, groupe) VALUES (@nom, @prenom, @groupe)";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@nom", e.Nom);
        cmd.Parameters.AddWithValue("@prenom", e.Prenom);
        cmd.Parameters.AddWithValue("@groupe", e.Groupe);
        cmd.ExecuteNonQuery();
    }

    public List<Eleve> GetEleves()
    {
        List<Eleve> eleves = new List<Eleve>();
        string query = "SELECT * FROM Eleves";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            eleves.Add(new Eleve(reader.GetInt32("ID"), reader.GetString("nom"), reader.GetString("prenom"), reader.GetString("groupe")));
        }
        reader.Close();
        return eleves;
    }

    public void AjouterAbsence(Absence a)
    {
        string query = "INSERT INTO Absences(Num_semaine, ID, Nbr_absences) VALUES (@s, @id, @n)";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@s", a.NumSemaine);
        cmd.Parameters.AddWithValue("@id", a.EleveID);
        cmd.Parameters.AddWithValue("@n", a.NbrAbsences);
        cmd.ExecuteNonQuery();
    }

    public int GetAbsenceSemaine(int id, int semaine)
    {
        string query = "SELECT Nbr_absences FROM Absences WHERE ID=@id AND Num_semaine=@sem";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@sem", semaine);
        var result = cmd.ExecuteScalar();
        return result != null ? Convert.ToInt32(result) : 0;
    }

    public int GetTotalAbsences(int id)
    {
        string query = "SELECT SUM(Nbr_absences) FROM Absences WHERE ID=@id";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@id", id);
        var result = cmd.ExecuteScalar();
        return result != null ? Convert.ToInt32(result) : 0;
    }
}

    
}