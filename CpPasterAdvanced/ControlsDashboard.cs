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
        public int MaxNumber {
            get
            {
                return _maxNumber;
            }
            
        }

        //TODO: Doesn't accept  single quote
        //TODO: improve focus lost checking
        //TODO: Consider making the database with unique index key!! so you can delete an item based on table selection/ or 
        //TODO: change the delete method to accept string from the grid.
        //TODO: Make delete button dissapear when nothing is selected/ or make it read delete parameter from the grid.
        //TODO: Make append/change function.
        //TODO: Test github new master branch

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

        public void InsertIntoDb(string Name, string pasteData)
        {
            string pasterTextData = ReplaceNewlineWithCharacter(pasteData);
            StringBuilder commandString = new StringBuilder();
            commandString.Append(@"INSERT INTO PasterData (id_Name, DataToPaste) VALUES ('" + @Name + "'," + "'" + pasterTextData + "');");
            sqlite_connection.Open();
            SQLiteCommand sqlite_command = sqlite_connection.CreateCommand();
            sqlite_command.CommandText = commandString.ToString();
            sqlite_command.ExecuteNonQuery();
            sqlite_connection.Close();
        }

        public string ReplaceCharacterWithNewLine(string stringToNewLine)
        {
            bool checker = false;
            List<string> listOfLetters = new List<string>();
            StringBuilder newLineStringInserted = new StringBuilder();
            foreach (var letter in stringToNewLine)
            {
                if (letter == '|')
                {
                    checker = true;
                    listOfLetters.Add("\n");
                    continue;
                }
                listOfLetters.Add(letter.ToString());
            }
            foreach (var listItem in listOfLetters)
            {
                newLineStringInserted.Append(listItem);
            }
            if (!checker)
            {
                return stringToNewLine;
            }
            return newLineStringInserted.ToString();
        }

        private string ReplaceNewlineWithCharacter(string newLineToCharacter)
        {
            StringBuilder StringWithCharacterInsteadNewLine = new StringBuilder();
            List<string> lettersToArray = new List<string>();
            foreach (char letter in newLineToCharacter)
            {
                if (letter == '\n')
                {
                    lettersToArray.Add("|");
                    continue;
                }
                lettersToArray.Add(letter.ToString());
            }
            
            foreach (var listItem in lettersToArray)
            {
                StringWithCharacterInsteadNewLine.Append(listItem);
            }
            return StringWithCharacterInsteadNewLine.ToString();
        }

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
                while (sqlite_datareader.Read())
                {
                    string btnNameReader = sqlite_datareader.GetString(0);
                    dataItems.Add(btnNameReader, ReplaceCharacterWithNewLine(sqlite_datareader.GetString(1)));
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
                while (sqlite_datareader.Read())
                {
                    resultQuery = sqlite_datareader.GetString(1);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("There is no such record!!");
            }
            finally
            {
                sqlite_connection.Close();
            }
            return ReplaceCharacterWithNewLine(resultQuery);
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
