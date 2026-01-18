using System;
using System.Data;
using Npgsql;

namespace BP2_Projekt_Teretana
{
    public static class Db
    {
        // Ostavi svoj connection string (isti kao u Db_cs.txt)
        private static readonly string ConnStr =
            "Host=localhost;Port=5433;Database=ksencar23;Username=ksencar23;Password=Fluence0004;Search Path=projekt,public";

        public static DataTable Query(string sql, params NpgsqlParameter[] p)
        {
            using var con = new NpgsqlConnection(ConnStr);
            using var cmd = new NpgsqlCommand(sql, con);
            if (p != null && p.Length > 0) cmd.Parameters.AddRange(p);

            using var da = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int Exec(string sql, params NpgsqlParameter[] p)
        {
            using var con = new NpgsqlConnection(ConnStr);
            con.Open();

            using var cmd = new NpgsqlCommand(sql, con);
            if (p != null && p.Length > 0) cmd.Parameters.AddRange(p);

            return cmd.ExecuteNonQuery();
        }

        // Standardni pattern za sve gumbe: try/catch + poruka (hvata i Postgres trigger poruke)
        public static void Run(Action action, Action<string> setPoruka, string? okMsg = null)
        {
            try
            {
                action();
                if (!string.IsNullOrWhiteSpace(okMsg))
                    setPoruka(okMsg!);
            }
            catch (PostgresException ex)
            {
                setPoruka(ex.MessageText);
            }
            catch (Exception ex)
            {
                setPoruka(ex.Message);
            }
        }
    }
}
