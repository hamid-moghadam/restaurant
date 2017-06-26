namespace Restaurant
{
    partial class Order
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
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtTotalPriceWithTax = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFactorDetails = new System.Windows.Forms.DataGridView();
            this.retrunHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactorDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(12, 490);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(158, 20);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.Text = "0";
            // 
            // txtTotalPriceWithTax
            // 
            this.txtTotalPriceWithTax.Location = new System.Drawing.Point(12, 516);
            this.txtTotalPriceWithTax.Name = "txtTotalPriceWithTax";
            this.txtTotalPriceWithTax.ReadOnly = true;
            this.txtTotalPriceWithTax.Size = new System.Drawing.Size(158, 20);
            this.txtTotalPriceWithTax.TabIndex = 2;
            this.txtTotalPriceWithTax.Text = "0";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(463, 490);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(138, 53);
            this.submit.TabIndex = 3;
            this.submit.Text = "ثبت اطلاعات";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "مجموع قیمت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "مجموع قیمت با احتساب مالیات";
            // 
            // dgvFactorDetails
            // 
            this.dgvFactorDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactorDetails.Location = new System.Drawing.Point(12, 12);
            this.dgvFactorDetails.Name = "dgvFactorDetails";
            this.dgvFactorDetails.Size = new System.Drawing.Size(669, 461);
            this.dgvFactorDetails.TabIndex = 6;
            this.dgvFactorDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactorDetails_CellValueChanged);
            this.dgvFactorDetails.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvFactorDetails_CurrentCellDirtyStateChanged);
            this.dgvFactorDetails.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvFactorDetails_UserDeletedRow);
            // 
            // retrunHome
            // 
            this.retrunHome.Location = new System.Drawing.Point(607, 493);
            this.retrunHome.Name = "retrunHome";
            this.retrunHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.retrunHome.Size = new System.Drawing.Size(74, 53);
            this.retrunHome.TabIndex = 9;
            this.retrunHome.Text = "بازگشت به منو اصلی";
            this.retrunHome.UseVisualStyleBackColor = true;
            this.retrunHome.Click += new System.EventHandler(this.retrunHome_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 558);
            this.Controls.Add(this.retrunHome);
            this.Controls.Add(this.dgvFactorDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.txtTotalPriceWithTax);
            this.Controls.Add(this.txtTotalPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سفارشات";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactorDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPriceWithTax;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFactorDetails;
        private System.Windows.Forms.Button retrunHome;
    }
}