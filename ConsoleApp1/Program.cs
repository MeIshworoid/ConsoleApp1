using Customer.Ado;
using System;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //getall
            DAO dao = new DAO();

            foreach (DataRow row in dao.GetAllData().Rows)
            {

                Console.WriteLine($"Customer Id: {row["Id"]}\n Customer Name: {row["Name"]}");
            }

            //insert
            //string name = "Manoj";
            //SqlParameter[] sqlParameters = new SqlParameter[]
            //{
            //    new SqlParameter("@Name",name)
            //};
            //int result = dao.UpdateData(Sqls.InsertCustomer, sqlParameters);

            //if (result > 0)
            //{
            //    Console.WriteLine("Customer inserted successuflly");
            //}

            ////getallbyname
            //DataTable dtCustomersByName = dao.GetAllData(parameters);

            ////getbyname
            //var customer = dao.GetByName(name);
            //Console.WriteLine($"Customer Id:{customer.Id}\n Customer Name: {customer.Name}");

            //TODO: update

            //TODO: delete

            //TODO: use storedprocedure for all

        }
    }
}
