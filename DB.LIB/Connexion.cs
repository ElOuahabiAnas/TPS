namespace DB.LIB;
using System.Data;
using MySql.Data.MySqlClient;

public class Connexion : IConnexion{
    private IDbConnection cnx;
    private IDbCommand cmd;
    public Connexion(string db_name, string host="localhost", string username="root", string password=""){
        string chaine_cnx = $"User Id={username};Password={password}; Host={host};Database={db_name}";
        cnx=new MySqlConnection(chaine_cnx) ;
    }

    public void Connect() {
        cnx.Open();
        // cmd.Connection = cnx ;
        cmd = cnx.CreateCommand();
    }
    public void Dispose(){
        if (cmd != null)
            cmd.Dispose();
        if (cnx != null && cnx.State == ConnectionState.Open)
            cnx.Close();
    }
    public int iud(string sql, Dictionary<string, object> parameters = null) {
        cmd.CommandText = sql;
        if (parameters != null)
            foreach (var param in parameters)
            {
                var p = cmd.CreateParameter();
                p.ParameterName = param.Key;
                p.Value = param.Value;
                cmd.Parameters.Add(p);
            }
        return cmd.ExecuteNonQuery();
    }
    public IDataReader select(string sql, Dictionary<string, object> parameters = null) {
        cmd.CommandText = sql;
        if (parameters != null)
            foreach (var param in parameters) {
                var p = cmd.CreateParameter();
                p.ParameterName = param.Key;
                p.Value = param.Value;
                cmd.Parameters.Add(p);
            }
        return cmd.ExecuteReader();
    }
}