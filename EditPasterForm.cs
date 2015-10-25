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

        private void CreateRecord_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNamePaste.Text) || string.IsNullOrEmpty(textBoxNamePaste.Text) || string.IsNullOrEmpty(richTextBoxDataTopaste.Text) || string.IsNullOrWhiteSpace(richTextBoxDataTopaste.Text))
            {
                MessageBox.Show("You must enter a name and a text to paste");
            }
            if (ControlToDatabaseFunctions.SelectOneRecord(textBoxNamePaste.Text) == "")
            {
                ControlToDatabaseFunctions.InsertIntoDb(textBoxNamePaste.Text, richTextBoxDataTopaste.Text);
            }
            
           
            LoadDataToGridView();
        }

        private void btnCancelEditForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteRecord_click(object sender, EventArgs e)
        {
            if (textBoxNamePaste.Text != "")
            {
                DialogResult ResultChoice = MessageBox.Show("Think again?", "Really want that?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResultChoice == DialogResult.Yes)
                {
                    ControlToDatabaseFunctions.DeleteRecords(ControlToDatabaseFunctions.SelectOneRecord(textBoxNamePaste.Text));
                }
            }
            else
            {
                MessageBox.Show("Please enter a name to add to database or select a record to delete");
                textBoxNamePaste.BackColor = Color.Red;
            }
           
            LoadDataToGridView();
        }

        private void PasterRecordsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNamePaste.Text = PasterRecordsDataGrid.SelectedCells[0].Value.ToString();
            richTextBoxDataTopaste.Text = PasterRecordsDataGrid.SelectedCells[1].Value.ToString();
        }

        private void textBoxNamePaste_TextChanged(object sender, EventArgs e)
        {
            textBoxNamePaste.BackColor = Color.White;
        }
    }
}
