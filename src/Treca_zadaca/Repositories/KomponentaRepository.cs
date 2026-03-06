using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Treca_zadaca;
using Treca_zadaca.Models;

namespace Treca_zadaca.Repositories
{
    public class KomponentaRepository
    {
        public static List<Komponenta> GetComponents()
        {
            var komponente = new List<Komponenta>();
            string sql = "SELECT * FROM Komponente";
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

        public static void AddComponent(Komponenta komponenta)
        {
            string sql = "INSERT INTO Komponente (Naziv, Tip, Proizvodac, Cijena, IdZaposlenika) " +
                         "VALUES ('" + komponenta.Naziv.Replace("'", "''") + "', '" +
                         komponenta.Tip.Replace("'", "''") + "', '" +
                         komponenta.Proizvodac.Replace("'", "''") + "', " +
                         komponenta.Cijena.ToString(System.Globalization.CultureInfo.InvariantCulture) + ", " +
                         komponenta.IdZaposlenika + ")";
            try
            {
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception($"Greška prilikom dodavanja komponente: {ex.Message}", ex);
            }
        }
        public static void UpdateComponent(Komponenta komponenta)
        {
            string sql = "UPDATE Komponente SET Naziv = '" + komponenta.Naziv.Replace("'", "''") + "', " +
                         "Tip = '" + komponenta.Tip.Replace("'", "''") + "', " +
                         "Proizvodac = '" + komponenta.Proizvodac.Replace("'", "''") + "', " +
                         "Cijena = " + komponenta.Cijena.ToString(System.Globalization.CultureInfo.InvariantCulture) + ", " +
                         "IdZaposlenika = " + komponenta.IdZaposlenika + " " +
                         "WHERE IdKomponente = " + komponenta.IdKomponente;
            try
            {
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
            }
            catch (Exception ex)
            {
                DB.CloseConnection();
                throw new Exception($"Greška prilikom ažuriranja komponente: {ex.Message}", ex);
            }
        }
        public static void DeleteComponent(int idKomponente)
        {
            string sql = "DELETE FROM Komponente WHERE IdKomponente = " + idKomponente;
            try
            {
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
            }
            catch (Exception ex)
            {
                DB.CloseConnection();
                throw new Exception($"Greška prilikom brisanja komponente: {ex.Message}", ex);
            }
        }
    }
}