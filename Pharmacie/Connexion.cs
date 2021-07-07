using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Pharmacie
{
    class Connexion
    {
        public static SqlConnection openConnection() {
            SqlConnection con = new SqlConnection(@"Data Source=MAMOUNY078\SQLEXPRESS;Initial Catalog=pharmacie;Integrated Security=True");
            return con;
        }
    }
}
