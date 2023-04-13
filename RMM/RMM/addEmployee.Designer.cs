namespace RMM
{
    partial class addEmployee
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
               this.btnAdd = new System.Windows.Forms.Button();
               this.btnBack = new System.Windows.Forms.Button();
               this.txtDate = new System.Windows.Forms.DateTimePicker();
               this.txtAge = new System.Windows.Forms.TextBox();
               this.txtCNIC = new System.Windows.Forms.TextBox();
               this.txtMail = new System.Windows.Forms.TextBox();
               this.txtContact = new System.Windows.Forms.TextBox();
               this.label6 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.txtName = new System.Windows.Forms.TextBox();
               this.label7 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // btnAdd
               // 
               this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btnAdd.BackColor = System.Drawing.Color.White;
               this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnAdd.ForeColor = System.Drawing.Color.Black;
               this.btnAdd.Location = new System.Drawing.Point(540, 459);
               this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnAdd.Name = "btnAdd";
               this.btnAdd.Size = new System.Drawing.Size(82, 41);
               this.btnAdd.TabIndex = 66;
               this.btnAdd.Text = "Add";
               this.btnAdd.UseVisualStyleBackColor = false;
               this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
               // 
               // btnBack
               // 
               this.btnBack.BackColor = System.Drawing.Color.White;
               this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnBack.ForeColor = System.Drawing.Color.Black;
               this.btnBack.Location = new System.Drawing.Point(40, 459);
               this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnBack.Name = "btnBack";
               this.btnBack.Size = new System.Drawing.Size(82, 41);
               this.btnBack.TabIndex = 65;
               this.btnBack.Text = "Back";
               this.btnBack.UseVisualStyleBackColor = false;
               this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
               // 
               // txtDate
               // 
               this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.txtDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtDate.Location = new System.Drawing.Point(415, 291);
               this.txtDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.txtDate.Name = "txtDate";
               this.txtDate.Size = new System.Drawing.Size(206, 26);
               this.txtDate.TabIndex = 64;
               this.txtDate.Value = new System.DateTime(2022, 12, 9, 0, 0, 0, 0);
               // 
               // txtAge
               // 
               this.txtAge.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtAge.Location = new System.Drawing.Point(39, 208);
               this.txtAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.txtAge.Name = "txtAge";
               this.txtAge.Size = new System.Drawing.Size(207, 32);
               this.txtAge.TabIndex = 63;
               // 
               // txtCNIC
               // 
               this.txtCNIC.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtCNIC.Location = new System.Drawing.Point(39, 285);
               this.txtCNIC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.txtCNIC.Name = "txtCNIC";
               this.txtCNIC.Size = new System.Drawing.Size(207, 32);
               this.txtCNIC.TabIndex = 62;
               this.txtCNIC.TextChanged += new System.EventHandler(this.txtCNIC_TextChanged);
               // 
               // txtMail
               // 
               this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.txtMail.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMail.Location = new System.Drawing.Point(415, 120);
               this.txtMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.txtMail.Name = "txtMail";
               this.txtMail.Size = new System.Drawing.Size(207, 32);
               this.txtMail.TabIndex = 61;
               // 
               // txtContact
               // 
               this.txtContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.txtContact.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtContact.Location = new System.Drawing.Point(415, 201);
               this.txtContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.txtContact.Name = "txtContact";
               this.txtContact.Size = new System.Drawing.Size(207, 32);
               this.txtContact.TabIndex = 60;
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(35, 168);
               this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(48, 25);
               this.label6.TabIndex = 59;
               this.label6.Text = "Age";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(35, 252);
               this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(69, 25);
               this.label5.TabIndex = 58;
               this.label5.Text = "CNIC";
               // 
               // label4
               // 
               this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(411, 81);
               this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(75, 25);
               this.label4.TabIndex = 57;
               this.label4.Text = "E-mail";
               // 
               // label3
               // 
               this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(411, 168);
               this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(120, 25);
               this.label3.TabIndex = 56;
               this.label3.Text = "Contact-No";
               // 
               // label2
               // 
               this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(411, 252);
               this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(217, 25);
               this.label2.TabIndex = 55;
               this.label2.Text = "Employee Joinig Date";
               // 
               // txtName
               // 
               this.txtName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtName.Location = new System.Drawing.Point(39, 120);
               this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.txtName.Name = "txtName";
               this.txtName.Size = new System.Drawing.Size(207, 32);
               this.txtName.TabIndex = 54;
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.Location = new System.Drawing.Point(35, 81);
               this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(165, 25);
               this.label7.TabIndex = 53;
               this.label7.Text = "Employee Name";
               // 
               // label1
               // 
               this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(232, 18);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(202, 35);
               this.label1.TabIndex = 52;
               this.label1.Text = "Add Employee";
               // 
               // addEmployee
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.InactiveBorder;
               this.ClientSize = new System.Drawing.Size(784, 561);
               this.Controls.Add(this.btnAdd);
               this.Controls.Add(this.btnBack);
               this.Controls.Add(this.txtDate);
               this.Controls.Add(this.txtAge);
               this.Controls.Add(this.txtCNIC);
               this.Controls.Add(this.txtMail);
               this.Controls.Add(this.txtContact);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.txtName);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label1);
               this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.MaximizeBox = false;
               this.MinimumSize = new System.Drawing.Size(800, 600);
               this.Name = "addEmployee";
               this.Text = "addEmployee";
               this.Load += new System.EventHandler(this.addEmployee_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}