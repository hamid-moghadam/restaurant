﻿namespace Restaurant
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
            this.productName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactorDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(12, 335);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(158, 20);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.Text = "0";
            // 
            // txtTotalPriceWithTax
            // 
            this.txtTotalPriceWithTax.Location = new System.Drawing.Point(12, 361);
            this.txtTotalPriceWithTax.Name = "txtTotalPriceWithTax";
            this.txtTotalPriceWithTax.ReadOnly = true;
            this.txtTotalPriceWithTax.Size = new System.Drawing.Size(158, 20);
            this.txtTotalPriceWithTax.TabIndex = 2;
            this.txtTotalPriceWithTax.Text = "0";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(583, 335);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(98, 40);
            this.submit.TabIndex = 3;
            this.submit.Text = "ثبت اطلاعات";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "مجموع قیمت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "مجموع قیمت با احتساب مالیات";
            // 
            // dgvFactorDetails
            // 
            this.dgvFactorDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactorDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.count,
            this.description,
            this.mainPrice,
            this.totalPrice});
            this.dgvFactorDetails.Location = new System.Drawing.Point(12, 12);
            this.dgvFactorDetails.Name = "dgvFactorDetails";
            this.dgvFactorDetails.Size = new System.Drawing.Size(669, 310);
            this.dgvFactorDetails.TabIndex = 6;
            this.dgvFactorDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactorDetails_CellValueChanged);
            this.dgvFactorDetails.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvFactorDetails_CurrentCellDirtyStateChanged);
            this.dgvFactorDetails.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvFactorDetails_RowsAdded);
            this.dgvFactorDetails.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvFactorDetails_UserDeletedRow);
            // 
            // productName
            // 
            this.productName.HeaderText = "نام محصول";
            this.productName.Name = "productName";
            // 
            // count
            // 
            this.count.HeaderText = "تعداد";
            this.count.Name = "count";
            // 
            // description
            // 
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            // 
            // mainPrice
            // 
            this.mainPrice.HeaderText = "قیمت پایه";
            this.mainPrice.Name = "mainPrice";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "مجموع قیمت";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 396);
            this.Controls.Add(this.dgvFactorDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.txtTotalPriceWithTax);
            this.Controls.Add(this.txtTotalPrice);
            this.Name = "Order";
            this.Text = "Order";
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
        private System.Windows.Forms.DataGridViewComboBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
    }
}