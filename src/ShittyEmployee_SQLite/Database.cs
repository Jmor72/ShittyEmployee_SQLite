using System.Data.SQLite;

namespace ShittyEmployee_SQLite
{
    class Database
    {
        public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;

        public Database()
        {
            sqlite_conn = new SQLiteConnection("Data Source=EmployeeDB.sqlite3");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            //SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=EmployeeDB.sqlite3;version=3.8.8.3;");
        }
    }
}
