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

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult ResultChoice = MessageBox.Show("Think again?", "Really want that?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ResultChoice == DialogResult.Yes)
            {
                ControlToDatabaseFunctions.DeleteRecords(PasterRecordsDataGrid.SelectedCells.ToString());
            }
            LoadDataToGridView();
        }

        private void PasterRecordsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNamePaste.Text = PasterRecordsDataGrid.SelectedCells[0].Value.ToString();
            richTextBoxDataTopaste.Text = PasterRecordsDataGrid.SelectedCells[1].Value.ToString();
        }
    }
}
