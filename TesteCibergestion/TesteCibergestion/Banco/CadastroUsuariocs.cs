using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TesteCibergestion.Models;


namespace TesteCibergestion.Banco
{
    public class CadastroUsuariocs: IDisposable
    {


        public SqlConnection AbreConexao;


        public CadastroUsuariocs()
        {
            string Conexao = @"Data Source= Localhost;Initial Catalog=Cibergestion;Integrated Security=true";
            AbreConexao = new SqlConnection(Conexao);
            AbreConexao.Open();
        }

        public void Dispose()
        {
            AbreConexao.Close();
        }



        public void Create(DadoCadastral Cadastro)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = AbreConexao;
            comando.CommandText = @"INSERT INTO DadosCadastrais values(@Nome,@Telefone,@Tipo)";

            comando.Parameters.AddWithValue("@Nome", Cadastro.Nome);
            comando.Parameters.AddWithValue("@Telefone", Cadastro.Telefone);
            comando.Parameters.AddWithValue("@Tipo", Cadastro.Tipo);


            comando.ExecuteNonQuery();


        }


        public List<DadoCadastral> ListaCliente()
        {

            List<DadoCadastral> Usuarios = new List<DadoCadastral>();

            SqlCommand comando = new SqlCommand();
            comando.Connection = AbreConexao;
            comando.CommandText = @"Select *from DadosCadastrais";

            SqlDataReader leitura = comando.ExecuteReader();

            while (leitura.Read())
            {
                DadoCadastral Lista = new DadoCadastral();
                Lista.Id = (int)leitura["id"];
                Lista.Nome = (string)leitura["Nome"];
                Lista.Telefone = (string)leitura["Telefone"];
                Lista.Tipo = (string)leitura["Tipo"];

                Usuarios.Add(Lista);

            }


            return Usuarios;
        }



        public void AtualizarDado(int Id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = AbreConexao;
            comando.Parameters.AddWithValue("@Id", Id);
            comando.CommandText = @"Update DadosCadastrais set Nome=@Nome,Telefone=@Telefone,Tipo=@Tipo where id=@Id";


            DadoCadastral UsuarioAtualiza = new DadoCadastral();
            comando.Parameters.AddWithValue("@id", UsuarioAtualiza.Id);
            comando.Parameters.AddWithValue("@Nome", UsuarioAtualiza.Nome);
            comando.Parameters.AddWithValue("@Telefone", UsuarioAtualiza.Telefone);
            comando.Parameters.AddWithValue("@Tipo", UsuarioAtualiza.Tipo);
           


            comando.ExecuteNonQuery();


        }



        public bool Deletar(int id)
        {


            SqlCommand comando = new SqlCommand();
            comando.Connection = AbreConexao;
            comando.CommandText = @"Delete from DadosCadastrais where id=@id ";

            comando.Parameters.AddWithValue("@id", id);



            int contador = comando.ExecuteNonQuery();

            if (contador >= 1)
            {
                return true;
            }

            else
            {
                return false;
            }





        }


    }
}
