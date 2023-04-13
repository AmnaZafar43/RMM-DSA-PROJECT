namespace RMM
{
    partial class orderDetails
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
            this.gvView = new System.Windows.Forms.DataGridView();
            this.btnlog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Details";
            // 
            // gvView
            // 
            this.gvView.ColumnHeadersHeight = 34;
            this.gvView.Location = new System.Drawing.Point(45, 146);
            this.gvView.Name = "gvView";
            this.gvView.RowHeadersWidth = 62;
            this.gvView.RowTemplate.Height = 28;
            this.gvView.Size = new System.Drawing.Size(1024, 338);
            this.gvView.TabIndex = 1;
            this.gvView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.Color.White;
            this.btnlog.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.Color.Black;
            this.btnlog.Location = new System.Drawing.Point(45, 598);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(123, 63);
            this.btnlog.TabIndex = 10;
            this.btnlog.Text = "Back";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // orderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1096, 697);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.gvView);
            this.Controls.Add(this.label1);
            this.Name = "orderDetails";
            this.Text = "orderDetails";
            this.Load += new System.EventHandler(this.orderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvView;
        private System.Windows.Forms.Button btnlog;
    }
}