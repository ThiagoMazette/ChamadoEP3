﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CamadaModelos;
using System.Data;
using System.Data.OleDb;


namespace CamadaDados
{
    public class ctlEmpresa
    {
        public bool Pesquisar(string CNPJ)
        {
            bool RetornoPesquisar = false;
            return RetornoPesquisar;
        }

        public static bool VerificarDuplicidade(string CNPJ)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosint.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            string qexiste = "select count(1) from tb_empresas where CNPJ = @CNPJ";
            OleDbCommand cmdver = new OleDbCommand(qexiste, ConexaoDB);

            cmdver.CommandType = CommandType.Text;
            OleDbParameter pmtcnpj = cmdver.CreateParameter();
            pmtcnpj.ParameterName = "@CNPJ";
            pmtcnpj.DbType = DbType.String;
            pmtcnpj.Value = CNPJ;
            cmdver.Parameters.Add(pmtcnpj);

            int verif = (int)cmdver.ExecuteScalar();
            if (verif > 0)
            {
                ConexaoDB.Close();
                return true;
            }
            else
            {
                ConexaoDB.Close();
                return false;
            }
        }

        public DataTable PesquisarMDL(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\EP3.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            string Query = "select chvbfj, cnpjcpf, rzs from bfj where ";

            if(_mdlEmpresa.FiltroAbrirChamado == "CNPJ")
            {
                //Query += "cnpjcpf LIKE \"%\" + @Filtro + \"%\""; procura qualquer parte
                Query += "cnpjcpf LIKE + @Filtro + \"%\"";
            }
            else if(_mdlEmpresa.FiltroAbrirChamado == "Nome")
            {
                Query += "rzs LIKE \"%\" + @Filtro + \"%\"";
            }
            Query += " order by rzs";

            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            cmd.CommandType = CommandType.Text;
            OleDbParameter pmtFiltro = cmd.CreateParameter();
            pmtFiltro.ParameterName = "@Filtro";
            pmtFiltro.DbType = DbType.String;
            pmtFiltro.Value = _mdlEmpresa.FiltrotxtProcurar;
            cmd.Parameters.Add(pmtFiltro);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable empresas = new DataTable();
            da.Fill(empresas);
            ConexaoDB.Close();
            return empresas;
        }

        public bool AbrirSoChamado(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosint.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();

            string Query = "insert into tb_chamados(aberto, fk_idempresa, data) values(@aberto, @fk_idempresa, @data);";
            
            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            var pmtAbrirChamado = cmd.CreateParameter();
            pmtAbrirChamado.ParameterName = "@aberto";
            pmtAbrirChamado.DbType = DbType.String;
            pmtAbrirChamado.Value = "1";
            cmd.Parameters.Add(pmtAbrirChamado);

            var pmtfkidempresa = cmd.CreateParameter();
            pmtfkidempresa.ParameterName = "@fk_idempresa";
            pmtfkidempresa.DbType = DbType.String;
            pmtfkidempresa.Value = _mdlEmpresa.ID;
            cmd.Parameters.Add(pmtfkidempresa);

            DateTime dataAtu = DateTime.Now;
            var pmtData = cmd.CreateParameter();
            pmtData.ParameterName = "@data";
            pmtData.DbType = DbType.String;
            pmtData.Value = dataAtu;
            cmd.Parameters.Add(pmtData);

            if (cmd.ExecuteNonQuery() > 0)
            {
                ConexaoDB.Close();
                return true;
            }
            else
            {
                ConexaoDB.Close();
                return false;
            }

        }

        public bool AbrirChamadoCompleto(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosint.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();

            string Query = "insert into tb_chamados(aberto, fk_idempresa, data) values(@aberto, @fk_idempresa, @data);";

            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            var pmtAbrirChamado = cmd.CreateParameter();
            pmtAbrirChamado.ParameterName = "@aberto";
            pmtAbrirChamado.DbType = DbType.String;
            pmtAbrirChamado.Value = "1";
            cmd.Parameters.Add(pmtAbrirChamado);

            var pmtfkidempresa = cmd.CreateParameter();
            pmtfkidempresa.ParameterName = "@fk_idempresa";
            pmtfkidempresa.DbType = DbType.String;
            pmtfkidempresa.Value = _mdlEmpresa.ID;
            cmd.Parameters.Add(pmtfkidempresa);

            DateTime dataAtu = DateTime.Now;
            var pmtData = cmd.CreateParameter();
            pmtData.ParameterName = "@data";
            pmtData.DbType = DbType.String;
            pmtData.Value = dataAtu;
            cmd.Parameters.Add(pmtData);

            if (cmd.ExecuteNonQuery() > 0)
            {
                ConexaoDB.Close();
            }
            else
            {
                ConexaoDB.Close();
            }

            string ConexaoAccess1 = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosint.mdb";
            OleDbConnection ConexaoDB1 = new OleDbConnection(ConexaoAccess1);
            ConexaoDB1.Open();
            string Query1 = "insert into tb_empresas(id, cnpj, nome) values(@id, @cnpj, @nome);";
            OleDbCommand cmd1 = new OleDbCommand(Query1, ConexaoDB1);

            var pmtId = cmd1.CreateParameter();
            pmtId.ParameterName = "@id";
            pmtId.DbType = DbType.String;
            pmtId.Value = _mdlEmpresa.ID;
            cmd1.Parameters.Add(pmtId);

            var pmtCNPJ = cmd1.CreateParameter();
            pmtCNPJ.ParameterName = "@cnpj";
            pmtCNPJ.DbType = DbType.String;
            pmtCNPJ.Value = _mdlEmpresa.CNPJ;
            cmd1.Parameters.Add(pmtCNPJ);

            var pmtnome = cmd1.CreateParameter();
            pmtnome.ParameterName = "@nome";
            pmtnome.DbType = DbType.String;
            pmtnome.Value = _mdlEmpresa.Nome;
            cmd1.Parameters.Add(pmtnome);



            if (cmd1.ExecuteNonQuery() > 0)
            {
                ConexaoDB1.Close();
                return true;
            }
            else
            {
                ConexaoDB1.Close();
                return false;
            }
        }

        public DataTable CarregarOutrosChamados(CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosint.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            string Query = "select * from tb_chamados where fk_idempresa=@empresaid AND aberto='0' order by id desc";
            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            cmd.CommandType = CommandType.Text;
            OleDbParameter pmtempresa = cmd.CreateParameter();
            pmtempresa.ParameterName = "@empresaid";
            pmtempresa.DbType = DbType.String;
            pmtempresa.Value = _mdlEmpresa.txtEmpresaID;
            cmd.Parameters.Add(pmtempresa);
            
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable empresas = new DataTable();
            da.Fill(empresas);
            ConexaoDB.Close();
            return empresas;

        }

        public bool FinalizarChamado(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosint.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();

            string Query = "update tb_chamados " +
                "set " +
                "aberto=@aberto, " +
                "fk_idtecnico=@tec, " +
                "atendimento=@atendimento, " +
                "resumo=@resumo, " +
                "dataFinal=@dataFinal, " +
                "telefone=@telefone, " +
                "contato=@contato " +
                "where id = @id";
           
            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);
            cmd.CommandType = CommandType.Text;

            var pmtFecharChamado = cmd.CreateParameter();
            pmtFecharChamado.ParameterName = "@aberto";
            pmtFecharChamado.DbType = DbType.String;
            pmtFecharChamado.Value = "0";
            cmd.Parameters.Add(pmtFecharChamado);

            var pmttec = cmd.CreateParameter();
            pmttec.ParameterName = "@tec";
            pmttec.DbType = DbType.String;
            pmttec.Value = _mdlEmpresa.cbbTecnico;
            cmd.Parameters.Add(pmttec);

            var pmtAtendimento = cmd.CreateParameter();
            pmtAtendimento.ParameterName = "@atendimento";
            pmtAtendimento.DbType = DbType.String;
            pmtAtendimento.Value = _mdlEmpresa.Atendimento;
            cmd.Parameters.Add(pmtAtendimento);

            var pmtResumo = cmd.CreateParameter();
            pmtResumo.ParameterName = "@resumo";
            pmtResumo.DbType = DbType.String;
            pmtResumo.Value = _mdlEmpresa.Resumo;
            cmd.Parameters.Add(pmtResumo);

            DateTime dataFim = DateTime.Now;
            var pmtDataF = cmd.CreateParameter();
            pmtDataF.ParameterName = "@dataFinal";
            pmtDataF.DbType = DbType.String;
            pmtDataF.Value = dataFim;
            cmd.Parameters.Add(pmtDataF);

            var pmtTelefone = cmd.CreateParameter();
            pmtTelefone.ParameterName = "@telefone";
            pmtTelefone.DbType = DbType.String;
            pmtTelefone.Value = _mdlEmpresa.Telefone;
            cmd.Parameters.Add(pmtTelefone);

            var pmtContato = cmd.CreateParameter();
            pmtContato.ParameterName = "@contato";
            pmtContato.DbType = DbType.String;
            pmtContato.Value = _mdlEmpresa.Contato;
            cmd.Parameters.Add(pmtContato);

            var pmtID = cmd.CreateParameter();
            pmtID.ParameterName = "@id";
            pmtID.DbType = DbType.String;
            pmtID.Value = _mdlEmpresa.ID;
            cmd.Parameters.Add(pmtID);

            cmd.ExecuteNonQuery();
            int resultado = cmd.ExecuteNonQuery();
            ConexaoDB.Close();
            return resultado > 0; 
        } 

        public DataTable ListarChamado(CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoA = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosint.mdb";
            OleDbConnection BancoA = new OleDbConnection(ConexaoA);
            BancoA.Open();

            string Query = "select tb_empresas.id, tb_empresas.nome, tb_chamados.fk_idempresa, tb_chamados.data, tb_chamados.id, tb_chamados.contato, tb_chamados.telefone, tb_chamados.fk_idtecnico, tb_chamados.resumo, tb_chamados.atendimento " +
                        "FROM tb_empresas" +
                        " inner join tb_chamados " +
                        "on tb_chamados.fk_idempresa = tb_empresas.id where tb_chamados.aberto = '1' order by tb_chamados.id desc";

            OleDbCommand cmd = new OleDbCommand(Query, BancoA);
            cmd.CommandType = CommandType.Text;
            
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable lista = new DataTable();
            da.Fill(lista);
            BancoA.Close();
            return lista;
        }

        public DataTable ListagemResultado(CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosint.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            //ok string Query = "select * from tb_chamados ";
            string Query = "SELECT tb_chamados.data, tb_empresas.nome, tb_chamados.resumo, tb_chamados.fk_idtecnico, tb_chamados.dataFinal, tb_chamados.atendimento, tb_chamados.telefone, tb_chamados.contato " +
                "FROM tb_chamados " +
                "INNER JOIN tb_empresas " +
                "ON tb_chamados.fk_idempresa = tb_empresas.id ";

            if (_mdlEmpresa.FiltrotxtProcurar == "" && _mdlEmpresa.cbbTecnico != "Todos")
            {
                Query += "where fk_idtecnico=@tecnico";

                OleDbCommand cmdT = new OleDbCommand(Query, ConexaoDB);

                var pmtTecnicoSelecionadoT = cmdT.CreateParameter();
                pmtTecnicoSelecionadoT.ParameterName = "@tecnico";
                pmtTecnicoSelecionadoT.DbType = DbType.String;
                pmtTecnicoSelecionadoT.Value = _mdlEmpresa.cbbTecnico;
                cmdT.Parameters.Add(pmtTecnicoSelecionadoT);

                OleDbDataAdapter daT = new OleDbDataAdapter(cmdT);
                DataTable empresasT = new DataTable();
                daT.Fill(empresasT);
                ConexaoDB.Close();
                return empresasT;
            }
            else if (_mdlEmpresa.FiltrotxtProcurar == "" && _mdlEmpresa.cbbTecnico == "Todos")
            {
                Query += "";
            }
            else if (_mdlEmpresa.cbbTecnico == "Todos")
            {
 
              /*        Query = "select * " +
                        "FROM tb_empresas" +
                        " inner join tb_chamados " +
                        "on tb_chamados.fk_idempresa = tb_empresas.id where fk_idempresa=@EmpresaSelecionada";
             Aparccer nome */
                Query += "where fk_idempresa=@EmpresaSelecionada";
            }

            else 
            {
                Query += "where fk_idempresa=@EmpresaSelecionada AND fk_idtecnico=@tecnico";
            }

            Query += " order by tb_chamados.id desc";

            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            var pmtEmpresaSelecionada = cmd.CreateParameter();
            pmtEmpresaSelecionada.ParameterName = "@EmpresaSelecionada";
            pmtEmpresaSelecionada.DbType = DbType.String;
            pmtEmpresaSelecionada.Value = _mdlEmpresa.FiltrotxtProcurar;
            cmd.Parameters.Add(pmtEmpresaSelecionada);

            var pmtTecnicoSelecionado = cmd.CreateParameter();
            pmtTecnicoSelecionado.ParameterName = "@tecnico";
            pmtTecnicoSelecionado.DbType = DbType.String;
            pmtTecnicoSelecionado.Value = _mdlEmpresa.cbbTecnico;
            cmd.Parameters.Add(pmtTecnicoSelecionado);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable empresas = new DataTable();
            da.Fill(empresas);
            ConexaoDB.Close();
            return empresas;
        }

        public DataTable PesquisaResumo(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\EP3.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();

            string Query = "Select rec.chvbfj, rec.chvori, rec.dt_dem, vndB.chvvnda, vndB.chvps, ps.chvps, ps.Dsc " +
                   "From (( " +
                   "rec " +
                   "inner join vndB " +
                   "on vndB.chvvnda = rec.chvori) " +
                   "inner join ps " +
                   "on ps.chvps = vndB.chvps) " +
                   "where rec.chvbfj=@id order by rec.dt_dem desc"; // ps.Dsc";

            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            cmd.CommandType = CommandType.Text;
            OleDbParameter pmtID = cmd.CreateParameter();
            pmtID.ParameterName = "@id";
            pmtID.DbType = DbType.String;
            pmtID.Value = _mdlEmpresa.ID;
            cmd.Parameters.Add(pmtID); 

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable empresas = new DataTable();
            da.Fill(empresas);
            ConexaoDB.Close();
            return empresas;
        }

        public DataTable PesquisaFollowUP(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\EP3.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();

            string Query = "Select chvent, M_desc, Dt_fwu " +
                   "From fwu " +
                   "where chvent=@id order by Dt_fwu desc";

            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            cmd.CommandType = CommandType.Text;
            OleDbParameter pmtID = cmd.CreateParameter();
            pmtID.ParameterName = "@id";
            pmtID.DbType = DbType.String;
            pmtID.Value = _mdlEmpresa.ID;
            cmd.Parameters.Add(pmtID);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable empresas = new DataTable();
            da.Fill(empresas);
            ConexaoDB.Close();
            return empresas;
        }


        public bool SalvarChamado(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosint.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();

            string Query = "update tb_chamados " +
                "set " +
                "fk_idtecnico=@tec, " +
                "atendimento=@atendimento, " +
                "resumo=@resumo, " +
                "telefone=@telefone, " +
                "contato=@contato " +
                "where id = @id";

            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);
            cmd.CommandType = CommandType.Text;

            var pmttec = cmd.CreateParameter();
            pmttec.ParameterName = "@tec";
            pmttec.DbType = DbType.String;
            pmttec.Value = _mdlEmpresa.cbbTecnico;
            cmd.Parameters.Add(pmttec);

            var pmtAtendimento = cmd.CreateParameter();
            pmtAtendimento.ParameterName = "@atendimento";
            pmtAtendimento.DbType = DbType.String;
            pmtAtendimento.Value = _mdlEmpresa.Atendimento;
            cmd.Parameters.Add(pmtAtendimento);

            var pmtResumo = cmd.CreateParameter();
            pmtResumo.ParameterName = "@resumo";
            pmtResumo.DbType = DbType.String;
            pmtResumo.Value = _mdlEmpresa.Resumo;
            cmd.Parameters.Add(pmtResumo);

            var pmtTelefone = cmd.CreateParameter();
            pmtTelefone.ParameterName = "@telefone";
            pmtTelefone.DbType = DbType.String;
            pmtTelefone.Value = _mdlEmpresa.Telefone;
            cmd.Parameters.Add(pmtTelefone);

            var pmtContato = cmd.CreateParameter();
            pmtContato.ParameterName = "@contato";
            pmtContato.DbType = DbType.String;
            pmtContato.Value = _mdlEmpresa.Contato;
            cmd.Parameters.Add(pmtContato);

            var pmtID = cmd.CreateParameter();
            pmtID.ParameterName = "@id";
            pmtID.DbType = DbType.String;
            pmtID.Value = _mdlEmpresa.ID;
            cmd.Parameters.Add(pmtID);

            cmd.ExecuteNonQuery();
            int resultado = cmd.ExecuteNonQuery();
            ConexaoDB.Close();
            return resultado > 0;
        }

        public string DataBloqueio(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\EP3.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();

            string Query = "Select Dt_Bloq from cli where chvbfj=@id";

            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            cmd.CommandType = CommandType.Text;
            OleDbParameter pmtID = cmd.CreateParameter();
            pmtID.ParameterName = "@id";
            pmtID.DbType = DbType.String;
            pmtID.Value = _mdlEmpresa.txtAbrirChamadoID;
            cmd.Parameters.Add(pmtID);

            OleDbDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                return myReader["Dt_Bloq"].ToString();
            }
            ConexaoDB.Close();
            return string.Empty;

            /* 1 DataSet ds = new DataSet();
             if (da.Fill(ds) != 0)
             {
                 for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                 {
                     _mdlEmpresa.txtDataBloqueio = ds.Tables[0].Rows[i]["Dt_Bloq"].ToString();
                 }
             }

             return _mdlEmpresa.txtDataBloqueio; 1 */
        }

        public DataTable PesquisarTelefones(global::CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\EP3.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();

            string Query = "SELECT tel1, tel2, tel3, tel4, tel5 FROM ende WHERE chvbfj=@id";

            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            cmd.CommandType = CommandType.Text;
            OleDbParameter pmtID = cmd.CreateParameter();
            pmtID.ParameterName = "@id";
            pmtID.DbType = DbType.String;
            pmtID.Value = _mdlEmpresa.ID;
            cmd.Parameters.Add(pmtID);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable telefones = new DataTable();
            da.Fill(telefones);
            ConexaoDB.Close();
            return telefones;
        }

        /* TESTE public DataTable ListagemResultadoTESTE(CamadaModelos.mdlEmpresa _mdlEmpresa)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\REP_SERVER\publica2\Thiago\Meus Documentos\Visual Studio 2017\Chamados\Chamados\bin\Debug\chamadosint.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            //  string Query = "select * from tb_chamados ";
            // ok string Query = "select tb_empresas.nome, tb_empresas.id, tb_chamados.fk_idempresa, tb_chamados.fk_idtecnico, tb_chamados.resumo, tb_chamados.data, tb_chamados.dataFinal, tb_chamados.telefone, tb_chamados.contato from tb_chamados inner join tb_empresas on tb_chamados.fk_idempresa=tb_empresas.id";
            string Query = "select tb_chamados.data, tb_empresas.nome, tb_chamados.resumo, tb_chamados.fk_idtecnico, tb_chamados.dataFinal, tb_chamados.atendimento, tb_chamados.telefone, tb_chamados.contato from tb_chamados inner join tb_empresas on tb_chamados.fk_idempresa=tb_empresas.id";

            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable empresas = new DataTable();
            da.Fill(empresas);
            ConexaoDB.Close();
            return empresas;
        } */




        /* public void AtenderChamado()
        {
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                mdlChamados.Chamado.Resposta = reader["chamado_resposta"].ToString();
                mdlChamados.Chamado.Status = reader["chamado_status"].ToString();
                mdlChamados.Chamado.Descricao = reader["descricao"].ToString();
                mdlChamados.Chamado.Motivo = reader["descricao_motivo"].ToString();
                mdlChamados.Chamado.Empresa = reader["nome_empresa"].ToString();
                mdlChamados.Chamado.NomeUsuario = reader["nome_usuario"].ToString();
                mdlChamados.Chamado.Aberto = reader["Aberto"].ToString();
                mdlChamados.Chamado.Fechado = reader["Fechado"].ToString();
            }
            reader.Close();
            conexao.Fechar();

        } */



    }


}
