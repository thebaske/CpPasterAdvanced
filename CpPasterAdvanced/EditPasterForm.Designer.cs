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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Paster_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paster_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paster_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sQLiteTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateEditForm
            // 
            this.btnCreateEditForm.Location = new System.Drawing.Point(579, 26);
            this.btnCreateEditForm.Name = "btnCreateEditForm";
            this.btnCreateEditForm.Size = new System.Drawing.Size(75, 23);
            this.btnCreateEditForm.TabIndex = 1;
            this.btnCreateEditForm.Text = "Create";
            this.btnCreateEditForm.UseVisualStyleBackColor = true;
            this.btnCreateEditForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelEditForm
            // 
            this.btnCancelEditForm.Location = new System.Drawing.Point(579, 84);
            this.btnCancelEditForm.Name = "btnCancelEditForm";
            this.btnCancelEditForm.Size = new System.Drawing.Size(75, 23);
            this.btnCancelEditForm.TabIndex = 2;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Paster_ID,
            this.Paster_Name,
            this.Paster_Data});
            this.dataGridView1.Location = new System.Drawing.Point(16, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(245, 163);
            this.dataGridView1.TabIndex = 4;
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(268, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(305, 161);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // EditPasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 201);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelEditForm);
            this.Controls.Add(this.btnCreateEditForm);
            this.Name = "EditPasterForm";
            this.Text = "EditPasterForm";
            ((System.ComponentModel.ISupportInitialize)(this.sQLiteTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEditForm;
        private System.Windows.Forms.Button btnCancelEditForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sQLiteTransactionBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paster_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paster_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paster_Data;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}