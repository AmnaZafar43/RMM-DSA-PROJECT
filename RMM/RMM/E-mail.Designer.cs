namespace RMM
{
    partial class E_mail
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
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.txtBody = new System.Windows.Forms.RichTextBox();
               this.btnlog = new System.Windows.Forms.Button();
               this.txtMail = new System.Windows.Forms.RichTextBox();
               this.btnSend = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(331, 9);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(99, 35);
               this.label1.TabIndex = 3;
               this.label1.Text = "E-mail";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(89, 136);
               this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(60, 25);
               this.label2.TabIndex = 4;
               this.label2.Text = "Body";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(81, 81);
               this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(68, 25);
               this.label3.TabIndex = 5;
               this.label3.Text = "Email";
               // 
               // txtBody
               // 
               this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.txtBody.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtBody.Location = new System.Drawing.Point(190, 136);
               this.txtBody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.txtBody.Name = "txtBody";
               this.txtBody.Size = new System.Drawing.Size(471, 163);
               this.txtBody.TabIndex = 7;
               this.txtBody.Text = "";
               // 
               // btnlog
               // 
               this.btnlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.btnlog.BackColor = System.Drawing.Color.White;
               this.btnlog.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnlog.ForeColor = System.Drawing.Color.Black;
               this.btnlog.Location = new System.Drawing.Point(86, 432);
               this.btnlog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnlog.Name = "btnlog";
               this.btnlog.Size = new System.Drawing.Size(81, 44);
               this.btnlog.TabIndex = 12;
               this.btnlog.Text = "Back";
               this.btnlog.UseVisualStyleBackColor = false;
               this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
               // 
               // txtMail
               // 
               this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.txtMail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMail.Location = new System.Drawing.Point(190, 75);
               this.txtMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.txtMail.Name = "txtMail";
               this.txtMail.Size = new System.Drawing.Size(471, 31);
               this.txtMail.TabIndex = 13;
               this.txtMail.Text = "";
               // 
               // btnSend
               // 
               this.btnSend.BackColor = System.Drawing.Color.White;
               this.btnSend.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSend.ForeColor = System.Drawing.Color.Black;
               this.btnSend.Location = new System.Drawing.Point(580, 432);
               this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnSend.Name = "btnSend";
               this.btnSend.Size = new System.Drawing.Size(81, 44);
               this.btnSend.TabIndex = 14;
               this.btnSend.Text = "Send";
               this.btnSend.UseVisualStyleBackColor = false;
               this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
               // 
               // E_mail
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.InactiveBorder;
               this.ClientSize = new System.Drawing.Size(784, 561);
               this.Controls.Add(this.btnSend);
               this.Controls.Add(this.txtMail);
               this.Controls.Add(this.btnlog);
               this.Controls.Add(this.txtBody);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.MinimumSize = new System.Drawing.Size(800, 600);
               this.Name = "E_mail";
               this.Text = "E_mail";
               this.Load += new System.EventHandler(this.E_mail_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.RichTextBox txtMail;
        private System.Windows.Forms.Button btnSend;
    }
}