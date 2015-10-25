namespace CpPasterAdvanced
{
    partial class EditPasterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCreateEditForm = new System.Windows.Forms.Button();
            this.btnCancelEditForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sQLiteTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PasterRecordsDataGrid = new System.Windows.Forms.DataGridView();
            this.Paster_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paster_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paster_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBoxDataTopaste = new System.Windows.Forms.RichTextBox();
            this.textBoxNamePaste = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sQLiteTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasterRecordsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateEditForm
            // 
            this.btnCreateEditForm.Location = new System.Drawing.Point(802, 54);
            this.btnCreateEditForm.Name = "btnCreateEditForm";
            this.btnCreateEditForm.Size = new System.Drawing.Size(75, 23);
            this.btnCreateEditForm.TabIndex = 3;
            this.btnCreateEditForm.Text = "Create";
            this.btnCreateEditForm.UseVisualStyleBackColor = true;
            this.btnCreateEditForm.Click += new System.EventHandler(this.CreateRecord_click);
            // 
            // btnCancelEditForm
            // 
            this.btnCancelEditForm.Location = new System.Drawing.Point(802, 112);
            this.btnCancelEditForm.Name = "btnCancelEditForm";
            this.btnCancelEditForm.Size = new System.Drawing.Size(75, 23);
            this.btnCancelEditForm.TabIndex = 4;
            this.btnCancelEditForm.Text = "Cancel";
            this.btnCancelEditForm.UseVisualStyleBackColor = true;
            this.btnCancelEditForm.Click += new System.EventHandler(this.btnCancelEditForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PasterRecords";
            // 
            // sQLiteTransactionBindingSource
            // 
            this.sQLiteTransactionBindingSource.DataSource = typeof(Finisar.SQLite.SQLiteTransaction);
            // 
            // PasterRecordsDataGrid
            // 
            this.PasterRecordsDataGrid.AllowUserToAddRows = false;
            this.PasterRecordsDataGrid.AllowUserToDeleteRows = false;
            this.PasterRecordsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PasterRecordsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Paster_ID,
            this.Paster_Name,
            this.Paster_Data});
            this.PasterRecordsDataGrid.Location = new System.Drawing.Point(16, 28);
            this.PasterRecordsDataGrid.MultiSelect = false;
            this.PasterRecordsDataGrid.Name = "PasterRecordsDataGrid";
            this.PasterRecordsDataGrid.ReadOnly = true;
            this.PasterRecordsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PasterRecordsDataGrid.Size = new System.Drawing.Size(245, 349);
            this.PasterRecordsDataGrid.TabIndex = 4;
            this.PasterRecordsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PasterRecordsDataGrid_CellContentClick);
            // 
            // Paster_ID
            // 
            this.Paster_ID.HeaderText = "ID";
            this.Paster_ID.Name = "Paster_ID";
            this.Paster_ID.ReadOnly = true;
            // 
            // Paster_Name
            // 
            this.Paster_Name.HeaderText = "Name";
            this.Paster_Name.Name = "Paster_Name";
            this.Paster_Name.ReadOnly = true;
            // 
            // Paster_Data
            // 
            this.Paster_Data.HeaderText = "Data";
            this.Paster_Data.Name = "Paster_Data";
            this.Paster_Data.ReadOnly = true;
            this.Paster_Data.Visible = false;
            // 
            // richTextBoxDataTopaste
            // 
            this.richTextBoxDataTopaste.Location = new System.Drawing.Point(268, 54);
            this.richTextBoxDataTopaste.Name = "richTextBoxDataTopaste";
            this.richTextBoxDataTopaste.Size = new System.Drawing.Size(528, 323);
            this.richTextBoxDataTopaste.TabIndex = 2;
            this.richTextBoxDataTopaste.Text = "";
            // 
            // textBoxNamePaste
            // 
            this.textBoxNamePaste.Location = new System.Drawing.Point(268, 28);
            this.textBoxNamePaste.Name = "textBoxNamePaste";
            this.textBoxNamePaste.Size = new System.Drawing.Size(291, 20);
            this.textBoxNamePaste.TabIndex = 1;
            this.textBoxNamePaste.TextChanged += new System.EventHandler(this.textBoxNamePaste_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name of the paster";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data to paste";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteRecord_click);
            // 
            // EditPasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNamePaste);
            this.Controls.Add(this.richTextBoxDataTopaste);
            this.Controls.Add(this.PasterRecordsDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelEditForm);
            this.Controls.Add(this.btnCreateEditForm);
            this.Name = "EditPasterForm";
            this.Text = "EditPasterForm";
            ((System.ComponentModel.ISupportInitialize)(this.sQLiteTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasterRecordsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEditForm;
        private System.Windows.Forms.Button btnCancelEditForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sQLiteTransactionBindingSource;
        private System.Windows.Forms.DataGridView PasterRecordsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paster_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paster_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paster_Data;
        private System.Windows.Forms.RichTextBox richTextBoxDataTopaste;
        private System.Windows.Forms.TextBox textBoxNamePaste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}