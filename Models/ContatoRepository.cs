using System.Collections.Generic;
using MySqlConnector;
using System;

namespace pi3.Models
{
    public class ContatoRepository
    {
        private const string DadosConexao = "Database = RockHouse; Data Source = localhost; User id= root";

        public void TestarConexao()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open();

            Console.WriteLine("Banco de dados funcionando!");

            Conexao.Close();

        }

        public Contato BuscarPorId(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String QuerySql = "select * from Contato WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            Comando.Parameters.AddWithValue("@Id", Id);

            MySqlDataReader Reader = Comando.ExecuteReader();

            Contato ContatoEncontrado = new Contato();

            
            if (Reader.Read())
            {
            ContatoEncontrado.Id = Reader.GetInt32("Id");

            if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
            ContatoEncontrado.Nome =Reader.GetString("Nome");

            if(!Reader.IsDBNull(Reader.GetOrdinal("Necessidade")))
            ContatoEncontrado.Necessidade = Reader.GetString("Necessidade");

            if(!Reader.IsDBNull(Reader.GetOrdinal("Email")))
            ContatoEncontrado.Email = Reader.GetString("Email");

            ContatoEncontrado.Telefone = Reader.GetString("Telefone");

            ContatoEncontrado.Data = Reader.GetDateTime("Data");
            }
            Conexao.Close();

            return ContatoEncontrado;
        }

        public List<Contato> Listar()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String QuerySql = "select * from Contato";

            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Contato>Lista = new List<Contato>();

            while(Reader.Read())
            {
                Contato userEncontrado = new Contato();

                userEncontrado.Id= Reader.GetInt32("Id");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                userEncontrado.Nome=Reader.GetString("Nome");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Necessidade")))
                userEncontrado.Necessidade=Reader.GetString("Necessidade");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                userEncontrado.Email=Reader.GetString("Email");

                userEncontrado.Telefone=Reader.GetString("Telefone");
                
                userEncontrado.Data=Reader.GetDateTime("Data");


                Lista.Add(userEncontrado);
            }

            Conexao.Close();

            return Lista;
        }

        public void Excluir(Contato user)
        {
            MySqlConnection Conexao = new MySqlConnection (DadosConexao);
            Conexao.Open();

            String QuerySql = "delete from Contato WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand (QuerySql, Conexao);

            Comando.Parameters.AddWithValue("@Id", user.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Inserir (Contato user)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String QuerySql = "insert into Contato (nome, necessidade, email, telefone, data) values (@nome,@necessidade,@email,@telefone,@data)";

            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Necessidade", user.Necessidade);
            Comando.Parameters.AddWithValue("@Email", user.Email);
            Comando.Parameters.AddWithValue("@Telefone", user.Telefone);
            Comando.Parameters.AddWithValue("@Data", user.Data);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Alterar (Contato user)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String QuerySql = "update Contato set Nome=@Nome, Necessidade=@Necessidade, Email=@Email, Telefone=@Telefone, Data=@Data WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            Comando.Parameters.AddWithValue("@Id", user.Id);
            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Necessidade", user.Necessidade);
            Comando.Parameters.AddWithValue("@Email", user.Email);
            Comando.Parameters.AddWithValue("@Telefone", user.Telefone);
            Comando.Parameters.AddWithValue("@Data", user.Data);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }


    }
}