using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ControleAcessoCondominio
{
    class Banco
    {
        private static SqlConnection conexao = new SqlConnection();
        private static SqlCommand sql = new SqlCommand();

        public const int EXECUTE_NON_QUERY = 0;
        public const int EXECUTE_SCALAR = 1;
        private static SqlDataAdapter Inicializar()
        {
            conexao.ConnectionString = @"Data Source=(local)\sqlexpress;Initial Catalog=Condominio;Integrated Security=True";
            sql.Connection = conexao;
            SqlDataAdapter adaptador = new SqlDataAdapter(sql);
            return adaptador;
        }
        public static void FecharConexao()
        {
            conexao.Close();
        }
        public static int Executar(out SqlDataAdapter adaptador, int metodo = EXECUTE_NON_QUERY)
        {
            adaptador = Inicializar();
            int i = 0;
            conexao.Open();

            if (metodo == EXECUTE_NON_QUERY)
            {
                //retorna o número de linhas afetadas
                i = sql.ExecuteNonQuery();
            }
            else if(metodo == EXECUTE_SCALAR)
            {
                //retorna o id inserido
                i = Convert.ToInt32(sql.ExecuteScalar() ?? -1);
            }

            conexao.Close();
            return i;
        }
        public static int Executar(int metodo = EXECUTE_NON_QUERY)
        {
            return Executar(out SqlDataAdapter adaptador, metodo);
        }
        private static int InserirPessoa(Pessoa p)
        {
            sql = new SqlCommand();
            sql.CommandText = "INSERT INTO Pessoas (Nome, Cpf) output INSERTED.IdPessoa VALUES (@nome,@cpf)";
            sql.Parameters.AddWithValue("@nome", p.Nome);
            sql.Parameters.AddWithValue("@cpf", p.Cpf);
            int id = Executar(EXECUTE_SCALAR);
            return id;
        }

        public static int InserirMorador(Morador m)
        {
            int idPessoa = InserirPessoa(m);
            int linhasAfetadas = 0;
            if (idPessoa != -1)
            {
                sql = new SqlCommand();
                sql.CommandText = "INSERT INTO Moradores (IdMorador, Senha, IsAtivo) " +
                    "VALUES (@IdMorador,@Senha, @IsAtivo)";
                sql.Parameters.AddWithValue("@IdMorador", idPessoa);
                sql.Parameters.AddWithValue("@Senha", m.Senha);
                sql.Parameters.AddWithValue("@IsAtivo", m.IsAtivo);
                linhasAfetadas = Executar();
            }
            return linhasAfetadas;
        }

        public static SqlDataAdapter SelectMoradores()
        {
            sql = new SqlCommand();
            sql.CommandText = "SELECT Pessoas.Nome, Pessoas.Cpf, Moradores.IsAtivo " +
                "FROM Pessoas " +
                "INNER JOIN Moradores ON Pessoas.IdPessoa = Moradores.IdMorador; ";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }

        public static SqlDataAdapter BuscarMoradores(string nome)
        {
            sql = new SqlCommand();
            sql.CommandText = "SELECT Pessoas.Nome, Pessoas.Cpf, Moradores.IsAtivo " +
                "FROM Pessoas " +
                "INNER JOIN Moradores ON Pessoas.IdPessoa = Moradores.IdMorador " +
                $"AND Pessoas.Nome LIKE '%{nome}%'; ";
            //sql.Parameters.AddWithValue("@nome", nome);
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }

        public static int MudarSenhaMorador(Morador m, string senha)
        {
            if (senha.Length < Morador.TAM_MIN_SENHA) return 0;

            int linhasAfetadas = 0;
            string cpf = m.Cpf;
            sql = new SqlCommand();
            sql.CommandText = "UPDATE Moradores " +
                "SET Senha = @senha " +
                "WHERE IdMorador = (SELECT IdPessoa FROM Pessoas WHERE Cpf = @cpf); ";
            sql.Parameters.AddWithValue("@senha", senha);
            sql.Parameters.AddWithValue("@cpf", cpf);
            linhasAfetadas = Executar();
            Debug.WriteLine($"MudarSenhaMorador {linhasAfetadas}");
            return linhasAfetadas;
        }

        public static int MudarIsAtivoMorador(Morador m, bool isAtivo)
        {
            int linhasAfetadas = 0;
            string cpf = m.Cpf;
            sql = new SqlCommand();
            sql.CommandText = "UPDATE Moradores " +
                "SET IsAtivo = @isativo " +
                "WHERE IdMorador = (SELECT IdPessoa FROM Pessoas WHERE Cpf = @cpf); ";
            sql.Parameters.AddWithValue("@isativo", isAtivo);
            sql.Parameters.AddWithValue("@cpf", cpf);
            linhasAfetadas = Executar();
            Debug.WriteLine($"MudarIsAtivoMorador {linhasAfetadas}");
            return linhasAfetadas;
        }

        public static SqlDataAdapter BuscarVisitantes(string cpfMorador)
        {
            sql = new SqlCommand();
            sql.CommandText = $"SELECT Pessoas_Visitantes_View.Nome, Pessoas_Visitantes_View.Cpf " +
                $"FROM Pessoas_Visitantes_View " +
                $"INNER JOIN Pessoas_Moradores_View ON Pessoas_Visitantes_View.IdMorador = Pessoas_Moradores_View.IdPessoa " +
                $"WHERE Pessoas_Moradores_View.Cpf = '{cpfMorador}'; ";
            Executar(out SqlDataAdapter adaptador);
            return adaptador;
        }
    }
}
