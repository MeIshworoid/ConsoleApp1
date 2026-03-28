using Microsoft.Data.SqlClient;
using System.Data;

namespace Customer.Ado
{
    public class DAO
    {
        //read
        public DataTable GetAllData(SqlParameter[] sqlParameters = null)
        {
            DataTable dtCustomer = new DataTable();

            //var sqldataadapter = SqlHandler.FetchWithClose(Sqls.GetALL, parameters);
            //sqldataadapter.Fill(dtCustomer);

            var connection = SqlHandler.GetConnection();

            SqlCommand cmd = new SqlCommand(Sqls.GetALL, connection);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dtCustomer);

            return dtCustomer;
        }

        public Customer GetByName(string name)
        {
            //customer object
            Customer customer = new Customer();

            //preapare parameters
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Name",name)
            };

            //get reader
            var reader = SqlHandler.FetchWithOpen(Sqls.GetByName, sqlParameters);

            //process data came from db
            while (reader.Read())
            {
                customer.Id = (int)reader["Id"];
                customer.Name = reader["Name"].ToString();
            }

            return customer;
        }

        //dml insert,update,delete
        public int UpdateData(string sql, SqlParameter[] sqlParameters = null)
        {
            return SqlHandler.UpdateData(sql, sqlParameters);
        }
    }
}
