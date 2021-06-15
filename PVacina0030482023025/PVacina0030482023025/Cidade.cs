using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PVacina0030482023025
{
    class Cidade
    {
        private int idCidade;
        private string nomeCidade;
        private string ufCidade;

        public int IdCidade
        {
            get
            {
                return idCidade;
            }
            set
            {
                idCidade = value;
            }
        }

        public string NomeCidade
        {
            get
            {
                return nomeCidade;
            }
            set
            {
                nomeCidade = value;
            }
        }

        public string UfCidade
        {
            get
            {
                return ufCidade;
            }
            set
            {
                ufCidade = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daCidade;

            DataTable dtCidade = new DataTable();

            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM Cidade", frmPrincipal.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidade;
        }
    }
}
