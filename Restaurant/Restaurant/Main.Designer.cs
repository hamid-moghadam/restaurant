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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnChangeProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvFactors = new System.Windows.Forms.DataGridView();
            this.lblAvailableDgv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailableProduct
            // 
            this.dgvAvailableProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableProduct.Location = new System.Drawing.Point(12, 37);
            this.dgvAvailableProduct.Name = "dgvAvailableProduct";
            this.dgvAvailableProduct.Size = new System.Drawing.Size(243, 318);
            this.dgvAvailableProduct.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(12, 375);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(130, 28);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "اضافه کردن به منو باز";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnChangeProduct
            // 
            this.btnChangeProduct.Location = new System.Drawing.Point(12, 409);
            this.btnChangeProduct.Name = "btnChangeProduct";
            this.btnChangeProduct.Size = new System.Drawing.Size(130, 28);
            this.btnChangeProduct.TabIndex = 2;
            this.btnChangeProduct.Text = "تغییر منو باز";
            this.btnChangeProduct.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "مشاهده تمامی فاکتور ها";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 84);
            this.button2.TabIndex = 4;
            this.button2.Text = "سفارش جدید";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvFactors
            // 
            this.dgvFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactors.Location = new System.Drawing.Point(261, 37);
            this.dgvFactors.Name = "dgvFactors";
            this.dgvFactors.Size = new System.Drawing.Size(440, 318);
            this.dgvFactors.TabIndex = 5;
            // 
            // lblAvailableDgv
            // 
            this.lblAvailableDgv.AutoSize = true;
            this.lblAvailableDgv.Location = new System.Drawing.Point(111, 9);
            this.lblAvailableDgv.Name = "lblAvailableDgv";
            this.lblAvailableDgv.Size = new System.Drawing.Size(22, 13);
            this.lblAvailableDgv.TabIndex = 6;
            this.lblAvailableDgv.Text = "منو";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "فاکتور های امروز";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAvailableDgv);
            this.Controls.Add(this.dgvFactors);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChangeProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dgvAvailableProduct);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvailableProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnChangeProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvFactors;
        private System.Windows.Forms.Label lblAvailableDgv;
        private System.Windows.Forms.Label label1;
    }
}