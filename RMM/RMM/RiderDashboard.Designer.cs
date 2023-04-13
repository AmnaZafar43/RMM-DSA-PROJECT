namespace RMM
{
    partial class RiderDashboard
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
               this.btnShop = new System.Windows.Forms.Button();
               this.btnOD = new System.Windows.Forms.Button();
               this.btnRoute = new System.Windows.Forms.Button();
               this.btnOrder = new System.Windows.Forms.Button();
               this.btnlog = new System.Windows.Forms.Button();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.panel3 = new System.Windows.Forms.Panel();
               this.panel2 = new System.Windows.Forms.Panel();
               this.panel1 = new System.Windows.Forms.Panel();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(38, 137);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(87, 35);
               this.label1.TabIndex = 3;
               this.label1.Text = "Rider";
               // 
               // btnShop
               // 
               this.btnShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.btnShop.BackColor = System.Drawing.SystemColors.GrayText;
               this.btnShop.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnShop.ForeColor = System.Drawing.Color.White;
               this.btnShop.Location = new System.Drawing.Point(237, 0);
               this.btnShop.Margin = new System.Windows.Forms.Padding(2);
               this.btnShop.Name = "btnShop";
               this.btnShop.Size = new System.Drawing.Size(120, 70);
               this.btnShop.TabIndex = 4;
               this.btnShop.Text = "Add Shopkeeper";
               this.btnShop.UseVisualStyleBackColor = false;
               this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
               // 
               // btnOD
               // 
               this.btnOD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.btnOD.BackColor = System.Drawing.SystemColors.GrayText;
               this.btnOD.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnOD.ForeColor = System.Drawing.Color.White;
               this.btnOD.Location = new System.Drawing.Point(616, 0);
               this.btnOD.Margin = new System.Windows.Forms.Padding(2);
               this.btnOD.Name = "btnOD";
               this.btnOD.Size = new System.Drawing.Size(99, 70);
               this.btnOD.TabIndex = 5;
               this.btnOD.Text = "Order Details";
               this.btnOD.UseVisualStyleBackColor = false;
               this.btnOD.Click += new System.EventHandler(this.btnOD_Click);
               // 
               // btnRoute
               // 
               this.btnRoute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.btnRoute.BackColor = System.Drawing.SystemColors.GrayText;
               this.btnRoute.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnRoute.ForeColor = System.Drawing.Color.White;
               this.btnRoute.Location = new System.Drawing.Point(521, 0);
               this.btnRoute.Margin = new System.Windows.Forms.Padding(2);
               this.btnRoute.Name = "btnRoute";
               this.btnRoute.Size = new System.Drawing.Size(99, 70);
               this.btnRoute.TabIndex = 6;
               this.btnRoute.Text = "Route";
               this.btnRoute.UseVisualStyleBackColor = false;
               this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
               // 
               // btnOrder
               // 
               this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.btnOrder.BackColor = System.Drawing.SystemColors.GrayText;
               this.btnOrder.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnOrder.ForeColor = System.Drawing.Color.White;
               this.btnOrder.Location = new System.Drawing.Point(353, 0);
               this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
               this.btnOrder.Name = "btnOrder";
               this.btnOrder.Size = new System.Drawing.Size(99, 70);
               this.btnOrder.TabIndex = 7;
               this.btnOrder.Text = "Place Order";
               this.btnOrder.UseVisualStyleBackColor = false;
               this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
               // 
               // btnlog
               // 
               this.btnlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
               this.btnlog.BackColor = System.Drawing.SystemColors.GrayText;
               this.btnlog.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnlog.ForeColor = System.Drawing.Color.White;
               this.btnlog.Location = new System.Drawing.Point(28, 493);
               this.btnlog.Margin = new System.Windows.Forms.Padding(2);
               this.btnlog.Name = "btnlog";
               this.btnlog.Size = new System.Drawing.Size(105, 54);
               this.btnlog.TabIndex = 11;
               this.btnlog.Text = "Logout";
               this.btnlog.UseVisualStyleBackColor = false;
               this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
               // 
               // label3
               // 
               this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(487, 186);
               this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(195, 100);
               this.label3.TabIndex = 19;
               this.label3.Text = "Orders\r\n\r\nIncreased by   60%\r\nDecreased by  10%\r\n";
               this.label3.Click += new System.EventHandler(this.label3_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(139, 186);
               this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(195, 100);
               this.label2.TabIndex = 18;
               this.label2.Text = "Routes\r\n\r\nIncreased by   12%\r\nDecreased by  20%\r\n";
               this.label2.Click += new System.EventHandler(this.label2_Click);
               // 
               // panel3
               // 
               this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.panel3.BackColor = System.Drawing.Color.Transparent;
               this.panel3.BackgroundImage = global::RMM.Properties.Resources.p4_removebg_preview;
               this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel3.Location = new System.Drawing.Point(590, 167);
               this.panel3.Margin = new System.Windows.Forms.Padding(2);
               this.panel3.Name = "panel3";
               this.panel3.Size = new System.Drawing.Size(115, 65);
               this.panel3.TabIndex = 21;
               this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
               // 
               // panel2
               // 
               this.panel2.BackColor = System.Drawing.Color.Transparent;
               this.panel2.BackgroundImage = global::RMM.Properties.Resources.p9_removebg_preview;
               this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel2.Location = new System.Drawing.Point(211, 157);
               this.panel2.Margin = new System.Windows.Forms.Padding(2);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(111, 68);
               this.panel2.TabIndex = 20;
               this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
               // 
               // panel1
               // 
               this.panel1.BackgroundImage = global::RMM.Properties.Resources.p7_removebg_preview;
               this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel1.Location = new System.Drawing.Point(8, 8);
               this.panel1.Margin = new System.Windows.Forms.Padding(2);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(149, 127);
               this.panel1.TabIndex = 1;
               this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
               // 
               // RiderDashboard
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.InactiveBorder;
               this.ClientSize = new System.Drawing.Size(784, 561);
               this.Controls.Add(this.panel3);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.btnlog);
               this.Controls.Add(this.btnOrder);
               this.Controls.Add(this.btnRoute);
               this.Controls.Add(this.btnOD);
               this.Controls.Add(this.btnShop);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.panel1);
               this.Margin = new System.Windows.Forms.Padding(2);
               this.MinimumSize = new System.Drawing.Size(800, 600);
               this.Name = "RiderDashboard";
               this.Text = "RiderDashboard";
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnOD;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}