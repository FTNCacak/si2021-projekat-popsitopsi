
namespace PresentationLayer
{
    partial class Stuffs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStuffName = new System.Windows.Forms.TextBox();
            this.tbStuffSurname = new System.Windows.Forms.TextBox();
            this.tbStuffUsername = new System.Windows.Forms.TextBox();
            this.tbStuffPassword = new System.Windows.Forms.TextBox();
            this.tbStuffPhone = new System.Windows.Forms.TextBox();
            this.tbStuffEmail = new System.Windows.Forms.TextBox();
            this.dgStuffs = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgStuffs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(25, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PREZIME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "USERNAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "LOZINKA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "BROJ TELEFONA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "EMAIL:";
            // 
            // tbStuffName
            // 
            this.tbStuffName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbStuffName.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbStuffName.Location = new System.Drawing.Point(282, 28);
            this.tbStuffName.Multiline = true;
            this.tbStuffName.Name = "tbStuffName";
            this.tbStuffName.Size = new System.Drawing.Size(186, 34);
            this.tbStuffName.TabIndex = 6;
            // 
            // tbStuffSurname
            // 
            this.tbStuffSurname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbStuffSurname.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbStuffSurname.Location = new System.Drawing.Point(282, 81);
            this.tbStuffSurname.Multiline = true;
            this.tbStuffSurname.Name = "tbStuffSurname";
            this.tbStuffSurname.Size = new System.Drawing.Size(186, 34);
            this.tbStuffSurname.TabIndex = 7;
            // 
            // tbStuffUsername
            // 
            this.tbStuffUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbStuffUsername.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbStuffUsername.Location = new System.Drawing.Point(282, 138);
            this.tbStuffUsername.Multiline = true;
            this.tbStuffUsername.Name = "tbStuffUsername";
            this.tbStuffUsername.Size = new System.Drawing.Size(186, 34);
            this.tbStuffUsername.TabIndex = 8;
            // 
            // tbStuffPassword
            // 
            this.tbStuffPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbStuffPassword.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbStuffPassword.Location = new System.Drawing.Point(282, 193);
            this.tbStuffPassword.Multiline = true;
            this.tbStuffPassword.Name = "tbStuffPassword";
            this.tbStuffPassword.PasswordChar = '*';
            this.tbStuffPassword.Size = new System.Drawing.Size(186, 34);
            this.tbStuffPassword.TabIndex = 9;
            // 
            // tbStuffPhone
            // 
            this.tbStuffPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbStuffPhone.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbStuffPhone.Location = new System.Drawing.Point(282, 249);
            this.tbStuffPhone.Multiline = true;
            this.tbStuffPhone.Name = "tbStuffPhone";
            this.tbStuffPhone.Size = new System.Drawing.Size(186, 34);
            this.tbStuffPhone.TabIndex = 10;
            // 
            // tbStuffEmail
            // 
            this.tbStuffEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbStuffEmail.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbStuffEmail.Location = new System.Drawing.Point(282, 304);
            this.tbStuffEmail.Multiline = true;
            this.tbStuffEmail.Name = "tbStuffEmail";
            this.tbStuffEmail.Size = new System.Drawing.Size(186, 46);
            this.tbStuffEmail.TabIndex = 11;
            // 
            // dgStuffs
            // 
            this.dgStuffs.AllowUserToAddRows = false;
            this.dgStuffs.AllowUserToDeleteRows = false;
            this.dgStuffs.AllowUserToResizeColumns = false;
            this.dgStuffs.AllowUserToResizeRows = false;
            this.dgStuffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgStuffs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStuffs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgStuffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStuffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SName,
            this.Surname,
            this.Username,
            this.Password,
            this.Phone,
            this.Email});
            this.dgStuffs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgStuffs.Location = new System.Drawing.Point(511, 28);
            this.dgStuffs.MultiSelect = false;
            this.dgStuffs.Name = "dgStuffs";
            this.dgStuffs.ReadOnly = true;
            this.dgStuffs.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgStuffs.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgStuffs.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgStuffs.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgStuffs.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgStuffs.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgStuffs.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgStuffs.RowTemplate.Height = 25;
            this.dgStuffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStuffs.Size = new System.Drawing.Size(513, 322);
            this.dgStuffs.TabIndex = 12;
            this.dgStuffs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgStuffs_CellMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id.HeaderText = "Šifra";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 75;
            // 
            // SName
            // 
            this.SName.DataPropertyName = "Name";
            this.SName.HeaderText = "Ime";
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Width = 65;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Prezime";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 95;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 110;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Lozinka";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 91;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "PhoneNumber";
            this.Phone.HeaderText = "Broj telefona";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 137;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 74;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAdd.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonAdd.Location = new System.Drawing.Point(153, 399);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(192, 61);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "DODAJ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonChange.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChange.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonChange.Location = new System.Drawing.Point(590, 390);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(192, 61);
            this.buttonChange.TabIndex = 14;
            this.buttonChange.Text = "IZMENI";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDelete.Font = new System.Drawing.Font("Castellar", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonDelete.Location = new System.Drawing.Point(817, 388);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(192, 63);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "IZBRIŠI";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Stuffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1054, 499);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dgStuffs);
            this.Controls.Add(this.tbStuffEmail);
            this.Controls.Add(this.tbStuffPhone);
            this.Controls.Add(this.tbStuffPassword);
            this.Controls.Add(this.tbStuffUsername);
            this.Controls.Add(this.tbStuffSurname);
            this.Controls.Add(this.tbStuffName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Stuffs";
            this.Text = "Stuffs";
            this.Load += new System.EventHandler(this.Stuffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStuffs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStuffName;
        private System.Windows.Forms.TextBox tbStuffSurname;
        private System.Windows.Forms.TextBox tbStuffUsername;
        private System.Windows.Forms.TextBox tbStuffPassword;
        private System.Windows.Forms.TextBox tbStuffPhone;
        private System.Windows.Forms.TextBox tbStuffEmail;
        private System.Windows.Forms.DataGridView dgStuffs;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}