namespace RMM
{
    partial class deleteRider
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
               this.gvViewRider = new System.Windows.Forms.DataGridView();
               this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
               this.label1 = new System.Windows.Forms.Label();
               this.btnBack = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.gvViewRider)).BeginInit();
               this.SuspendLayout();
               // 
               // gvViewRider
               // 
               this.gvViewRider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.gvViewRider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.gvViewRider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
               this.gvViewRider.Location = new System.Drawing.Point(37, 83);
               this.gvViewRider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.gvViewRider.Name = "gvViewRider";
               this.gvViewRider.ReadOnly = true;
               this.gvViewRider.RowHeadersWidth = 62;
               this.gvViewRider.RowTemplate.Height = 28;
               this.gvViewRider.Size = new System.Drawing.Size(698, 399);
               this.gvViewRider.TabIndex = 3;
               this.gvViewRider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvViewRider_CellContentClick);
               // 
               // Delete
               // 
               this.Delete.HeaderText = "Delete";
               this.Delete.MinimumWidth = 8;
               this.Delete.Name = "Delete";
               this.Delete.ReadOnly = true;
               this.Delete.Width = 150;
               // 
               // label1
               // 
               this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(340, 22);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(93, 36);
               this.label1.TabIndex = 4;
               this.label1.Text = "Rider";
               // 
               // btnBack
               // 
               this.btnBack.BackColor = System.Drawing.Color.White;
               this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnBack.ForeColor = System.Drawing.Color.Black;
               this.btnBack.Location = new System.Drawing.Point(37, 509);
               this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnBack.Name = "btnBack";
               this.btnBack.Size = new System.Drawing.Size(82, 41);
               this.btnBack.TabIndex = 14;
               this.btnBack.Text = "Back";
               this.btnBack.UseVisualStyleBackColor = false;
               this.btnBack.Click += new System.EventHandler(this.button2_Click);
               // 
               // deleteRider
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.InactiveBorder;
               this.ClientSize = new System.Drawing.Size(784, 561);
               this.Controls.Add(this.btnBack);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.gvViewRider);
               this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.MinimumSize = new System.Drawing.Size(800, 600);
               this.Name = "deleteRider";
               this.Text = "deleteRider";
               ((System.ComponentModel.ISupportInitialize)(this.gvViewRider)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvViewRider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}