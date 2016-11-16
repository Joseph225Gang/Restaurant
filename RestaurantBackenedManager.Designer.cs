namespace MealRestaurant
{
    partial class RestaurantBackenedManager
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
            this.tabMeal = new System.Windows.Forms.TabControl();
            this.tabMealManager = new System.Windows.Forms.TabPage();
            this.listManager = new System.Windows.Forms.ListBox();
            this.tablCategoryManager = new System.Windows.Forms.TabPage();
            this.gboManager = new System.Windows.Forms.GroupBox();
            this.tboDescription = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tboPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabMeal.SuspendLayout();
            this.tabMealManager.SuspendLayout();
            this.gboManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMeal
            // 
            this.tabMeal.Controls.Add(this.tabMealManager);
            this.tabMeal.Controls.Add(this.tablCategoryManager);
            this.tabMeal.Location = new System.Drawing.Point(12, 26);
            this.tabMeal.Name = "tabMeal";
            this.tabMeal.SelectedIndex = 0;
            this.tabMeal.Size = new System.Drawing.Size(249, 293);
            this.tabMeal.TabIndex = 1;
            this.tabMeal.SelectedIndexChanged += new System.EventHandler(this.tabMeal_SelectedIndexChanged);
            // 
            // tabMealManager
            // 
            this.tabMealManager.Controls.Add(this.listManager);
            this.tabMealManager.Location = new System.Drawing.Point(4, 22);
            this.tabMealManager.Name = "tabMealManager";
            this.tabMealManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabMealManager.Size = new System.Drawing.Size(241, 267);
            this.tabMealManager.TabIndex = 0;
            this.tabMealManager.Text = "MealManager";
            this.tabMealManager.UseVisualStyleBackColor = true;
            // 
            // listManager
            // 
            this.listManager.FormattingEnabled = true;
            this.listManager.Location = new System.Drawing.Point(7, 20);
            this.listManager.Name = "listManager";
            this.listManager.Size = new System.Drawing.Size(219, 225);
            this.listManager.TabIndex = 0;
            this.listManager.SelectedIndexChanged += new System.EventHandler(this.listManager_SelectedIndexChanged);
            // 
            // tablCategoryManager
            // 
            this.tablCategoryManager.Location = new System.Drawing.Point(4, 22);
            this.tablCategoryManager.Name = "tablCategoryManager";
            this.tablCategoryManager.Padding = new System.Windows.Forms.Padding(3);
            this.tablCategoryManager.Size = new System.Drawing.Size(241, 267);
            this.tablCategoryManager.TabIndex = 1;
            this.tablCategoryManager.Text = "CategoryManager";
            this.tablCategoryManager.UseVisualStyleBackColor = true;
            // 
            // gboManager
            // 
            this.gboManager.BackColor = System.Drawing.Color.White;
            this.gboManager.Controls.Add(this.tboDescription);
            this.gboManager.Controls.Add(this.cboCategory);
            this.gboManager.Controls.Add(this.label6);
            this.gboManager.Controls.Add(this.btnBrowse);
            this.gboManager.Controls.Add(this.tboPath);
            this.gboManager.Controls.Add(this.label5);
            this.gboManager.Controls.Add(this.label4);
            this.gboManager.Controls.Add(this.label3);
            this.gboManager.Controls.Add(this.tboPrice);
            this.gboManager.Controls.Add(this.label2);
            this.gboManager.Controls.Add(this.tboName);
            this.gboManager.Controls.Add(this.label1);
            this.gboManager.Location = new System.Drawing.Point(291, 26);
            this.gboManager.Name = "gboManager";
            this.gboManager.Size = new System.Drawing.Size(468, 293);
            this.gboManager.TabIndex = 2;
            this.gboManager.TabStop = false;
            this.gboManager.Text = "EditMeal";
            // 
            // tboDescription
            // 
            this.tboDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tboDescription.Location = new System.Drawing.Point(15, 175);
            this.tboDescription.Multiline = true;
            this.tboDescription.Name = "tboDescription";
            this.tboDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboDescription.Size = new System.Drawing.Size(431, 92);
            this.tboDescription.TabIndex = 11;
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(337, 82);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 21);
            this.cboCategory.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Meal Description";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(371, 116);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tboPath
            // 
            this.tboPath.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tboPath.Location = new System.Drawing.Point(168, 121);
            this.tboPath.Name = "tboPath";
            this.tboPath.Size = new System.Drawing.Size(197, 20);
            this.tboPath.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Meal Image Relative Path(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "MealCategory(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NTD";
            // 
            // tboPrice
            // 
            this.tboPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tboPrice.Location = new System.Drawing.Point(83, 83);
            this.tboPrice.Name = "tboPrice";
            this.tboPrice.Size = new System.Drawing.Size(112, 20);
            this.tboPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MealPrice(*)";
            // 
            // tboName
            // 
            this.tboName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tboName.Location = new System.Drawing.Point(83, 42);
            this.tboName.Name = "tboName";
            this.tboName.Size = new System.Drawing.Size(246, 20);
            this.tboName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MealName (*)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(678, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add New Meal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(132, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Selected Meal";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // RestaurantBackenedManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 355);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gboManager);
            this.Controls.Add(this.tabMeal);
            this.Name = "RestaurantBackenedManager";
            this.Text = "RestaurantBackenedManager";
            this.Load += new System.EventHandler(this.RestaurantBackenedManager_Load);
            this.tabMeal.ResumeLayout(false);
            this.tabMealManager.ResumeLayout(false);
            this.gboManager.ResumeLayout(false);
            this.gboManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMeal;
        private System.Windows.Forms.TabPage tabMealManager;
        private System.Windows.Forms.TabPage tablCategoryManager;
        private System.Windows.Forms.GroupBox gboManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ListBox listManager;
        private System.Windows.Forms.TextBox tboDescription;
    }
}