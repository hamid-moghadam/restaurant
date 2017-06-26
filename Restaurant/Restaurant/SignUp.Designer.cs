namespace Restaurant
{
    partial class SignUp
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
            this.txtResName = new System.Windows.Forms.TextBox();
            this.txtResOwner = new System.Windows.Forms.TextBox();
            this.txtResUser = new System.Windows.Forms.TextBox();
            this.txtResPass = new System.Windows.Forms.TextBox();
            this.txtResTax = new System.Windows.Forms.TextBox();
            this.lblResName = new System.Windows.Forms.Label();
            this.lblResOwner = new System.Windows.Forms.Label();
            this.lblResUser = new System.Windows.Forms.Label();
            this.lblResPass = new System.Windows.Forms.Label();
            this.lblResTax = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResName
            // 
            this.txtResName.Location = new System.Drawing.Point(32, 27);
            this.txtResName.Name = "txtResName";
            this.txtResName.Size = new System.Drawing.Size(166, 20);
            this.txtResName.TabIndex = 0;
            // 
            // txtResOwner
            // 
            this.txtResOwner.Location = new System.Drawing.Point(32, 65);
            this.txtResOwner.Name = "txtResOwner";
            this.txtResOwner.Size = new System.Drawing.Size(166, 20);
            this.txtResOwner.TabIndex = 1;
            // 
            // txtResUser
            // 
            this.txtResUser.Location = new System.Drawing.Point(32, 103);
            this.txtResUser.Name = "txtResUser";
            this.txtResUser.Size = new System.Drawing.Size(166, 20);
            this.txtResUser.TabIndex = 2;
            // 
            // txtResPass
            // 
            this.txtResPass.Location = new System.Drawing.Point(32, 143);
            this.txtResPass.Name = "txtResPass";
            this.txtResPass.PasswordChar = '*';
            this.txtResPass.Size = new System.Drawing.Size(166, 20);
            this.txtResPass.TabIndex = 3;
            // 
            // txtResTax
            // 
            this.txtResTax.Location = new System.Drawing.Point(32, 184);
            this.txtResTax.Name = "txtResTax";
            this.txtResTax.Size = new System.Drawing.Size(166, 20);
            this.txtResTax.TabIndex = 4;
            // 
            // lblResName
            // 
            this.lblResName.AutoSize = true;
            this.lblResName.Location = new System.Drawing.Point(234, 30);
            this.lblResName.Name = "lblResName";
            this.lblResName.Size = new System.Drawing.Size(62, 13);
            this.lblResName.TabIndex = 5;
            this.lblResName.Text = "نام رستوران";
            // 
            // lblResOwner
            // 
            this.lblResOwner.AutoSize = true;
            this.lblResOwner.Location = new System.Drawing.Point(234, 68);
            this.lblResOwner.Name = "lblResOwner";
            this.lblResOwner.Size = new System.Drawing.Size(68, 13);
            this.lblResOwner.TabIndex = 6;
            this.lblResOwner.Text = "مالک رستوران";
            // 
            // lblResUser
            // 
            this.lblResUser.AutoSize = true;
            this.lblResUser.Location = new System.Drawing.Point(234, 110);
            this.lblResUser.Name = "lblResUser";
            this.lblResUser.Size = new System.Drawing.Size(58, 13);
            this.lblResUser.TabIndex = 7;
            this.lblResUser.Text = "نام کاربری";
            // 
            // lblResPass
            // 
            this.lblResPass.AutoSize = true;
            this.lblResPass.Location = new System.Drawing.Point(234, 143);
            this.lblResPass.Name = "lblResPass";
            this.lblResPass.Size = new System.Drawing.Size(52, 13);
            this.lblResPass.TabIndex = 8;
            this.lblResPass.Text = "کلمه عبور";
            // 
            // lblResTax
            // 
            this.lblResTax.AutoSize = true;
            this.lblResTax.Location = new System.Drawing.Point(240, 184);
            this.lblResTax.Name = "lblResTax";
            this.lblResTax.Size = new System.Drawing.Size(35, 13);
            this.lblResTax.TabIndex = 9;
            this.lblResTax.Text = "مالیات";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(112, 237);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 33);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 282);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblResTax);
            this.Controls.Add(this.lblResPass);
            this.Controls.Add(this.lblResUser);
            this.Controls.Add(this.lblResOwner);
            this.Controls.Add(this.lblResName);
            this.Controls.Add(this.txtResTax);
            this.Controls.Add(this.txtResPass);
            this.Controls.Add(this.txtResUser);
            this.Controls.Add(this.txtResOwner);
            this.Controls.Add(this.txtResName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت نام";
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.SignUp_InputLanguageChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResName;
        private System.Windows.Forms.TextBox txtResOwner;
        private System.Windows.Forms.TextBox txtResUser;
        private System.Windows.Forms.TextBox txtResPass;
        private System.Windows.Forms.TextBox txtResTax;
        private System.Windows.Forms.Label lblResName;
        private System.Windows.Forms.Label lblResOwner;
        private System.Windows.Forms.Label lblResUser;
        private System.Windows.Forms.Label lblResPass;
        private System.Windows.Forms.Label lblResTax;
        private System.Windows.Forms.Button btnSubmit;
    }
}

