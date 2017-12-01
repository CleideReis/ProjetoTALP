using ProjetoTALP.Negocio.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Web.UI.WebControls;

namespace ProjetoTALP.Negocio.DAL
{

    internal class InstituicaoDAL
    {
        String stringDeUpdate = "UPDATE dbo.Instituicao SET cnpj=@cnpj,NomeInstituicao=LOWER(@NomeInstituicao), EnderecoInstituicao=@EnderecoInstituicao, TelefoneInstituicao=@TelefoneInstituicao, EmailInstituicao=@EmailInstituicao, Senha=HASHBYTES('SHA2_512',@Senha) WHERE IdInstituicao = (@IdInstituicao)";
        String stringDeInsert = "INSERT INTO Instituicao (cnpj, NomeInstituicao, EnderecoInstituicao, TelefoneInstituicao, EmailInstituicao, Senha) VALUES (@cnpj, LOWER(@NomeInstituicao), @EnderecoInstituicao, @TelefoneInstituicao, @EmailInstituicao, HASHBYTES('SHA2_512',@Senha))";
        String stringDeDelete = "DELETE dbo.Instituicao WHERE IdInstituicao = (@IdInstituicao)";
        String stringDeSelect = "SELECT IdInstituicao, cnpj, NomeInstituicao, EnderecoInstituicao, TelefoneInstituicao, EmailInstituicao, Senha FROM Instituicao ORDER BY NomeInstituicao";
        String idInstituicao = "@IdInstituicao";
        String stringSelectLogin = "SELECT IdInstituicao, cnpj, NomeInstituicao FROM DBHelpme.dbo.Instituicao WHERE EmailInstituicao = @EmailInstituicao AND Senha = HASHBYTES('SHA2_512',@Senha)";
        String connectionName = "ConexaoPadrao";
        internal DataTable buscarInstituicoes()
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
        /// <summary>
        /// Metodo que insere dados na tabela instituição
        /// </summary>
        /// <param name="dto">InstituicaoDTO</param>
        /// <returns>Boolean</returns>
        internal Boolean insertInstituicao(InstituicaoDTO dto)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ToString();

            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {

                    //abre o BD
                    conn.Open();

                    // prepara o comando para enviar ao BD
                    var _insert = stringDeInsert;

                    //utiliza o sqlcommand para enviar os dados ao BD
                    SqlCommand _comand = new SqlCommand(_insert, conn);

                    //seta o valor do parametro que o BD está esperando
                    _comand.Parameters.AddWithValue("@cnpj", dto.cnpj);
                    _comand.Parameters.AddWithValue("@NomeInstituicao", dto.NomeInstituicao);
                    _comand.Parameters.AddWithValue("@EnderecoInstituicao", dto.EnderecoInstituicao);
                    _comand.Parameters.AddWithValue("@TelefoneInstituicao", dto.TelefoneInstituicao);
                    _comand.Parameters.AddWithValue("@EmailInstituicao", dto.EmailInstituicao);
                    _comand.Parameters.AddWithValue("@Senha", dto.Senha);


                    //executa a informação
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
        internal Boolean deleteInstituicao(InstituicaoDTO dto)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName];
            using (SqlConnection conn = new SqlConnection(_stringDeConexao.ToString()))
            {
                try
                {
                    conn.Open();
                    var _delete = stringDeDelete;
                    SqlCommand _comman = new SqlCommand(_delete, conn);
                    _comman.Parameters.AddWithValue(idInstituicao, dto.IdInstituicao);
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

        internal Boolean updateInstituicao(InstituicaoDTO dto)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName];
            using (SqlConnection conn = new SqlConnection(_stringDeConexao.ToString()))
            {
                try
                {
                    conn.Open();
                    var _update = stringDeUpdate;
                    SqlCommand _comman = new SqlCommand(_update, conn);
                    _comman.Parameters.AddWithValue(idInstituicao, dto.IdInstituicao);
                    _comman.Parameters.AddWithValue("@cnpj", dto.cnpj);
                    _comman.Parameters.AddWithValue("@NomeInstituicao", dto.NomeInstituicao);
                    _comman.Parameters.AddWithValue("@EnderecoInstituicao", dto.EnderecoInstituicao);
                    _comman.Parameters.AddWithValue("@TelefoneInstituicao", dto.TelefoneInstituicao);
                    _comman.Parameters.AddWithValue("@EmailInstituicao", dto.EmailInstituicao);
                    _comman.Parameters.AddWithValue("@Senha", dto.Senha);
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

        internal InstituicaoDTO verificaLoginInstuicao(InstituicaoDTO dto)
        {

            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ToString();

            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    DataSet dtSet = new DataSet();
                    DataTable table = new DataTable();
                    InstituicaoDTO instituicao = new InstituicaoDTO();

                    conn.Open();
                    var sql = stringSelectLogin;
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@EmailInstituicao", dto.EmailInstituicao);
                    command.Parameters.AddWithValue("@Senha", dto.Senha);
                    command.CommandType = CommandType.Text;
                    dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);

                    dtAdapter.Fill(dtSet);
                    table = dtSet.Tables[0];

                    if (0 < table.Rows.Count)
                    {
                        instituicao.IdInstituicao = Convert.ToInt64(table.Rows[0]["IdInstituicao"].ToString());
                        instituicao.cnpj = table.Rows[0]["cnpj"].ToString();
                        instituicao.NomeInstituicao = table.Rows[0]["NomeInstituicao"].ToString();
                        return instituicao;
                    }
                    else return null;


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
    }

}
