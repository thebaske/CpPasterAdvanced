﻿using System;
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
        public EditPasterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlsDashboard ControlToDatabaseFunctions = new ControlsDashboard();
            ControlToDatabaseFunctions.InsertIntoDb(textBoxNamePaste.Text, richTextBoxDataTopaste.Text);
        }

        private void btnCancelEditForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}