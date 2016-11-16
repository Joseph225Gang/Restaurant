namespace MealRestaurant
{
    partial class StartUpForm
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
            this.btnFronted = new System.Windows.Forms.Button();
            this.btnBackened = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFronted
            // 
            this.btnFronted.Location = new System.Drawing.Point(12, 12);
            this.btnFronted.Name = "btnFronted";
            this.btnFronted.Size = new System.Drawing.Size(250, 70);
            this.btnFronted.TabIndex = 0;
            this.btnFronted.Text = "Customer(fronted)";
            this.btnFronted.UseVisualStyleBackColor = true;
            this.btnFronted.Click += new System.EventHandler(this.btnFronted_Click);
            // 
            // btnBackened
            // 
            this.btnBackened.Location = new System.Drawing.Point(283, 12);
            this.btnBackened.Name = "btnBackened";
            this.btnBackened.Size = new System.Drawing.Size(250, 70);
            this.btnBackened.TabIndex = 1;
            this.btnBackened.Text = "Restaurant(backened)";
            this.btnBackened.UseVisualStyleBackColor = true;
            this.btnBackened.Click += new System.EventHandler(this.btnBackened_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(386, 89);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 66);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 167);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackened);
            this.Controls.Add(this.btnFronted);
            this.Name = "StartUpForm";
            this.Text = "Start Up";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFronted;
        private System.Windows.Forms.Button btnBackened;
        private System.Windows.Forms.Button btnExit;
    }
}