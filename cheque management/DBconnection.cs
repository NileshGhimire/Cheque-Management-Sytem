using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace cheque_management
{
    public class DBconnection
    {
        public static SqlConnection DBConnect()
        {
            var conn = new SqlConnection();
            conn.ConnectionString = @"Data source=DESKTOP-6RK3T5S;Initial Catalog=Chequemanagement;" +
"Integrated Security=true";
           
            if (conn.State != ConnectionState.Open)
            {

                conn.Open();

            }
            return conn;
           
         
        }

        public static DataTable gettablebyquery(string SqlQuery)
        {
            
                SqlCommand command = new SqlCommand();
                command.Connection = DBConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
             

           
            }

        public static void ExecuteNonQuery(string SqlQuery)
        {
            
                SqlCommand command = new SqlCommand();
                command.Connection = DBConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
           
             

        }
       
     
    }
}
        
    
