namespace RMM
{
    partial class ProfitLoss
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
               this.btnBack = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(300, 25);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(165, 36);
               this.label1.TabIndex = 9;
               this.label1.Text = "Profit Loss";
               // 
               // btnBack
               // 
               this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.btnBack.BackColor = System.Drawing.Color.White;
               this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnBack.ForeColor = System.Drawing.Color.Black;
               this.btnBack.Location = new System.Drawing.Point(41, 498);
               this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnBack.Name = "btnBack";
               this.btnBack.Size = new System.Drawing.Size(82, 41);
               this.btnBack.TabIndex = 35;
               this.btnBack.Text = "Back";
               this.btnBack.UseVisualStyleBackColor = false;
               this.btnBack.Click += new System.EventHandler(this.button1_Click);
               // 
               // ProfitLoss
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.InactiveBorder;
               this.ClientSize = new System.Drawing.Size(784, 561);
               this.Controls.Add(this.btnBack);
               this.Controls.Add(this.label1);
               this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.MinimumSize = new System.Drawing.Size(800, 600);
               this.Name = "ProfitLoss";
               this.Text = "ProfitLoss";
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}