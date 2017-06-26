namespace Restaurant
{
    partial class Factors
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
            this.dgvFactors = new System.Windows.Forms.DataGridView();
            this.toPdf = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceWithTax = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtTotalPriceWithTax = new System.Windows.Forms.TextBox();
            this.retrunHome = new System.Windows.Forms.Button();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.btnDeleteFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFactors
            // 
            this.dgvFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactors.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFactors.Enabled = false;
            this.dgvFactors.Location = new System.Drawing.Point(0, 0);
            this.dgvFactors.Name = "dgvFactors";
            this.dgvFactors.Size = new System.Drawing.Size(730, 331);
            this.dgvFactors.TabIndex = 0;
            this.dgvFactors.Visible = false;
            this.dgvFactors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactors_CellClick);
            // 
            // toPdf
            // 
            this.toPdf.Location = new System.Drawing.Point(665, 337);
            this.toPdf.Name = "toPdf";
            this.toPdf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toPdf.Size = new System.Drawing.Size(53, 48);
            this.toPdf.TabIndex = 1;
            this.toPdf.Text = "تبدیل به pdf";
            this.toPdf.UseVisualStyleBackColor = true;
            this.toPdf.Click += new System.EventHandler(this.toPdf_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(473, 437);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPrice.Size = new System.Drawing.Size(95, 13);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "مجموع فاکتور ها : ";
            // 
            // lblTotalPriceWithTax
            // 
            this.lblTotalPriceWithTax.AutoSize = true;
            this.lblTotalPriceWithTax.Location = new System.Drawing.Point(29, 437);
            this.lblTotalPriceWithTax.Name = "lblTotalPriceWithTax";
            this.lblTotalPriceWithTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPriceWithTax.Size = new System.Drawing.Size(172, 13);
            this.lblTotalPriceWithTax.TabIndex = 5;
            this.lblTotalPriceWithTax.Text = "مجموع فاکتور ها با احتساب مالیات :";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(428, 469);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(181, 20);
            this.txtTotalPrice.TabIndex = 6;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalPriceWithTax
            // 
            this.txtTotalPriceWithTax.Location = new System.Drawing.Point(27, 469);
            this.txtTotalPriceWithTax.Name = "txtTotalPriceWithTax";
            this.txtTotalPriceWithTax.ReadOnly = true;
            this.txtTotalPriceWithTax.Size = new System.Drawing.Size(181, 20);
            this.txtTotalPriceWithTax.TabIndex = 7;
            this.txtTotalPriceWithTax.Text = "0";
            this.txtTotalPriceWithTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // retrunHome
            // 
            this.retrunHome.Location = new System.Drawing.Point(614, 499);
            this.retrunHome.Name = "retrunHome";
            this.retrunHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.retrunHome.Size = new System.Drawing.Size(104, 36);
            this.retrunHome.TabIndex = 8;
            this.retrunHome.Text = "بازگشت به منو اصلی";
            this.retrunHome.UseVisualStyleBackColor = true;
            this.retrunHome.Click += new System.EventHandler(this.retrunHome_Click);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(291, 388);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(100, 20);
            this.txtStartDate.TabIndex = 9;
            this.txtStartDate.Text = "13xx/xx/xx";
            this.txtStartDate.Click += new System.EventHandler(this.txtStartDate_Click);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(455, 388);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtEndDate.TabIndex = 10;
            this.txtEndDate.Text = "13xx/xx/xx";
            this.txtEndDate.Click += new System.EventHandler(this.txtEndDate_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(309, 360);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(62, 13);
            this.lblStartDate.TabIndex = 11;
            this.lblStartDate.Text = "تاریخ شروع";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(476, 360);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 13);
            this.lblEndDate.TabIndex = 12;
            this.lblEndDate.Text = "تاریخ پایان";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(589, 388);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFilter.Size = new System.Drawing.Size(129, 13);
            this.lblFilter.TabIndex = 13;
            this.lblFilter.Text = "فیلتر براساس تاریخ فاکتور";
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.Location = new System.Drawing.Point(158, 377);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(102, 35);
            this.btnFilterDate.TabIndex = 14;
            this.btnFilterDate.Text = "فیلتر تاریخ";
            this.btnFilterDate.UseVisualStyleBackColor = true;
            this.btnFilterDate.Click += new System.EventHandler(this.btnFilterDate_Click);
            // 
            // btnDeleteFilter
            // 
            this.btnDeleteFilter.Location = new System.Drawing.Point(29, 377);
            this.btnDeleteFilter.Name = "btnDeleteFilter";
            this.btnDeleteFilter.Size = new System.Drawing.Size(102, 35);
            this.btnDeleteFilter.TabIndex = 15;
            this.btnDeleteFilter.Text = "حذف فیلتر";
            this.btnDeleteFilter.UseVisualStyleBackColor = true;
            this.btnDeleteFilter.Click += new System.EventHandler(this.btnDeleteFilter_Click);
            // 
            // Factors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 547);
            this.Controls.Add(this.btnDeleteFilter);
            this.Controls.Add(this.btnFilterDate);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.retrunHome);
            this.Controls.Add(this.txtTotalPriceWithTax);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPriceWithTax);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.toPdf);
            this.Controls.Add(this.dgvFactors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Factors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاکتور ها";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFactors;
        private System.Windows.Forms.Button toPdf;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceWithTax;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPriceWithTax;
        private System.Windows.Forms.Button retrunHome;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.Button btnDeleteFilter;
    }
}