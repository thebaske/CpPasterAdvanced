using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Finisar.SQLite;

namespace CpPasterAdvanced
{
    public class ControlsDashboard
    {
        private static int _count = 0;
        private static int _maxNumber = 0;
        private static int _idNumber = _maxNumber + 1;

        
        SQLiteConnection sqlite_conn;

        SQLiteCommand sqlite_cmd;

        SQLiteDataReader sqlite_datareader;



        // create a new database connection:
        public void ConnectionControl(string status)
        {
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            switch (status)
            {
                case "Open":
                    sqlite_conn.Open();
                    break;
                case "Close":
                    sqlite_conn.Close();
                    break;
            }
            
        }
        //Counts the records in the database
        public void CountRecords()
        {
            sqlite_cmd.CommandText = "SELECT * FROM PasterData";
            ConnectionControl("Open");
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {     
                string myreader = sqlite_datareader.GetString(0);
                if (_maxNumber < Convert.ToInt32(myreader))
                {
                    _maxNumber = Convert.ToInt32(myreader); 
                }
                _count++;
            }
        }
        //Inserts records with provided btnName(as name for the button or list Item) and
        //pasteData( as actual data to be pasted from the clipboard)
        public void InsertIntoDb(string btnName, string pasteData)
        {
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Lets insert something into our new table:
            StringBuilder commandInsert = new StringBuilder();
            commandInsert.Append("INSERT INTO PasterData (id, buttonName, dataToPaste) VALUES (" + _idNumber + "," + " '" + btnName + "'," + " '" + pasteData + "');");
            sqlite_cmd.CommandText = commandInsert.ToString();
            //"INSERT INTO PasterData (id, buttonName, dataToPaste) VALUES (1, 'btnName', 'Text 1111111');";
            ConnectionControl("Open");
            sqlite_cmd.ExecuteNonQuery();
            ConnectionControl("Close");
        }
        //Returns Dictionary with two strings( button Name , and data to be pasted
        //From which we can populate any type of the control.
        public Dictionary<string,string> SelectRecords(string btnName)
        {
            Dictionary<string, string> dataItems = new Dictionary<string, string>();
            sqlite_cmd.CommandText = "SELECT * FROM PasterData";
            ConnectionControl("Open");
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                string btnNameReader = sqlite_datareader.GetString(1);
                string pasterDataReader = sqlite_datareader.GetString(2);
                dataItems.Add(btnNameReader, pasterDataReader);
            }
            ConnectionControl("Close");
            return dataItems;
        }
        //Selects all records from database
        public SqlDataReader
        //Deletes provided record form the database
        public void DeleteRecords(string btnName)
        {
            StringBuilder deleteString = new StringBuilder();
            deleteString.Append("DELETE FROM PasterData WHERE buttonName = '"+ btnName +"';");
            sqlite_cmd.CommandText = deleteString.ToString();
            ConnectionControl("Open");
            sqlite_datareader = sqlite_cmd.ExecuteReader();
        }
    }
}
