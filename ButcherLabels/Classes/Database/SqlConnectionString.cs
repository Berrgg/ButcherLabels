namespace ButcherLabels.Classes.Database
{
    public class SqlConnectionString : IConnectionString
    {
        public string _userName { get; private set; }
        public string _password { get; private set; }
        public string _database { get; private set; }
        public string _server { get; private set; }

        public SqlConnectionString(string serverName, string databaseName, string userName, string password)
        {
            _server = serverName;
            _database = databaseName;
            _userName = userName;
            _password = password;
        }

        public string ConnString()
        {
            return string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                                _server, _database, _userName, _password);
        }
    }
}
