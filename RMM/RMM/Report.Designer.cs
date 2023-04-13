namespace RMM
{
    partial class Report
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
               this.components = new System.ComponentModel.Container();
               this.label1 = new System.Windows.Forms.Label();
               this.btn_generate = new System.Windows.Forms.Button();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.button1 = new System.Windows.Forms.Button();
               this.btn_account = new System.Windows.Forms.Button();
               this.btn_rider = new System.Windows.Forms.Button();
               this.btn_stock = new System.Windows.Forms.Button();
               this.btn_employee = new System.Windows.Forms.Button();
               this.btn_shop = new System.Windows.Forms.Button();
               this.btn_orderdetail = new System.Windows.Forms.Button();
               this.shopkeeperDLBindingSource = new System.Windows.Forms.BindingSource(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.shopkeeperDLBindingSource)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(250, 20);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(244, 36);
               this.label1.TabIndex = 9;
               this.label1.Text = "Generate Report";
               // 
               // btn_generate
               // 
               this.btn_generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btn_generate.BackColor = System.Drawing.Color.White;
               this.btn_generate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_generate.ForeColor = System.Drawing.Color.Black;
               this.btn_generate.Location = new System.Drawing.Point(593, 447);
               this.btn_generate.Margin = new System.Windows.Forms.Padding(2);
               this.btn_generate.Name = "btn_generate";
               this.btn_generate.Size = new System.Drawing.Size(133, 43);
               this.btn_generate.TabIndex = 35;
               this.btn_generate.Text = "Generate pdf";
               this.btn_generate.UseVisualStyleBackColor = false;
               this.btn_generate.Click += new System.EventHandler(this.button1_Click);
               // 
               // dataGridView1
               // 
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(33, 83);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.RowHeadersWidth = 62;
               this.dataGridView1.Size = new System.Drawing.Size(693, 264);
               this.dataGridView1.TabIndex = 36;
               this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
               // 
               // button1
               // 
               this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.button1.BackColor = System.Drawing.Color.White;
               this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.ForeColor = System.Drawing.Color.Black;
               this.button1.Location = new System.Drawing.Point(33, 479);
               this.button1.Margin = new System.Windows.Forms.Padding(2);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(94, 43);
               this.button1.TabIndex = 40;
               this.button1.Text = "Back";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click_1);
               // 
               // btn_account
               // 
               this.btn_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btn_account.BackColor = System.Drawing.Color.White;
               this.btn_account.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_account.ForeColor = System.Drawing.Color.Black;
               this.btn_account.Location = new System.Drawing.Point(82, 380);
               this.btn_account.Margin = new System.Windows.Forms.Padding(2);
               this.btn_account.Name = "btn_account";
               this.btn_account.Size = new System.Drawing.Size(88, 43);
               this.btn_account.TabIndex = 41;
               this.btn_account.Text = "Account";
               this.btn_account.UseVisualStyleBackColor = false;
               this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
               // 
               // btn_rider
               // 
               this.btn_rider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btn_rider.BackColor = System.Drawing.Color.White;
               this.btn_rider.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_rider.ForeColor = System.Drawing.Color.Black;
               this.btn_rider.Location = new System.Drawing.Point(174, 380);
               this.btn_rider.Margin = new System.Windows.Forms.Padding(2);
               this.btn_rider.Name = "btn_rider";
               this.btn_rider.Size = new System.Drawing.Size(88, 43);
               this.btn_rider.TabIndex = 42;
               this.btn_rider.Text = "Rider";
               this.btn_rider.UseVisualStyleBackColor = false;
               this.btn_rider.Click += new System.EventHandler(this.btn_rider_Click);
               // 
               // btn_stock
               // 
               this.btn_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btn_stock.BackColor = System.Drawing.Color.White;
               this.btn_stock.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_stock.ForeColor = System.Drawing.Color.Black;
               this.btn_stock.Location = new System.Drawing.Point(266, 380);
               this.btn_stock.Margin = new System.Windows.Forms.Padding(2);
               this.btn_stock.Name = "btn_stock";
               this.btn_stock.Size = new System.Drawing.Size(88, 43);
               this.btn_stock.TabIndex = 43;
               this.btn_stock.Text = "Stock";
               this.btn_stock.UseVisualStyleBackColor = false;
               this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
               // 
               // btn_employee
               // 
               this.btn_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btn_employee.BackColor = System.Drawing.Color.White;
               this.btn_employee.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_employee.ForeColor = System.Drawing.Color.Black;
               this.btn_employee.Location = new System.Drawing.Point(358, 380);
               this.btn_employee.Margin = new System.Windows.Forms.Padding(2);
               this.btn_employee.Name = "btn_employee";
               this.btn_employee.Size = new System.Drawing.Size(98, 43);
               this.btn_employee.TabIndex = 44;
               this.btn_employee.Text = "Employee";
               this.btn_employee.UseVisualStyleBackColor = false;
               this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
               // 
               // btn_shop
               // 
               this.btn_shop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btn_shop.BackColor = System.Drawing.Color.White;
               this.btn_shop.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_shop.ForeColor = System.Drawing.Color.Black;
               this.btn_shop.Location = new System.Drawing.Point(460, 380);
               this.btn_shop.Margin = new System.Windows.Forms.Padding(2);
               this.btn_shop.Name = "btn_shop";
               this.btn_shop.Size = new System.Drawing.Size(116, 43);
               this.btn_shop.TabIndex = 45;
               this.btn_shop.Text = "Shopkeeper";
               this.btn_shop.UseVisualStyleBackColor = false;
               this.btn_shop.Click += new System.EventHandler(this.btn_shop_Click);
               // 
               // btn_orderdetail
               // 
               this.btn_orderdetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
               this.btn_orderdetail.BackColor = System.Drawing.Color.White;
               this.btn_orderdetail.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btn_orderdetail.ForeColor = System.Drawing.Color.Black;
               this.btn_orderdetail.Location = new System.Drawing.Point(580, 380);
               this.btn_orderdetail.Margin = new System.Windows.Forms.Padding(2);
               this.btn_orderdetail.Name = "btn_orderdetail";
               this.btn_orderdetail.Size = new System.Drawing.Size(131, 43);
               this.btn_orderdetail.TabIndex = 46;
               this.btn_orderdetail.Text = "Order Details";
               this.btn_orderdetail.UseVisualStyleBackColor = false;
               this.btn_orderdetail.Click += new System.EventHandler(this.btn_orderdetail_Click);
               // 
               // shopkeeperDLBindingSource
               // 
               this.shopkeeperDLBindingSource.DataSource = typeof(RMM.DL.shopkeeperDL);
               // 
               // Report
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.InactiveBorder;
               this.ClientSize = new System.Drawing.Size(784, 561);
               this.Controls.Add(this.btn_orderdetail);
               this.Controls.Add(this.btn_shop);
               this.Controls.Add(this.btn_employee);
               this.Controls.Add(this.btn_stock);
               this.Controls.Add(this.btn_rider);
               this.Controls.Add(this.btn_account);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.btn_generate);
               this.Controls.Add(this.label1);
               this.Margin = new System.Windows.Forms.Padding(2);
               this.MinimumSize = new System.Drawing.Size(800, 600);
               this.Name = "Report";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Generate_Report";
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.shopkeeperDLBindingSource)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_generate;
          private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button btn_account;
          private System.Windows.Forms.Button btn_rider;
          private System.Windows.Forms.Button btn_stock;
          private System.Windows.Forms.Button btn_employee;
          private System.Windows.Forms.Button btn_shop;
          private System.Windows.Forms.Button btn_orderdetail;
          private System.Windows.Forms.BindingSource shopkeeperDLBindingSource;
     }
}