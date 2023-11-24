using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Data.SqlServer.DataContexto
{
    internal static class SqlServerConnection
    {
        internal static string Conexao => @"Data Source=.\SQLEXPRESS;Initial Catalog=EscritorioABC;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";
    }
}
 