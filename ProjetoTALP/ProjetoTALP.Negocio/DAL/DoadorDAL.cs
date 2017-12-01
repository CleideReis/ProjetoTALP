using ProjetoTALP.Negocio.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoTALP.Negocio.DAL
{
    class DoadorDAL
    {
        String stringDeUpdate = "UPDATE dbo.Doador SET cpf=@cpf,Nome=LOWER(@Nome), Endereco=@Endereco, Telefone=@Telefone, Email=@Email, Senha=HASHBYTES('SHA2_512', @Senha) WHERE IdDoador = (@IdDoador)";
        String stringDeInsert = "INSERT INTO Doador (cpf, Nome, Endereco, Telefone, Email, Senha) VALUES (@cpf, LOWER(@Nome), @Endereco, @Telefone, @Email, HASHBYTES('SHA2_512', @Senha))";
        String stringDeDelete = "DELETE dbo.Doador WHERE IdDoador = (@IdDoador)";
        String stringDeSelect = "SELECT IdDoador, cpf, Nome, Endereco, Telefone, Email, Senha FROM Doador ORDER BY Nome";
        String idDoador = "@IdDoador";
        String stringSelectLogin = "SELECT IdDoador, cpf, Nome FROM DBHelpme.dbo.Doador WHERE Email = @Email AND Senha = HASHBYTES('SHA2_512',@Senha)";
        String connectionName = "ConexaoPadrao";
        internal DataTable selectDoador()
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
       
        internal Boolean insertDoador(DoadorDTO dto)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ToString();

            {
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
                try
                {

                    //abre o BD
                    conn.Open();

                    // prepara o comando para enviar ao BD
                    var _insert = stringDeInsert;

                    //utiliza o sqlcommand para enviar os dados ao BD
                    SqlCommand _comand = new SqlCommand(_insert, conn);

                    //seta o valor do parametro que o BD está esperando
                    _comand.Parameters.AddWithValue("@cpf", dto.cpf);
                    _comand.Parameters.AddWithValue("@Nome", dto.Nome);
                    _comand.Parameters.AddWithValue("@Endereco", dto.Endereco);
                    _comand.Parameters.AddWithValue("@Telefone", dto.Telefone);
                    _comand.Parameters.AddWithValue("@Email", dto.Email);
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

        internal DoadorDTO verificaLoginDoador(DoadorDTO dto)
        {

            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ToString();

            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    DataSet dtSet = new DataSet();
                    DataTable dados = new DataTable();
                    DoadorDTO doador = new DoadorDTO();

                    conn.Open();
                    var sql = stringSelectLogin;
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@Email", dto.Email);
                    command.Parameters.AddWithValue("@Senha", dto.Senha);
                    command.CommandType = CommandType.Text;
                    dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);

                    dtAdapter.Fill(dtSet);
                    dados = dtSet.Tables[0];

                    if (0 < dados.Rows.Count)
                    {
                        doador.IdDoador = Convert.ToInt64(dados.Rows[0]["IdDoador"].ToString());
                        doador.cpf = dados.Rows[0]["cpf"].ToString();
                        doador.Nome = dados.Rows[0]["Nome"].ToString();
                        return doador;
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

        internal Boolean deleteDoador(DoadorDTO dto)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName];
            using (SqlConnection conn = new SqlConnection(_stringDeConexao.ToString()))
            {
                try
                {
                    conn.Open();
                    var _delete = stringDeDelete;
                    SqlCommand _comman = new SqlCommand(_delete, conn);
                    _comman.Parameters.AddWithValue(idDoador, dto.IdDoador);
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

        internal Boolean updateDoador(DoadorDTO dto)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName];
            using (SqlConnection conn = new SqlConnection(_stringDeConexao.ToString()))
            {
                try
                {
                    conn.Open();
                    var _update = stringDeUpdate;
                    SqlCommand _comman = new SqlCommand(_update, conn);
                    _comman.Parameters.AddWithValue(idDoador, dto.IdDoador);
                    _comman.Parameters.AddWithValue("@cpf", dto.cpf);
                    _comman.Parameters.AddWithValue("@Nome", dto.Nome);
                    _comman.Parameters.AddWithValue("@Endereco", dto.Endereco);
                    _comman.Parameters.AddWithValue("@Telefone", dto.Telefone);
                    _comman.Parameters.AddWithValue("@Email", dto.Email);
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
    }
}
