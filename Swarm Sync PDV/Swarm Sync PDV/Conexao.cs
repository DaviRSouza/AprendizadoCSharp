﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Swarm_Sync_PDV
{
    public class Conexao
    {
        public string connect = "Server=tcp:swarm-sync.database.windows.net,1433;Database=PDV SWARM SYNC;User ID=adm;Password=Moden2005;Trusted_Connection=False;Encrypt=True;";
        
        public SqlConnection conn = null;

        public void AbrirConexao()
        {
            try
            {
                conn = new SqlConnection(connect);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexao com o Banco de dados ->" + ex.Message);
            }
        }
        public void FecharConexao()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn = new SqlConnection(connect);
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão com o banco de dados ->" + ex.Message);
            }
        }
    }
}
