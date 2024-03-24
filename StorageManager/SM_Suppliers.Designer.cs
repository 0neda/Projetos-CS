namespace StorageManager
{
    partial class SM_Suppliers
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
            this.createSupplierButton = new System.Windows.Forms.Button();
            this.supplierNameTB = new System.Windows.Forms.TextBox();
            this.supplierNameLabel = new System.Windows.Forms.Label();
            this.suppliersTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // createSupplierButton
            // 
            this.createSupplierButton.Location = new System.Drawing.Point(13, 57);
            this.createSupplierButton.Name = "createSupplierButton";
            this.createSupplierButton.Size = new System.Drawing.Size(413, 23);
            this.createSupplierButton.TabIndex = 0;
            this.createSupplierButton.Text = "Create Supplier";
            this.createSupplierButton.UseVisualStyleBackColor = true;
            this.createSupplierButton.Click += new System.EventHandler(this.createSupplierButton_Click);
            // 
            // supplierNameTB
            // 
            this.supplierNameTB.Location = new System.Drawing.Point(13, 31);
            this.supplierNameTB.Name = "supplierNameTB";
            this.supplierNameTB.Size = new System.Drawing.Size(413, 20);
            this.supplierNameTB.TabIndex = 1;
            // 
            // supplierNameLabel
            // 
            this.supplierNameLabel.AutoSize = true;
            this.supplierNameLabel.Location = new System.Drawing.Point(13, 13);
            this.supplierNameLabel.Name = "supplierNameLabel";
            this.supplierNameLabel.Size = new System.Drawing.Size(76, 13);
            this.supplierNameLabel.TabIndex = 2;
            this.supplierNameLabel.Text = "Supplier Name";
            // 
            // suppliersTable
            // 
            this.suppliersTable.AllowUserToAddRows = false;
            this.suppliersTable.AllowUserToDeleteRows = false;
            this.suppliersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersTable.Location = new System.Drawing.Point(13, 122);
            this.suppliersTable.Name = "suppliersTable";
            this.suppliersTable.ReadOnly = true;
            this.suppliersTable.Size = new System.Drawing.Size(413, 150);
            this.suppliersTable.TabIndex = 3;
            // 
            // SM_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 284);
            this.Controls.Add(this.suppliersTable);
            this.Controls.Add(this.supplierNameLabel);
            this.Controls.Add(this.supplierNameTB);
            this.Controls.Add(this.createSupplierButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SM_Suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            ((System.ComponentModel.ISupportInitialize)(this.suppliersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createSupplierButton;
        private System.Windows.Forms.TextBox supplierNameTB;
        private System.Windows.Forms.Label supplierNameLabel;
        private System.Windows.Forms.DataGridView suppliersTable;
    }
}