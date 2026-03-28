namespace Customer.Ado
{
    public static class Sqls
    {
        public const string GetALL = "select * from dbo.Customer";
        public const string GetByName = "select * from Customer where name = @Name";
        public const string InsertCustomer = "insert into Customer values(@Name)";
    }
}
