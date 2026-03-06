using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Treca_zadaca;
using Treca_zadaca.Models;

namespace Treca_zadaca.Repositories
{ 
    public class KonfiguracijaRepository
    {
        public static List<Konfiguracija> GetConfigurations()
        {
            var konfiguracije = new List<Konfiguracija>();
            string sql = "SELECT * FROM Konfiguracija";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int.TryParse(reader["IdKonfiguracije"].ToString(), out int idKonfiguracije);
                    string naziv = reader["Naziv"] != DBNull.Value ? reader["Naziv"].ToString() : string.Empty;

                    konfiguracije.Add(new Konfiguracija
                    {
                        IdKonfiguracije = idKonfiguracije,
                        Naziv = naziv
                    });
                }
            }
            reader.Close();
            DB.CloseConnection();
            return konfiguracije;
        }
    }
}