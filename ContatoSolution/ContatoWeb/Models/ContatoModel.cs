using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ContatoWeb.Models
{
    public class ContatoModel : IDisposable
    {
        private SqlConnection Connection;

        public ContatoModel() {
            string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=bdcontato;Integrated Security=true";
            Connection = new SqlConnection(strConn);
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
        }

        public void Create(Contato contato){
        }

        public List<Contato> GetRead()
        {
            return null;
        }

        public List<Contato> Read
        {
            get
            {

                List<Contato> lista = new List<Contato>();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = @"SELECT * FROM Contato";

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Contato contato = new Contato();
                    contato.IdContato = (int)reader["IdContato"];
                    contato.Nome = (string)reader["Nome"];
                    contato.Email = (string)reader["Email"];

                    lista.Add(contato);
                }

                return lista;
            }
        }
        public void create(Contato contato) {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"INSERT INTO Contato VALUES (@nome, @email)";
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.ExecuteNonQuery();
        }

        public void Update(Contato contato){
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"UPDATE Contato SET Nome=@nome, Email=@email WHERE IdContato=@id";
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.Parameters.AddWithValue("@id", contato.IdContato);
            cmd.ExecuteNonQuery();
        }
        
        public void Delete(int id){
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = @"DELETE FROM Contato WHERE IdContato=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}