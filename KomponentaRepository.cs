using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Treca_zadaca;

namespace Treca_zadaca.Repositories
{
    public class KomponentaRepository
    {
        public static List<Komponenta> GetComponents()
        {
            var komponente = new List<Komponenta>();
            string sql = "SELECT * FROM RepozitorijKomponenti";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int.TryParse(reader["IdKomponente"].ToString(), out int idKomponente);
                    string naziv = reader["Naziv"].ToString();
                    string tip = reader["Tip"].ToString();
                    string proizvodac = reader["Proizvodac"].ToString();
                    float.TryParse(reader["Cijena"].ToString(), out float cijena);
                    int.TryParse(reader["IdZaposlenika"].ToString(), out int idZaposlenika);

                    komponente.Add(new Komponenta
                    {
                        IdKomponente = idKomponente,
                        Naziv = naziv,
                        Tip = tip,
                        Proizvodac = proizvodac,
                        Cijena = cijena,
                        IdZaposlenika = idZaposlenika

                    });
                }
            }
            reader.Close();
            DB.CloseConnection();
            return komponente;

        }
    }
}
