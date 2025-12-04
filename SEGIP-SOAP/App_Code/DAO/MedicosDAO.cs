using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MedicosDAO
/// </summary>
public class MedicosDAO
{
    private MySqlConnection connection;
    public MedicosDAO()
    {
        this.connection = new MySqlConnection(
        "Server=localhost;Database=hospital_db;Uid=root;Pwd=root;" +
        "SslMode=None;AllowPublicKeyRetrieval=true;");
    }

    public Medico VerificarPorCI(String CI)
    {
        try
        {
            Medico medico = null;
            connection.Open();
            String query = "SELECT * FROM medicos WHERE ci = @CI";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CI", CI);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    medico = new Medico
                    {
                        CI = reader.GetString("ci"),
                        Nombre = reader.GetString("nombre"),
                        Apellido = reader.GetString("apellido")
                    };
                }
            }
            if (medico == null)
            {
                throw new Exception("Medico no existente con CI: " + CI);
            }
            return medico;
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener medico: " + ex.Message);
        }
    }
}