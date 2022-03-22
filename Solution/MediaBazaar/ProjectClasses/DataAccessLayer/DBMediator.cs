using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public abstract class DBMediator
    {
        private MySqlConnection dbConnection;
        //MainDatabase
        private string server = "studmysql01.fhict.local";
        private string database = "dbi467491";
        private string uid = "dbi467491";
        private string password = "bulcari";
        //TestDatabase
        private string testDatabase = "dbi450701";
        private string testUId = "dbi450701";
        private string testPassword = "kokokarakolelo@1256";

        public MySqlConnection DbConnection
        {
            get { return dbConnection; }
        }

        public DBMediator(DatabaseType databaseType)
        {
            if (databaseType == DatabaseType.MAIN)
            {
                dbConnection = new MySqlConnection($"server={server};database={database};uid={uid};password={password};");
            }
            else if (databaseType == DatabaseType.TEST)
            {
                dbConnection = new MySqlConnection($"server={server};database={testDatabase};uid={testUId};password={testPassword};");
            }
        }
    }
}