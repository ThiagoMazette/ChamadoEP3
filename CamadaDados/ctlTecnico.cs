using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CamadaModelos;
using System.Data;
using System.Data.OleDb;

namespace CamadaDados
{
    public class ctlTecnico
    {

        public static bool VerificarDuplicidade(string Nome)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Usuario\source\repos\Chamados\Chamados\bin\Debug\chamadosint.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            string qexiste = "select count(1) from tb_tecnicos where Nome = @Nome";
            OleDbCommand cmdver = new OleDbCommand(qexiste, ConexaoDB);

            cmdver.CommandType = CommandType.Text;
            OleDbParameter pmtnome = cmdver.CreateParameter();
            pmtnome.ParameterName = "@Nome";
            pmtnome.DbType = DbType.String;
            pmtnome.Value = Nome;
            cmdver.Parameters.Add(pmtnome);

            int verif = (int)cmdver.ExecuteScalar();
            if (verif > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CadastrarTecnico(string Nome, string Ramal)
        {
            bool RetornoInserir = false;
            return RetornoInserir;
        }

        public bool CadastrarTecnicoMDL(global::CamadaModelos.mdlTecnico _mdlTecnico)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Usuario\source\repos\Chamados\Chamados\bin\Debug\chamadosint.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            string Query = "insert into tb_tecnicos(Nome, Ramal) values(@Nome, @Ramal)";
            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);

            var pmtNome = cmd.CreateParameter();
            pmtNome.ParameterName = "@Nome";
            pmtNome.DbType = DbType.String;
            pmtNome.Value = _mdlTecnico.Nome;
            cmd.Parameters.Add(pmtNome);

            var pmtRamal = cmd.CreateParameter();
            pmtRamal.ParameterName = "@Ramal";
            pmtRamal.DbType = DbType.String;
            pmtRamal.Value = _mdlTecnico.Ramal;
            cmd.Parameters.Add(pmtRamal);

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
    }
}
