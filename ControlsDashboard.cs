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
        private SQLiteConnection sqlite_connection = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
        private SQLiteCommand sqlite_command = new SQLiteCommand();
        SQLiteDataReader sqlite_datareader;

        
        public void CountRecords()
        {
            string command = "SELECT * FROM PasterData";
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = sqlite_connection.CreateCommand();
            sqlite_command.CommandText = command;
            sqlite_datareader = sqlite_command.ExecuteReader();
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
            StringBuilder commandInsert = new StringBuilder();
            commandInsert.Append("INSERT INTO PasterData (id, buttonName, dataToPaste) VALUES (" + _idNumber + "," + " '" + btnName + "'," + " '" + pasteData + "');");
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = sqlite_connection.CreateCommand();
            sqlite_command.CommandText = commandInsert.ToString();
            //"INSERT INTO PasterData (id, buttonName, dataToPaste) VALUES (1, 'btnName', 'Text 1111111');";
            sqlite_command.ExecuteNonQuery();
            sqlite_connection.Close();
        }
        //Returns Dictionary with two strings( button Name , and data to be pasted
        //From which we can populate any type of the control.
        public Dictionary<string,string> SelectRecords(string btnName)
        {
            Dictionary<string, string> dataItems = new Dictionary<string, string>();
            string command = "SELECT * FROM PasterData";
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = sqlite_connection.CreateCommand();
            sqlite_command.CommandText = command;
            sqlite_datareader = sqlite_command.ExecuteReader();
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                string btnNameReader = sqlite_datareader.GetString(1);
                string pasterDataReader = sqlite_datareader.GetString(2);
                dataItems.Add(btnNameReader, pasterDataReader);
            }
            sqlite_connection.Close();
            return dataItems;
        }
       
        public void DeleteRecords(string btnName)
        {
            //StringBuilder deleteString = new StringBuilder();
            //deleteString.Append("DELETE FROM PasterData WHERE buttonName = '"+ btnName +"';");
            //sqlite_cmd.CommandText = deleteString.ToString();
            //ConnectionControl("Open");
            //sqlite_datareader = sqlite_cmd.ExecuteReader();
        }
    }
}
