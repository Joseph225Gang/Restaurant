namespace MealRestaurant
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.labPage = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTotal = new System.Windows.Forms.Label();
            this.RichTextArea = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewNumericUpDownColumn1 = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this.tabMeal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnList9 = new System.Windows.Forms.Button();
            this.btnList1 = new System.Windows.Forms.Button();
            this.btnList8 = new System.Windows.Forms.Button();
            this.btnList2 = new System.Windows.Forms.Button();
            this.btnList7 = new System.Windows.Forms.Button();
            this.btnList3 = new System.Windows.Forms.Button();
            this.btnList6 = new System.Windows.Forms.Button();
            this.btnList4 = new System.Windows.Forms.Button();
            this.btnList5 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabMeal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(141, 396);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "Prev Page";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(242, 396);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next Page";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labPage
            // 
            this.labPage.ForeColor = System.Drawing.Color.Blue;
            this.labPage.Location = new System.Drawing.Point(12, 396);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(100, 23);
            this.labPage.TabIndex = 3;
            this.labPage.Text = "Page : 1/2";
            this.labPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.name,
            this.Qty,
            this.UnitPrice,
            this.SubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(353, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 254);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Delete
            // 
            this.Delete.Frozen = true;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Delete.Text = "X";
            this.Delete.Width = 60;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 70;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Qty.Width = 48;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 70;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SubTotal.Width = 80;
            // 
            // labTotal
            // 
            this.labTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal.ForeColor = System.Drawing.Color.Red;
            this.labTotal.Location = new System.Drawing.Point(361, 309);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(240, 45);
            this.labTotal.TabIndex = 5;
            this.labTotal.Text = "Total : 0 NTD";
            this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RichTextArea
            // 
            this.RichTextArea.Location = new System.Drawing.Point(21, 298);
            this.RichTextArea.Name = "RichTextArea";
            this.RichTextArea.Size = new System.Drawing.Size(300, 60);
            this.RichTextArea.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewNumericUpDownColumn1
            // 
            this.dataGridViewNumericUpDownColumn1.HeaderText = "SubTotal";
            this.dataGridViewNumericUpDownColumn1.Name = "dataGridViewNumericUpDownColumn1";
            this.dataGridViewNumericUpDownColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNumericUpDownColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewNumericUpDownColumn1.Width = 80;
            // 
            // tabMeal
            // 
            this.tabMeal.Controls.Add(this.tabPage1);
            this.tabMeal.Controls.Add(this.tabPage2);
            this.tabMeal.Location = new System.Drawing.Point(20, 12);
            this.tabMeal.Name = "tabMeal";
            this.tabMeal.SelectedIndex = 0;
            this.tabMeal.Size = new System.Drawing.Size(315, 283);
            this.tabMeal.TabIndex = 7;
            this.tabMeal.SelectedIndexChanged += new System.EventHandler(this.tabMeal_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnList9);
            this.tabPage1.Controls.Add(this.btnList1);
            this.tabPage1.Controls.Add(this.btnList8);
            this.tabPage1.Controls.Add(this.btnList2);
            this.tabPage1.Controls.Add(this.btnList7);
            this.tabPage1.Controls.Add(this.btnList3);
            this.tabPage1.Controls.Add(this.btnList6);
            this.tabPage1.Controls.Add(this.btnList4);
            this.tabPage1.Controls.Add(this.btnList5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(307, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主餐";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnList9
            // 
            this.btnList9.Location = new System.Drawing.Point(202, 166);
            this.btnList9.Name = "btnList9";
            this.btnList9.Size = new System.Drawing.Size(95, 74);
            this.btnList9.TabIndex = 17;
            this.btnList9.Text = "鱈魚";
            this.btnList9.UseVisualStyleBackColor = true;
            this.btnList9.Click += new System.EventHandler(this.btnList9_Click);
            this.btnList9.MouseHover += new System.EventHandler(this.btnList9_MouseHover);
            // 
            // btnList1
            // 
            this.btnList1.Location = new System.Drawing.Point(0, 6);
            this.btnList1.Name = "btnList1";
            this.btnList1.Size = new System.Drawing.Size(95, 74);
            this.btnList1.TabIndex = 9;
            this.btnList1.Text = "炸雞腿";
            this.btnList1.UseVisualStyleBackColor = true;
            this.btnList1.Click += new System.EventHandler(this.btnList1_Click);
            this.btnList1.MouseHover += new System.EventHandler(this.btnList1_MouseHover);
            // 
            // btnList8
            // 
            this.btnList8.Location = new System.Drawing.Point(101, 166);
            this.btnList8.Name = "btnList8";
            this.btnList8.Size = new System.Drawing.Size(95, 74);
            this.btnList8.TabIndex = 16;
            this.btnList8.Text = "龍蝦";
            this.btnList8.UseVisualStyleBackColor = true;
            this.btnList8.Click += new System.EventHandler(this.btnList8_Click);
            this.btnList8.MouseHover += new System.EventHandler(this.btnList8_MouseHover);
            // 
            // btnList2
            // 
            this.btnList2.Location = new System.Drawing.Point(101, 6);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(95, 74);
            this.btnList2.TabIndex = 10;
            this.btnList2.Text = "炸雞排";
            this.btnList2.UseVisualStyleBackColor = true;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            this.btnList2.MouseHover += new System.EventHandler(this.btnList2_MouseHover);
            // 
            // btnList7
            // 
            this.btnList7.Location = new System.Drawing.Point(0, 166);
            this.btnList7.Name = "btnList7";
            this.btnList7.Size = new System.Drawing.Size(95, 74);
            this.btnList7.TabIndex = 15;
            this.btnList7.Text = "曼魚";
            this.btnList7.UseVisualStyleBackColor = true;
            this.btnList7.Click += new System.EventHandler(this.btnList7_Click);
            this.btnList7.MouseHover += new System.EventHandler(this.btnList7_MouseHover);
            // 
            // btnList3
            // 
            this.btnList3.Location = new System.Drawing.Point(202, 6);
            this.btnList3.Name = "btnList3";
            this.btnList3.Size = new System.Drawing.Size(95, 74);
            this.btnList3.TabIndex = 11;
            this.btnList3.Text = "蔥爆牛肉";
            this.btnList3.UseVisualStyleBackColor = true;
            this.btnList3.Click += new System.EventHandler(this.btnList3_Click);
            this.btnList3.MouseHover += new System.EventHandler(this.btnList3_MouseHover);
            // 
            // btnList6
            // 
            this.btnList6.Location = new System.Drawing.Point(202, 86);
            this.btnList6.Name = "btnList6";
            this.btnList6.Size = new System.Drawing.Size(95, 74);
            this.btnList6.TabIndex = 14;
            this.btnList6.Text = "鮭魚";
            this.btnList6.UseVisualStyleBackColor = true;
            this.btnList6.Click += new System.EventHandler(this.btnList6_Click);
            this.btnList6.MouseHover += new System.EventHandler(this.btnList6_MouseHover);
            // 
            // btnList4
            // 
            this.btnList4.Location = new System.Drawing.Point(0, 86);
            this.btnList4.Name = "btnList4";
            this.btnList4.Size = new System.Drawing.Size(95, 74);
            this.btnList4.TabIndex = 12;
            this.btnList4.Text = "豬肉";
            this.btnList4.UseVisualStyleBackColor = true;
            this.btnList4.Click += new System.EventHandler(this.btnList4_Click);
            this.btnList4.MouseHover += new System.EventHandler(this.btnList4_MouseHover);
            // 
            // btnList5
            // 
            this.btnList5.Location = new System.Drawing.Point(101, 86);
            this.btnList5.Name = "btnList5";
            this.btnList5.Size = new System.Drawing.Size(95, 74);
            this.btnList5.TabIndex = 13;
            this.btnList5.Text = "海鮮餐";
            this.btnList5.UseVisualStyleBackColor = true;
            this.btnList5.Click += new System.EventHandler(this.btnList5_Click);
            this.btnList5.MouseHover += new System.EventHandler(this.btnList5_MouseHover);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(307, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "甜點";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 439);
            this.Controls.Add(this.tabMeal);
            this.Controls.Add(this.RichTextArea);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabMeal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label RichTextArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn dataGridViewNumericUpDownColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.TabControl tabMeal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnList9;
        private System.Windows.Forms.Button btnList1;
        private System.Windows.Forms.Button btnList8;
        private System.Windows.Forms.Button btnList2;
        private System.Windows.Forms.Button btnList7;
        private System.Windows.Forms.Button btnList3;
        private System.Windows.Forms.Button btnList6;
        private System.Windows.Forms.Button btnList4;
        private System.Windows.Forms.Button btnList5;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

