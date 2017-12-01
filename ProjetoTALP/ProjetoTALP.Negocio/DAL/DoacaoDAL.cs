using ProjetoTALP.Negocio.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTALP.Negocio.DAL
{
    class DoacaoDAL
    {
        String stringDeUpdate = "UPDATE dbo.Doacao SET Categoria=@Categoria, Quantidade=@Quantidade, Definicao=@Definicao, IdInstituicao=@IdInstituicao, IdDoador=@IdDoador WHERE IdDoacao = (@IdDoacao)";
        String stringDoacao = "UPDATE dbo.Doacao SET ESTATUS = 'C' WHERE IdDocao = (@IdDoacao)";
        String stringDeInsert = "INSERT INTO Doacao (Categoria, Quantidade, Definicao, IdInstituicao, IdDoador) VALUES (@Categoria, @Quantidade, @Definicao, @IdInstituicao, @IdDoador)";
        String stringDeDelete = "DELETE dbo.Doacao WHERE IdDoacao = (@IdDoacao)";
        String stringDeSelect = "SELECT i.cnpj, i.NomeInstituicao, i.EnderecoInstituicao, d.IdDoacao, d.Categoria, d.Quantidade, d.Definicao, d.Estatus FROM DBHelpme.dbo.Doacao d INNER JOIN DBHelpme.dbo.Instituicao i ON d.IdInstituicao = i.IdInstituicao";
        String idDoacao = "@IdDoacao";
        String connectionName = "ConexaoPadrao";
        internal DataTable selectDoacao()
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ToString();

            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {

                    conn.Open();
                    var sql = stringDeSelect;
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.CommandType = CommandType.Text;
                    DataSet dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);

                    dtAdapter.Fill(dtSet);
                    return dtSet.Tables[0];


                }
                //catch (SqlException ex)
                //{
                //   // throw ex;
                //}
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {

                }
            }
        }

        internal Boolean insertDoacao(DoacaoDTO dto)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ToString();

            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {

                    conn.Open();

                    var _insert = stringDeInsert;

                    SqlCommand _comand = new SqlCommand(_insert, conn);

                    _comand.Parameters.AddWithValue("@Categoria", dto.Categoria);
                    _comand.Parameters.AddWithValue("@Quantidade", dto.Quantidade);
                    _comand.Parameters.AddWithValue("@Definicao", dto.Definicao);
                    _comand.Parameters.AddWithValue("@IdInstituicao", dto.IdInstituicao);
                    _comand.Parameters.AddWithValue("@IdDoador", dto.IdDoador);


                    _comand.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {

                }
            }

        }
        
        internal Boolean deleteDoacao(DoacaoDTO dto)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName];
            using (SqlConnection conn = new SqlConnection(_stringDeConexao.ToString()))
            {
                try
                {
                    conn.Open();
                    var _delete = stringDeDelete;
                    SqlCommand _comman = new SqlCommand(_delete, conn);
                    _comman.Parameters.AddWithValue(idDoacao, dto.IdDoacao);
                    _comman.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return true;
        }

        internal Boolean alterarStatus(DoacaoDTO dto)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName];
            using (SqlConnection conn = new SqlConnection(_stringDeConexao.ToString()))
            {
                try
                {
                    conn.Open();
                    var _update = stringDoacao;
                    SqlCommand _comman = new SqlCommand(_update, conn);
                    _comman.Parameters.AddWithValue(idDoacao, dto.IdDoacao);
                    _comman.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return true;
        }

        internal Boolean updateDoacao(DoacaoDTO dto)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName];
            using (SqlConnection conn = new SqlConnection(_stringDeConexao.ToString()))
            {
                try
                {
                    conn.Open();
                    var _update = stringDeUpdate;
                    SqlCommand _comand = new SqlCommand(_update, conn);
                    _comand.Parameters.AddWithValue(idDoacao, dto.IdDoacao);
                    _comand.Parameters.AddWithValue("@Categoria", dto.Categoria);
                    _comand.Parameters.AddWithValue("@Quantidade", dto.Quantidade);
                    _comand.Parameters.AddWithValue("@Definicao", dto.Definicao);
                    _comand.Parameters.AddWithValue("@IdInstituicao", dto.IdInstituicao);
                    _comand.Parameters.AddWithValue("@IdDoador", dto.IdDoador);
                    _comand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return true;
        }
    }
}
