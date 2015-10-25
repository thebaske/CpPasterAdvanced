using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace CpPasterAdvanced
{//TODO: Make try catch blocks around critical areas, and solve the problem when inserting newline and slash!!! That is no good!!!
    public class ControlsDashboard
    {
        private static int _count = 0;
        private static int _maxNumber = 0;
        private static int _idNumber = _maxNumber + 1;
        private SQLiteConnection sqlite_connection = new SQLiteConnection("Data Source=PasterDatabase.db;Version=3;New=True;Compress=True;");
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
        public void InsertIntoDb(string Name, string pasteData)
        {
            StringBuilder commandString = new StringBuilder();
            commandString.Append("INSERT INTO PasterData (id_Name, DataToPaste) VALUES ('" + Name + "'," + " '" + pasteData + "');");
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = sqlite_connection.CreateCommand();
            sqlite_command.CommandText = commandString.ToString();
            //"INSERT INTO PasterData (id_Name, DataToPaste) VALUES ('btnName', 'Text 1111111');";
            sqlite_command.ExecuteNonQuery();
            sqlite_connection.Close();
        }
        //Returns Dictionary with two strings( button Name , and data to be pasted
        //From which we can populate any type of the control.

        public Dictionary<string,string> SelectRecords()
        {
            Dictionary<string, string> dataItems = new Dictionary<string, string>();
            string command = "SELECT * FROM PasterData";
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = sqlite_connection.CreateCommand();
            sqlite_command.CommandText = command;
            sqlite_datareader = sqlite_command.ExecuteReader();
            try
            {
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    string btnNameReader = sqlite_datareader.GetString(0);
                    string pasterDataReader = sqlite_datareader.GetString(1);
                    dataItems.Add(btnNameReader, pasterDataReader);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("The database is empty");
            }
            finally { sqlite_connection.Close(); }
            return dataItems;
        }

        public string SelectOneRecord(string queryWord)
        {
            string resultQuery = "";
            StringBuilder commandString = new StringBuilder();
            commandString.Append("SELECT * FROM PasterData WHERE id_Name = '" + queryWord + "';");
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = sqlite_connection.CreateCommand();
            sqlite_command.CommandText = commandString.ToString();
            sqlite_datareader = sqlite_command.ExecuteReader();
            try
            {
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    resultQuery = sqlite_datareader.GetString(1);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("There is no such record!!");
            }
            finally { sqlite_connection.Close(); }
            return resultQuery;
        }
       
        public void DeleteRecords(string Data)
        {
            StringBuilder deleteString = new StringBuilder();
            deleteString.Append("DELETE FROM PasterData WHERE DataToPaste = '" + Data + "';");
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = sqlite_connection.CreateCommand();
            sqlite_command.CommandText = deleteString.ToString();
            sqlite_datareader = sqlite_command.ExecuteReader();
            sqlite_connection.Close();
        }
    }
}
