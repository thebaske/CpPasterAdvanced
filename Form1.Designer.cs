namespace CpPasterAdvanced
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.ListBoxDataNames = new System.Windows.Forms.ComboBox();
            this.buttonDeleteDropboxItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "AddPaster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListBoxDataNames
            // 
            this.ListBoxDataNames.FormattingEnabled = true;
            this.ListBoxDataNames.Location = new System.Drawing.Point(93, 13);
            this.ListBoxDataNames.Name = "ListBoxDataNames";
            this.ListBoxDataNames.Size = new System.Drawing.Size(121, 21);
            this.ListBoxDataNames.TabIndex = 1;
            this.ListBoxDataNames.SelectedIndexChanged += new System.EventHandler(this.ListBoxDataNames_SelectedIndexChanged);
            // 
            // buttonDeleteDropboxItem
            // 
            this.buttonDeleteDropboxItem.Location = new System.Drawing.Point(12, 11);
            this.buttonDeleteDropboxItem.Name = "buttonDeleteDropboxItem";
            this.buttonDeleteDropboxItem.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDropboxItem.TabIndex = 2;
            this.buttonDeleteDropboxItem.Text = "Delete item";
            this.buttonDeleteDropboxItem.UseVisualStyleBackColor = true;
            this.buttonDeleteDropboxItem.Click += new System.EventHandler(this.buttonDeleteDropboxItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 46);
            this.Controls.Add(this.buttonDeleteDropboxItem);
            this.Controls.Add(this.ListBoxDataNames);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ListBoxDataNames;
        private System.Windows.Forms.Button buttonDeleteDropboxItem;
    }
}

