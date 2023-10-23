namespace PhoneBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ContactTable = new System.Windows.Forms.DataGridView();
            this.ContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.InsertContactBtn = new System.Windows.Forms.ToolStripButton();
            this.RefreshContactBtn = new System.Windows.Forms.ToolStripButton();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContactTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContactTable
            // 
            this.ContactTable.AllowUserToAddRows = false;
            this.ContactTable.AllowUserToDeleteRows = false;
            this.ContactTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ContactTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactId,
            this.PersonName,
            this.Family,
            this.Age,
            this.PhoneNumber,
            this.Email});
            resources.ApplyResources(this.ContactTable, "ContactTable");
            this.ContactTable.Name = "ContactTable";
            this.ContactTable.ReadOnly = true;
            // 
            // ContactId
            // 
            this.ContactId.DataPropertyName = "ContactID";
            this.ContactId.FillWeight = 5F;
            resources.ApplyResources(this.ContactId, "ContactId");
            this.ContactId.Name = "ContactId";
            this.ContactId.ReadOnly = true;
            // 
            // PersonName
            // 
            this.PersonName.DataPropertyName = "Name";
            this.PersonName.FillWeight = 86.92893F;
            resources.ApplyResources(this.PersonName, "PersonName");
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            // 
            // Family
            // 
            this.Family.DataPropertyName = "Family";
            this.Family.FillWeight = 86.92893F;
            resources.ApplyResources(this.Family, "Family");
            this.Family.Name = "Family";
            this.Family.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.FillWeight = 50F;
            resources.ApplyResources(this.Age, "Age");
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.FillWeight = 86.92893F;
            resources.ApplyResources(this.PhoneNumber, "PhoneNumber");
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 86.92893F;
            resources.ApplyResources(this.Email, "Email");
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DeleteBtn);
            this.groupBox4.Controls.Add(this.EditBtn);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertContactBtn,
            this.RefreshContactBtn});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ContactTable);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchBtn);
            this.groupBox2.Controls.Add(this.SearchInput);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // SearchInput
            // 
            resources.ApplyResources(this.SearchInput, "SearchInput");
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // DeleteBtn
            // 
            resources.ApplyResources(this.DeleteBtn, "DeleteBtn");
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.DeleteBtn.Image = global::PhoneBook.Properties.Resources.icons8_search_20px;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            resources.ApplyResources(this.EditBtn, "EditBtn");
            this.EditBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.EditBtn.Image = global::PhoneBook.Properties.Resources.icons8_edit_profile_24px;
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // InsertContactBtn
            // 
            this.InsertContactBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.InsertContactBtn, "InsertContactBtn");
            this.InsertContactBtn.Name = "InsertContactBtn";
            this.InsertContactBtn.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.InsertContactBtn.Click += new System.EventHandler(this.InsertContactBtn_Click);
            // 
            // RefreshContactBtn
            // 
            this.RefreshContactBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.RefreshContactBtn, "RefreshContactBtn");
            this.RefreshContactBtn.Margin = new System.Windows.Forms.Padding(0, 1, 4, 2);
            this.RefreshContactBtn.Name = "RefreshContactBtn";
            this.RefreshContactBtn.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.RefreshContactBtn.Click += new System.EventHandler(this.RefreshContactBtn_Click);
            // 
            // SearchBtn
            // 
            resources.ApplyResources(this.SearchBtn, "SearchBtn");
            this.SearchBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.SearchBtn.Image = global::PhoneBook.Properties.Resources.icons8_search_20px;
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContactTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton RefreshContactBtn;
        private System.Windows.Forms.ToolStripButton InsertContactBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView ContactTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Family;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

