namespace RMM
{
    partial class riderForm
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
               this.gvViewRider = new System.Windows.Forms.DataGridView();
               this.btnUpdate = new System.Windows.Forms.Button();
               this.btnDelete = new System.Windows.Forms.Button();
               this.btnBack = new System.Windows.Forms.Button();
               this.btnAdd = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.gvViewRider)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(311, 17);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(93, 36);
               this.label1.TabIndex = 1;
               this.label1.Text = "Rider";
               // 
               // gvViewRider
               // 
               this.gvViewRider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.gvViewRider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.gvViewRider.Location = new System.Drawing.Point(53, 82);
               this.gvViewRider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.gvViewRider.Name = "gvViewRider";
               this.gvViewRider.ReadOnly = true;
               this.gvViewRider.RowHeadersWidth = 62;
               this.gvViewRider.RowTemplate.Height = 28;
               this.gvViewRider.Size = new System.Drawing.Size(644, 227);
               this.gvViewRider.TabIndex = 2;
               // 
               // btnUpdate
               // 
               this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btnUpdate.BackColor = System.Drawing.Color.White;
               this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnUpdate.ForeColor = System.Drawing.Color.Black;
               this.btnUpdate.Location = new System.Drawing.Point(615, 333);
               this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnUpdate.Name = "btnUpdate";
               this.btnUpdate.Size = new System.Drawing.Size(82, 41);
               this.btnUpdate.TabIndex = 11;
               this.btnUpdate.Text = "Update";
               this.btnUpdate.UseVisualStyleBackColor = false;
               this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
               // 
               // btnDelete
               // 
               this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btnDelete.BackColor = System.Drawing.Color.White;
               this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnDelete.ForeColor = System.Drawing.Color.Black;
               this.btnDelete.Location = new System.Drawing.Point(522, 333);
               this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnDelete.Name = "btnDelete";
               this.btnDelete.Size = new System.Drawing.Size(82, 41);
               this.btnDelete.TabIndex = 12;
               this.btnDelete.Text = "Delete";
               this.btnDelete.UseVisualStyleBackColor = false;
               this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
               // 
               // btnBack
               // 
               this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.btnBack.BackColor = System.Drawing.Color.White;
               this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnBack.ForeColor = System.Drawing.Color.Black;
               this.btnBack.Location = new System.Drawing.Point(37, 333);
               this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnBack.Name = "btnBack";
               this.btnBack.Size = new System.Drawing.Size(82, 41);
               this.btnBack.TabIndex = 13;
               this.btnBack.Text = "Back";
               this.btnBack.UseVisualStyleBackColor = false;
               this.btnBack.Click += new System.EventHandler(this.button2_Click);
               // 
               // btnAdd
               // 
               this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btnAdd.BackColor = System.Drawing.Color.White;
               this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnAdd.ForeColor = System.Drawing.Color.Black;
               this.btnAdd.Location = new System.Drawing.Point(427, 333);
               this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnAdd.Name = "btnAdd";
               this.btnAdd.Size = new System.Drawing.Size(82, 41);
               this.btnAdd.TabIndex = 14;
               this.btnAdd.Text = "Add";
               this.btnAdd.UseVisualStyleBackColor = false;
               this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
               // 
               // riderForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.InactiveBorder;
               this.ClientSize = new System.Drawing.Size(784, 561);
               this.Controls.Add(this.btnAdd);
               this.Controls.Add(this.btnBack);
               this.Controls.Add(this.btnDelete);
               this.Controls.Add(this.btnUpdate);
               this.Controls.Add(this.gvViewRider);
               this.Controls.Add(this.label1);
               this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.MinimumSize = new System.Drawing.Size(800, 600);
               this.Name = "riderForm";
               this.Text = "rider";
               this.Load += new System.EventHandler(this.riderForm_Load);
               ((System.ComponentModel.ISupportInitialize)(this.gvViewRider)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvViewRider;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
    }
}