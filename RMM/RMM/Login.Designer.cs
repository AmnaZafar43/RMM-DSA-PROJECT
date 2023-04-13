namespace RMM
{
    partial class Login
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
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.emailBox = new System.Windows.Forms.TextBox();
               this.passbox = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.btncreate = new System.Windows.Forms.Button();
               this.btnlogin = new System.Windows.Forms.Button();
               this.checkBox1 = new System.Windows.Forms.CheckBox();
               this.panel1 = new System.Windows.Forms.Panel();
               this.SuspendLayout();
               // 
               // label2
               // 
               this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(432, 82);
               this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(82, 25);
               this.label2.TabIndex = 1;
               this.label2.Text = "E-mail:";
               // 
               // label3
               // 
               this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(432, 205);
               this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(110, 25);
               this.label3.TabIndex = 2;
               this.label3.Text = "Password:";
               // 
               // emailBox
               // 
               this.emailBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.emailBox.BackColor = System.Drawing.Color.White;
               this.emailBox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.emailBox.Location = new System.Drawing.Point(436, 134);
               this.emailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.emailBox.Name = "emailBox";
               this.emailBox.Size = new System.Drawing.Size(319, 32);
               this.emailBox.TabIndex = 3;
               this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
               // 
               // passbox
               // 
               this.passbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.passbox.BackColor = System.Drawing.Color.White;
               this.passbox.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.passbox.Location = new System.Drawing.Point(436, 257);
               this.passbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.passbox.Name = "passbox";
               this.passbox.Size = new System.Drawing.Size(319, 32);
               this.passbox.TabIndex = 4;
               // 
               // label4
               // 
               this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(32, 516);
               this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(172, 22);
               this.label4.TabIndex = 5;
               this.label4.Text = "Don\'t have account?";
               // 
               // btncreate
               // 
               this.btncreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.btncreate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.btncreate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btncreate.Location = new System.Drawing.Point(213, 499);
               this.btncreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btncreate.Name = "btncreate";
               this.btncreate.Size = new System.Drawing.Size(135, 38);
               this.btncreate.TabIndex = 6;
               this.btncreate.Text = "Create Account";
               this.btncreate.UseVisualStyleBackColor = false;
               this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
               // 
               // btnlogin
               // 
               this.btnlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btnlogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
               this.btnlogin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnlogin.Location = new System.Drawing.Point(676, 492);
               this.btnlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnlogin.Name = "btnlogin";
               this.btnlogin.Size = new System.Drawing.Size(77, 37);
               this.btnlogin.TabIndex = 7;
               this.btnlogin.Text = "Login";
               this.btnlogin.UseVisualStyleBackColor = false;
               this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
               // 
               // checkBox1
               // 
               this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.checkBox1.AutoSize = true;
               this.checkBox1.BackColor = System.Drawing.Color.Transparent;
               this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.checkBox1.Location = new System.Drawing.Point(634, 295);
               this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.checkBox1.Name = "checkBox1";
               this.checkBox1.Size = new System.Drawing.Size(125, 21);
               this.checkBox1.TabIndex = 8;
               this.checkBox1.Text = "Show Password";
               this.checkBox1.UseVisualStyleBackColor = false;
               this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
               // 
               // panel1
               // 
               this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.panel1.BackgroundImage = global::RMM.Properties.Resources.p11;
               this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
               this.panel1.Location = new System.Drawing.Point(-15, 21);
               this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(396, 403);
               this.panel1.TabIndex = 9;
               // 
               // Login
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.InactiveBorder;
               this.ClientSize = new System.Drawing.Size(784, 561);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.checkBox1);
               this.Controls.Add(this.btnlogin);
               this.Controls.Add(this.btncreate);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.passbox);
               this.Controls.Add(this.emailBox);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.MaximizeBox = false;
               this.MinimumSize = new System.Drawing.Size(800, 600);
               this.Name = "Login";
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

