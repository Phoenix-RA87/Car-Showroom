using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Car_Showroom
{
    class DataBase
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-9VBOF0G;Initial Catalog=Roman_Kursovoy;Integrated Security=True");


        public void openConnection()
        { 
           if (SqlConnection.State  == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }


        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return SqlConnection;
        }
    }
}
