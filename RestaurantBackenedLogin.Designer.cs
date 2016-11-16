namespace MealRestaurant
{
    partial class RestaurantBackenedLogin
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
            this.labAccount = new System.Windows.Forms.Label();
            this.tboAccount = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.tboPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAccount
            // 
            this.labAccount.Font = new System.Drawing.Font("MingLiU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAccount.Location = new System.Drawing.Point(26, 61);
            this.labAccount.Name = "labAccount";
            this.labAccount.Size = new System.Drawing.Size(75, 23);
            this.labAccount.TabIndex = 0;
            this.labAccount.Text = "帳號 : ";
            // 
            // tboAccount
            // 
            this.tboAccount.Location = new System.Drawing.Point(118, 64);
            this.tboAccount.Name = "tboAccount";
            this.tboAccount.Size = new System.Drawing.Size(162, 20);
            this.tboAccount.TabIndex = 1;
            // 
            // labPassword
            // 
            this.labPassword.Font = new System.Drawing.Font("MingLiU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.Location = new System.Drawing.Point(26, 104);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(75, 23);
            this.labPassword.TabIndex = 2;
            this.labPassword.Text = "密碼 : ";
            // 
            // tboPassword
            // 
            this.tboPassword.Location = new System.Drawing.Point(118, 105);
            this.tboPassword.Name = "tboPassword";
            this.tboPassword.PasswordChar = '*';
            this.tboPassword.Size = new System.Drawing.Size(162, 20);
            this.tboPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Blue;
            this.btnLogin.Location = new System.Drawing.Point(107, 147);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // RestaurantBackenedLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 262);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tboPassword);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.tboAccount);
            this.Controls.Add(this.labAccount);
            this.Name = "RestaurantBackenedLogin";
            this.Text = "RestaurantBackenedLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAccount;
        private System.Windows.Forms.TextBox tboAccount;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox tboPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}