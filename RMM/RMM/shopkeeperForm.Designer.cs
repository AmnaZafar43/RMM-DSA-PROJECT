namespace RMM
{
    partial class shopkeeperForm
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
               this.gvView = new System.Windows.Forms.DataGridView();
               this.label1 = new System.Windows.Forms.Label();
               this.btnDel = new System.Windows.Forms.Button();
               this.btnBack = new System.Windows.Forms.Button();
               this.btnUpdate = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.gvView)).BeginInit();
               this.SuspendLayout();
               // 
               // gvView
               // 
               this.gvView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.gvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.gvView.Location = new System.Drawing.Point(72, 70);
               this.gvView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.gvView.Name = "gvView";
               this.gvView.ReadOnly = true;
               this.gvView.RowHeadersWidth = 62;
               this.gvView.RowTemplate.Height = 28;
               this.gvView.Size = new System.Drawing.Size(644, 398);
               this.gvView.TabIndex = 5;
               // 
               // label1
               // 
               this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(293, 17);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(176, 36);
               this.label1.TabIndex = 6;
               this.label1.Text = "Shopkeeper";
               // 
               // btnDel
               // 
               this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btnDel.BackColor = System.Drawing.Color.White;
               this.btnDel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnDel.ForeColor = System.Drawing.Color.Black;
               this.btnDel.Location = new System.Drawing.Point(533, 485);
               this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnDel.Name = "btnDel";
               this.btnDel.Size = new System.Drawing.Size(82, 41);
               this.btnDel.TabIndex = 19;
               this.btnDel.Text = "Delete";
               this.btnDel.UseVisualStyleBackColor = false;
               this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
               // 
               // btnBack
               // 
               this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.btnBack.BackColor = System.Drawing.Color.White;
               this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnBack.ForeColor = System.Drawing.Color.Black;
               this.btnBack.Location = new System.Drawing.Point(39, 496);
               this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnBack.Name = "btnBack";
               this.btnBack.Size = new System.Drawing.Size(82, 41);
               this.btnBack.TabIndex = 20;
               this.btnBack.Text = "Back";
               this.btnBack.UseVisualStyleBackColor = false;
               this.btnBack.Click += new System.EventHandler(this.button2_Click);
               // 
               // btnUpdate
               // 
               this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btnUpdate.BackColor = System.Drawing.Color.White;
               this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnUpdate.ForeColor = System.Drawing.Color.Black;
               this.btnUpdate.Location = new System.Drawing.Point(634, 485);
               this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnUpdate.Name = "btnUpdate";
               this.btnUpdate.Size = new System.Drawing.Size(82, 41);
               this.btnUpdate.TabIndex = 21;
               this.btnUpdate.Text = "Update";
               this.btnUpdate.UseVisualStyleBackColor = false;
               this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
               // 
               // shopkeeperForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.InactiveBorder;
               this.ClientSize = new System.Drawing.Size(784, 561);
               this.Controls.Add(this.btnUpdate);
               this.Controls.Add(this.btnBack);
               this.Controls.Add(this.btnDel);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.gvView);
               this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.MinimumSize = new System.Drawing.Size(800, 600);
               this.Name = "shopkeeperForm";
               this.Text = "shopkeeper";
               this.Load += new System.EventHandler(this.shopkeeperForm_Load);
               ((System.ComponentModel.ISupportInitialize)(this.gvView)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
    }
}