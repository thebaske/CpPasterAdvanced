using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace CpPasterAdvanced
{
    public partial class Form1 : Form
    {

        ControlsDashboard LoadDataToList = new ControlsDashboard();
        public Form1()
        {
            
            InitializeComponent();
            LoadDataToListbox();

        }

        public void LoadDataToListbox()
        {
            ListBoxDataNames.Items.Clear();
            foreach (var DataName in LoadDataToList.SelectRecords())
            {
                ListBoxDataNames.Items.Add(DataName.Key.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region SQL Code for first time use
            ////// We use these three SQLite objects:

            //SQLiteConnection sqlite_conn;

            //SQLiteCommand sqlite_cmd;

            //SQLiteDataReader sqlite_datareader;



            ////// create a new database connection:

            //sqlite_conn = new SQLiteConnection("Data Source=PasterDatabase.db;Version=3;New=True;Compress=True;");



            ////// open the connection:

            //sqlite_conn.Open();



            ////// create a new SQL command:

            //sqlite_cmd = sqlite_conn.CreateCommand();



            ////// Let the SQLiteCommand object know our SQL-Query:

            ////sqlite_cmd.CommandText = "CREATE TABLE PasterData ('id_name' TEXT PRIMARY KEY NOT NULL, 'dataToPaste' TEXT NOT NULL);";



            ////// Now lets execute the SQL ;D

            ////sqlite_cmd.ExecuteNonQuery();



            ////// Lets insert something into our new table:

            ////sqlite_cmd.CommandText = "INSERT INTO PasterData (id_name, dataToPaste) VALUES ('HiWorld', 'bonjourne');";



            ////// And execute this again ;D

            ////sqlite_cmd.ExecuteNonQuery();






            ////// But how do we read something out of our table ?

            ////// First lets build a SQL-Query again:

            //sqlite_cmd.CommandText = "SELECT * FROM PasterData";



            ////// Now the SQLiteCommand object can give us a DataReader-Object:

            //sqlite_datareader = sqlite_cmd.ExecuteReader();



            ////// The SQLiteDataReader allows us to run through the result lines:

            //while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            //{

            //    //    // Print out the content of the text field:

            //    //    //System.Console.WriteLine( sqlite_datareader["text"] );



            //    string myreader = sqlite_datareader.GetString(0);

            //MessageBox.Show(myreader);

            //}

            ////// We are ready, now lets cleanup and close our connection:

            ////sqlite_conn.Close();
            #endregion

            EditPasterForm epf = new EditPasterForm();
            epf.Show();
        }
        //Delete items
        private void buttonDeleteDropboxItem_Click(object sender, EventArgs e)
        {
            DialogResult ResultChoice = MessageBox.Show("Think again?", "Really want that?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ResultChoice == DialogResult.Yes)
            {
                LoadDataToList.DeleteRecords(ListBoxDataNames.SelectedItem.ToString());
            }
            LoadDataToListbox();
            

        }

        private void ListBoxDataNames_SelectedIndexChanged(object sender, EventArgs e)
        {

            Clipboard.SetText(LoadDataToList.SelectOneRecord(ListBoxDataNames.SelectedItem.ToString()));
        }
    }
}
