using System.Data;
using Npgsql;

public static class Db
{
    // UPIŠI svoje podatke iz DataGripa
    private static string ConnStr =
    "Host=localhost;Port=5433;Database=ksencar23;Username=ksencar23;Password=Fluence0004;Search Path=projekt,public";

    public static DataTable Query(string sql)
    {
        using var con = new NpgsqlConnection(ConnStr);
        using var da = new NpgsqlDataAdapter(sql, con);
        var dt = new DataTable();
        da.Fill(dt);
        return dt;
    }

    public static int Exec(string sql, params NpgsqlParameter[] p)
    {
        using var con = new NpgsqlConnection(ConnStr);
        con.Open();
        using var cmd = new NpgsqlCommand(sql, con);
        cmd.Parameters.AddRange(p);
        return cmd.ExecuteNonQuery();
    }
}