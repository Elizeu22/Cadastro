using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConrtroleDividas.Models;
using System.Data.SqlClient;
using System.Data;

namespace ConrtroleDividas.Repositorio
{
    public class GestaoDividas: Conexao
    {

        public bool CadastrarDivida(Dividas Cadastro)
        {
            try
            {
                AbreConexao();
                Cmd = new SqlCommand("Inserecliente", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Nome", Cadastro.Nome);
                Cmd.Parameters.AddWithValue("@ValorDivida", Cadastro.ValorDivida);
                Cmd.Parameters.AddWithValue("@QtdeProduto", Cadastro.QtdeProduto);
                Cmd.Parameters.AddWithValue("@DescricaoProduto", Cadastro.DescricaoProduto);
                Cmd.Parameters.AddWithValue("@ValorProduto", Cadastro.ValorProduto);


                int i = Cmd.ExecuteNonQuery();

                if (i >= 1)
                {
                    return true;
                }

                else
                {
                    return false;
                }



            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir dados:" + e.Message);
            }

            finally {
                FecharConexao();
            }
        }


        public List<Dividas> SelecionarTodos()
        {
            try
            {
                AbreConexao();

                Cmd = new SqlCommand("ListarTodosClientes",Con);
                Cmd.CommandType = CommandType.StoredProcedure;

                Dr = Cmd.ExecuteReader();

                var lista = new List<Dividas>();

                while (Dr.Read())
                {
                    var ControleDivida = new Dividas
                    {
                        id = Convert.ToInt32(Dr["Id"]),
                        Nome = Convert.ToString(Dr["Nome"]),
                        ValorDivida = Convert.ToDecimal(Dr["ValorDivida"]),
                        QtdeProduto = Convert.ToInt32(Dr["QtdeProduto"]),
                        DescricaoProduto = Convert.ToString(Dr["DescricaoProduto"].ToString()),
                        ValorProduto = Convert.ToDecimal(Dr["ValorProduto"]),   




                };

                   

                    lista.Add(ControleDivida);
                }

                return lista;
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao listar Deedores:" + e.Message);
            }


            finally
            {
                FecharConexao();
            }
        }



        //public bool SelecionarPorId(int id)
        //{


        //    try
        //    {
        //        AbreConexao();
        //        Cmd = new SqlCommand("Selecionar", Con);
        //        Cmd.CommandType = CommandType.StoredProcedure;
        //        Cmd.Parameters.AddWithValue("@Id",id);
            
        //        Dr = Cmd.ExecuteReader();

        //        if (Dr.Read())
        //        {
        //            Dividas SelecionaDivida = new Dividas();

                 
        //            SelecionaDivida.Nome = Dr["Nome"].ToString();
        //            SelecionaDivida.ValorDivida = (decimal)Dr["ValorDivida"];
        //            SelecionaDivida.QtdeProduto = (int)Dr["QtdeProduto"];
        //            SelecionaDivida.DescricaoProduto = Dr["DescricaoProduto"].ToString();
        //            SelecionaDivida.ValorProduto = (decimal)Dr["ValorProduto"];

        //            return true;

        //        }

        //        else
        //        {
        //            return false;
        //        }


        //    }
            
        //    catch (Exception e)
        //    {
        //        throw new Exception("Erro ao Selecionar os dados:" + e.Message);
        //    }

        //    finally
        //    {
        //        FecharConexao();
        //    }
        //}



        public bool AtualizarDivida(Dividas AtualizadoDivida)
        {

            try
            {
                AbreConexao();
                Cmd = new SqlCommand("Atualizar", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Id", AtualizadoDivida.id);
                Cmd.Parameters.AddWithValue("@Nome", AtualizadoDivida.Nome);
                Cmd.Parameters.AddWithValue("@ValorDivida", AtualizadoDivida.ValorDivida);
                Cmd.Parameters.AddWithValue("@QtdeProduto", AtualizadoDivida.QtdeProduto);
                Cmd.Parameters.AddWithValue("@DescricaoProduto", AtualizadoDivida.DescricaoProduto);
                Cmd.Parameters.AddWithValue("@ValorProduto", AtualizadoDivida.ValorProduto);




                int Atualizado = Cmd.ExecuteNonQuery();

                if (Atualizado >= 1)
                {
                    return true;
                }

                else
                {
                    return false;
                }


            }

            catch (Exception e)
            {
                throw new Exception("Erro ao Atualizar:" + e.Message);
            }

            finally
            {
                FecharConexao();
            }

            }



        public bool ExcluirDivida(int id) 
        {
            try
            {
                AbreConexao();
                Cmd = new SqlCommand("Deletar", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Id", id);

                int Deletado = Cmd.ExecuteNonQuery();

                if (Deletado >= 1)
                {
                    return true;
                }

                else
                {
                    return false;
                }



            }

            catch(Exception e)
            {
                throw new Exception("Erro ao Deletar os dados:" + e.Message);
            }

            finally
            {
                FecharConexao();
            }
        }


     

    }
}
