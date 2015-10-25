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
using Finisar.SQLite;

namespace CpPasterAdvanced
{
    public partial class EditPasterForm : Form
    {
        ControlsDashboard ControlToDatabaseFunctions = new ControlsDashboard();
        public EditPasterForm()
        {
            InitializeComponent();
            LoadDataToGridView();
        }

        public void LoadDataToGridView()
        {
            richTextBoxDataTopaste.Clear();
            textBoxNamePaste.Clear();
            PasterRecordsDataGrid.Rows.Clear();
            foreach (KeyValuePair<string, string> pasteData in ControlToDatabaseFunctions.SelectRecords())
            {
                PasterRecordsDataGrid.Rows.Add(pasteData.Key, pasteData.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ControlToDatabaseFunctions.InsertIntoDb(textBoxNamePaste.Text, richTextBoxDataTopaste.Text);
            LoadDataToGridView();
        }

        private void btnCancelEditForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
