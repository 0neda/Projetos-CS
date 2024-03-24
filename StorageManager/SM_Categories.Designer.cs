namespace StorageManager
{
    partial class SM_Categories
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
            this.createCategoryButton = new System.Windows.Forms.Button();
            this.categoryNameTB = new System.Windows.Forms.TextBox();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.categoriesTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // createCategoryButton
            // 
            this.createCategoryButton.Location = new System.Drawing.Point(13, 57);
            this.createCategoryButton.Name = "createCategoryButton";
            this.createCategoryButton.Size = new System.Drawing.Size(413, 23);
            this.createCategoryButton.TabIndex = 0;
            this.createCategoryButton.Text = "Create Category";
            this.createCategoryButton.UseVisualStyleBackColor = true;
            this.createCategoryButton.Click += new System.EventHandler(this.createCategoryButton_Click);
            // 
            // categoryNameTB
            // 
            this.categoryNameTB.Location = new System.Drawing.Point(13, 31);
            this.categoryNameTB.Name = "categoryNameTB";
            this.categoryNameTB.Size = new System.Drawing.Size(413, 20);
            this.categoryNameTB.TabIndex = 1;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(13, 13);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(80, 13);
            this.categoryNameLabel.TabIndex = 2;
            this.categoryNameLabel.Text = "Category Name";
            // 
            // categoriesTable
            // 
            this.categoriesTable.AllowUserToAddRows = false;
            this.categoriesTable.AllowUserToDeleteRows = false;
            this.categoriesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesTable.Location = new System.Drawing.Point(13, 122);
            this.categoriesTable.Name = "categoriesTable";
            this.categoriesTable.ReadOnly = true;
            this.categoriesTable.Size = new System.Drawing.Size(413, 150);
            this.categoriesTable.TabIndex = 3;
            // 
            // SM_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 284);
            this.Controls.Add(this.categoriesTable);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.categoryNameTB);
            this.Controls.Add(this.createCategoryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SM_Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.SM_Categories_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createCategoryButton;
        private System.Windows.Forms.TextBox categoryNameTB;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.DataGridView categoriesTable;
    }
}