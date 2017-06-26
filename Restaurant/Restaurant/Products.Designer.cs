namespace Restaurant
{
    partial class Products
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
            this.retrunHome = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // retrunHome
            // 
            this.retrunHome.Location = new System.Drawing.Point(12, 498);
            this.retrunHome.Name = "retrunHome";
            this.retrunHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.retrunHome.Size = new System.Drawing.Size(141, 30);
            this.retrunHome.TabIndex = 9;
            this.retrunHome.Text = "بازگشت به منو اصلی";
            this.retrunHome.UseVisualStyleBackColor = true;
            this.retrunHome.Click += new System.EventHandler(this.retrunHome_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(658, 413);
            this.dgvProducts.TabIndex = 10;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(27, 456);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 11;
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Location = new System.Drawing.Point(133, 456);
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(100, 20);
            this.txtProductDesc.TabIndex = 12;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(239, 456);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 20);
            this.txtProductPrice.TabIndex = 13;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(45, 427);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(57, 13);
            this.lblProduct.TabIndex = 15;
            this.lblProduct.Text = "نام محصول";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(159, 427);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(49, 13);
            this.lblDesc.TabIndex = 16;
            this.lblDesc.Text = "توضیحات";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(275, 427);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(30, 13);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "قیمت";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(374, 427);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(61, 13);
            this.lblProductType.TabIndex = 18;
            this.lblProductType.Text = "نوع محصول";
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(345, 455);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(121, 21);
            this.cmbProductType.TabIndex = 19;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(535, 449);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddProduct.Size = new System.Drawing.Size(111, 31);
            this.btnAddProduct.TabIndex = 20;
            this.btnAddProduct.Text = "اضافه کردن محصول";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 540);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductDesc);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.retrunHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محصولات";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retrunHome;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductDesc;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Button btnAddProduct;
    }
}