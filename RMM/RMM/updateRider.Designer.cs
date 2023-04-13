namespace RMM
{
    partial class updateRider
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
               this.gvUpdate = new System.Windows.Forms.DataGridView();
               this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
               ((System.ComponentModel.ISupportInitialize)(this.gvUpdate)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(333, 18);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(93, 36);
               this.label1.TabIndex = 5;
               this.label1.Text = "Rider";
               // 
               // btnBack
               // 
               this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.btnBack.BackColor = System.Drawing.Color.White;
               this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnBack.ForeColor = System.Drawing.Color.Black;
               this.btnBack.Location = new System.Drawing.Point(49, 465);
               this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.btnBack.Name = "btnBack";
               this.btnBack.Size = new System.Drawing.Size(82, 41);
               this.btnBack.TabIndex = 18;
               this.btnBack.Text = "Back";
               this.btnBack.UseVisualStyleBackColor = false;
               this.btnBack.Click += new System.EventHandler(this.button1_Click);
               // 
               // gvUpdate
               // 
               this.gvUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.gvUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.gvUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update});
               this.gvUpdate.Location = new System.Drawing.Point(49, 66);
               this.gvUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.gvUpdate.Name = "gvUpdate";
               this.gvUpdate.RowHeadersWidth = 62;
               this.gvUpdate.RowTemplate.Height = 28;
               this.gvUpdate.Size = new System.Drawing.Size(667, 363);
               this.gvUpdate.TabIndex = 19;
               this.gvUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUpdate_CellContentClick_1);
               // 
               // Update
               // 
               this.Update.HeaderText = "Update";
               this.Update.MinimumWidth = 8;
               this.Update.Name = "Update";
               this.Update.Width = 150;
               // 
               // updateRider
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.InactiveBorder;
               this.ClientSize = new System.Drawing.Size(784, 561);
               this.Controls.Add(this.gvUpdate);
               this.Controls.Add(this.btnBack);
               this.Controls.Add(this.label1);
               this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.MaximizeBox = false;
               this.MinimumSize = new System.Drawing.Size(800, 600);
               this.Name = "updateRider";
               this.Text = "updateRider";
               this.Load += new System.EventHandler(this.updateRider_Load);
               ((System.ComponentModel.ISupportInitialize)(this.gvUpdate)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView gvUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}