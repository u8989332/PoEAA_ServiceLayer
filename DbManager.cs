using System.Data.SQLite;

namespace PoEAA_ServiceLayer
{
    public static class DbManager
    {
        public static SQLiteConnection CreateConnection()
        {
            return new SQLiteConnection("Data Source=poeaa_transactionscript.db");
        }
    }
}