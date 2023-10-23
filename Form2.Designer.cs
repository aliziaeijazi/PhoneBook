namespace PhoneBook
{
    partial class AddOrEditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddOrEditBtn = new System.Windows.Forms.Button();
            this.AddressInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AgeInput = new System.Windows.Forms.NumericUpDown();
            this.PhoneNumberInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FamilyInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddOrEditBtn);
            this.groupBox1.Controls.Add(this.AddressInput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.EmailInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AgeInput);
            this.groupBox1.Controls.Add(this.PhoneNumberInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.FamilyInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NameInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(460, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات فرد";
            // 
            // AddOrEditBtn
            // 
            this.AddOrEditBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddOrEditBtn.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Bold);
            this.AddOrEditBtn.Location = new System.Drawing.Point(148, 226);
            this.AddOrEditBtn.Name = "AddOrEditBtn";
            this.AddOrEditBtn.Size = new System.Drawing.Size(186, 27);
            this.AddOrEditBtn.TabIndex = 7;
            this.AddOrEditBtn.Text = "اضافه کردن";
            this.AddOrEditBtn.UseVisualStyleBackColor = false;
            this.AddOrEditBtn.Click += new System.EventHandler(this.AddOrEditBtn_Click);
            // 
            // AddressInput
            // 
            this.AddressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressInput.Location = new System.Drawing.Point(6, 116);
            this.AddressInput.Multiline = true;
            this.AddressInput.Name = "AddressInput";
            this.AddressInput.Size = new System.Drawing.Size(401, 104);
            this.AddressInput.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(413, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "آدرس :";
            // 
            // EmailInput
            // 
            this.EmailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailInput.Location = new System.Drawing.Point(6, 84);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(328, 25);
            this.EmailInput.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(344, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "آدرس پست الکترونیکی:";
            // 
            // AgeInput
            // 
            this.AgeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgeInput.Location = new System.Drawing.Point(282, 52);
            this.AgeInput.Name = "AgeInput";
            this.AgeInput.Size = new System.Drawing.Size(146, 25);
            this.AgeInput.TabIndex = 3;
            // 
            // PhoneNumberInput
            // 
            this.PhoneNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumberInput.Location = new System.Drawing.Point(6, 52);
            this.PhoneNumberInput.Name = "PhoneNumberInput";
            this.PhoneNumberInput.Size = new System.Drawing.Size(206, 25);
            this.PhoneNumberInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(210, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "شماره تماس:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(429, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "سن:";
            // 
            // FamilyInput
            // 
            this.FamilyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FamilyInput.Location = new System.Drawing.Point(6, 21);
            this.FamilyInput.Name = "FamilyInput";
            this.FamilyInput.Size = new System.Drawing.Size(206, 25);
            this.FamilyInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(210, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی:";
            // 
            // NameInput
            // 
            this.NameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameInput.Location = new System.Drawing.Point(282, 21);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(146, 25);
            this.NameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(429, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddOrEditForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 272);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSans", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddOrEditForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddOrEditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneNumberInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FamilyInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown AgeInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox AddressInput;
        private System.Windows.Forms.Button AddOrEditBtn;
    }
}