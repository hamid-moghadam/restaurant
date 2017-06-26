namespace Restaurant
{
    partial class Main
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
            this.dgvAvailableProduct = new System.Windows.Forms.DataGridView();
            this.btnAddProductToMenu = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnFactor = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dgvFactors = new System.Windows.Forms.DataGridView();
            this.lblAvailableDgv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailableProduct
            // 
            this.dgvAvailableProduct.AllowUserToDeleteRows = false;
            this.dgvAvailableProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableProduct.Location = new System.Drawing.Point(12, 259);
            this.dgvAvailableProduct.Name = "dgvAvailableProduct";
            this.dgvAvailableProduct.Size = new System.Drawing.Size(689, 272);
            this.dgvAvailableProduct.TabIndex = 0;
            this.dgvAvailableProduct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAvailableProduct_CellMouseClick);
            this.dgvAvailableProduct.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvAvailableProduct_CurrentCellDirtyStateChanged);
            // 
            // btnAddProductToMenu
            // 
            this.btnAddProductToMenu.Location = new System.Drawing.Point(348, 547);
            this.btnAddProductToMenu.Name = "btnAddProductToMenu";
            this.btnAddProductToMenu.Size = new System.Drawing.Size(130, 28);
            this.btnAddProductToMenu.TabIndex = 1;
            this.btnAddProductToMenu.Text = "اضافه کردن به منو باز";
            this.btnAddProductToMenu.UseVisualStyleBackColor = true;
            this.btnAddProductToMenu.Click += new System.EventHandler(this.btnAddProductToMenu_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(285, 614);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(130, 28);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "اضافه کردن محصول";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnFactor
            // 
            this.btnFactor.Location = new System.Drawing.Point(12, 610);
            this.btnFactor.Name = "btnFactor";
            this.btnFactor.Size = new System.Drawing.Size(138, 32);
            this.btnFactor.TabIndex = 3;
            this.btnFactor.Text = "مشاهده همه فاکتور ها";
            this.btnFactor.UseVisualStyleBackColor = true;
            this.btnFactor.Click += new System.EventHandler(this.btnFactor_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(549, 614);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(152, 28);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "سفارش جدید";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // dgvFactors
            // 
            this.dgvFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactors.Location = new System.Drawing.Point(12, 25);
            this.dgvFactors.Name = "dgvFactors";
            this.dgvFactors.Size = new System.Drawing.Size(689, 192);
            this.dgvFactors.TabIndex = 5;
            this.dgvFactors.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFactors_CellMouseClick);
            // 
            // lblAvailableDgv
            // 
            this.lblAvailableDgv.AutoSize = true;
            this.lblAvailableDgv.Location = new System.Drawing.Point(345, 234);
            this.lblAvailableDgv.Name = "lblAvailableDgv";
            this.lblAvailableDgv.Size = new System.Drawing.Size(22, 13);
            this.lblAvailableDgv.TabIndex = 6;
            this.lblAvailableDgv.Text = "منو";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "فاکتور های امروز";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 552);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 654);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAvailableDgv);
            this.Controls.Add(this.dgvFactors);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnFactor);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnAddProductToMenu);
            this.Controls.Add(this.dgvAvailableProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه اصلی";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvailableProduct;
        private System.Windows.Forms.Button btnAddProductToMenu;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnFactor;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridView dgvFactors;
        private System.Windows.Forms.Label lblAvailableDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}