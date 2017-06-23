namespace Restaurant
{
    partial class SignIn
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
            this.lblResPass = new System.Windows.Forms.Label();
            this.lblResUser = new System.Windows.Forms.Label();
            this.txtResPass = new System.Windows.Forms.TextBox();
            this.txtResUser = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResPass
            // 
            this.lblResPass.AutoSize = true;
            this.lblResPass.Location = new System.Drawing.Point(214, 70);
            this.lblResPass.Name = "lblResPass";
            this.lblResPass.Size = new System.Drawing.Size(52, 13);
            this.lblResPass.TabIndex = 12;
            this.lblResPass.Text = "کلمه عبور";
            // 
            // lblResUser
            // 
            this.lblResUser.AutoSize = true;
            this.lblResUser.Location = new System.Drawing.Point(214, 37);
            this.lblResUser.Name = "lblResUser";
            this.lblResUser.Size = new System.Drawing.Size(58, 13);
            this.lblResUser.TabIndex = 11;
            this.lblResUser.Text = "نام کاربری";
            // 
            // txtResPass
            // 
            this.txtResPass.Location = new System.Drawing.Point(12, 70);
            this.txtResPass.Name = "txtResPass";
            this.txtResPass.PasswordChar = '*';
            this.txtResPass.Size = new System.Drawing.Size(166, 20);
            this.txtResPass.TabIndex = 10;
            // 
            // txtResUser
            // 
            this.txtResUser.Location = new System.Drawing.Point(12, 30);
            this.txtResUser.Name = "txtResUser";
            this.txtResUser.Size = new System.Drawing.Size(166, 20);
            this.txtResUser.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(87, 129);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 33);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "ورود";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblResPass);
            this.Controls.Add(this.lblResUser);
            this.Controls.Add(this.txtResPass);
            this.Controls.Add(this.txtResUser);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResPass;
        private System.Windows.Forms.Label lblResUser;
        private System.Windows.Forms.TextBox txtResPass;
        private System.Windows.Forms.TextBox txtResUser;
        private System.Windows.Forms.Button btnSubmit;
    }
}