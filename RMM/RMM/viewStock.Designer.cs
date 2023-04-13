namespace RMM
{
    partial class viewStock
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
               this.btnUpdate = new System.Windows.Forms.Button();
               this.btnDelete = new System.Windows.Forms.Button();
               this.btnBack = new System.Windows.Forms.Button();
               this.btnAdd = new System.Windows.Forms.Button();
               this.gvView = new System.Windows.Forms.DataGridView();
               ((System.ComponentModel.ISupportInitialize)(this.gvView)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(340, 19);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(91, 36);
               this.label1.TabIndex = 10;
               this.label1.Text = "Stock";
               // 
               // btnUpdate
               // 
               this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btnUpdate.BackColor = System.Drawing.Color.White;
               this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnUpdate.ForeColor = System.Drawing.Color.Black;
               this.btnUpdate.Location = new System.Drawing.Point(640, 503);
               this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnUpdate.Name = "btnUpdate";
               this.btnUpdate.Size = new System.Drawing.Size(82, 41);
               this.btnUpdate.TabIndex = 35;
               this.btnUpdate.Text = "Update";
               this.btnUpdate.UseVisualStyleBackColor = false;
               this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
               // 
               // btnDelete
               // 
               this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btnDelete.BackColor = System.Drawing.Color.White;
               this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnDelete.ForeColor = System.Drawing.Color.Black;
               this.btnDelete.Location = new System.Drawing.Point(546, 503);
               this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnDelete.Name = "btnDelete";
               this.btnDelete.Size = new System.Drawing.Size(82, 41);
               this.btnDelete.TabIndex = 36;
               this.btnDelete.Text = "Delete";
               this.btnDelete.UseVisualStyleBackColor = false;
               this.btnDelete.Click += new System.EventHandler(this.button2_Click);
               // 
               // btnBack
               // 
               this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.btnBack.BackColor = System.Drawing.Color.White;
               this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnBack.ForeColor = System.Drawing.Color.Black;
               this.btnBack.Location = new System.Drawing.Point(51, 503);
               this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnBack.Name = "btnBack";
               this.btnBack.Size = new System.Drawing.Size(82, 41);
               this.btnBack.TabIndex = 37;
               this.btnBack.Text = "Back";
               this.btnBack.UseVisualStyleBackColor = false;
               this.btnBack.Click += new System.EventHandler(this.button3_Click);
               // 
               // btnAdd
               // 
               this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btnAdd.BackColor = System.Drawing.Color.White;
               this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnAdd.ForeColor = System.Drawing.Color.Black;
               this.btnAdd.Location = new System.Drawing.Point(454, 503);
               this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnAdd.Name = "btnAdd";
               this.btnAdd.Size = new System.Drawing.Size(82, 41);
               this.btnAdd.TabIndex = 38;
               this.btnAdd.Text = "Add";
               this.btnAdd.UseVisualStyleBackColor = false;
               this.btnAdd.Click += new System.EventHandler(this.button4_Click);
               // 
               // gvView
               // 
               this.gvView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.gvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.gvView.Location = new System.Drawing.Point(51, 75);
               this.gvView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.gvView.Name = "gvView";
               this.gvView.RowHeadersWidth = 62;
               this.gvView.RowTemplate.Height = 28;
               this.gvView.Size = new System.Drawing.Size(670, 399);
               this.gvView.TabIndex = 11;
               // 
               // viewStock
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.InactiveBorder;
               this.ClientSize = new System.Drawing.Size(784, 561);
               this.Controls.Add(this.btnAdd);
               this.Controls.Add(this.btnBack);
               this.Controls.Add(this.btnDelete);
               this.Controls.Add(this.btnUpdate);
               this.Controls.Add(this.gvView);
               this.Controls.Add(this.label1);
               this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.MinimumSize = new System.Drawing.Size(800, 600);
               this.Name = "viewStock";
               this.Text = "viewStock";
               this.Load += new System.EventHandler(this.viewStock_Load);
               ((System.ComponentModel.ISupportInitialize)(this.gvView)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gvView;
    }
}