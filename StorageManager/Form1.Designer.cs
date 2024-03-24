namespace StorageManager
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dbStatusLabel = new System.Windows.Forms.Label();
            this.ConnectionLabel = new System.Windows.Forms.Label();
            this.PB_dbConnectionStatus = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_dbConnectionStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.suppliersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProductToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // createProductToolStripMenuItem
            // 
            this.createProductToolStripMenuItem.Name = "createProductToolStripMenuItem";
            this.createProductToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.createProductToolStripMenuItem.Text = "Create product";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCategoryToolStripMenuItem});
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // createCategoryToolStripMenuItem
            // 
            this.createCategoryToolStripMenuItem.Name = "createCategoryToolStripMenuItem";
            this.createCategoryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.createCategoryToolStripMenuItem.Text = "Create category";
            this.createCategoryToolStripMenuItem.Click += new System.EventHandler(this.createCategoryToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSupplierToolStripMenuItem});
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // createSupplierToolStripMenuItem
            // 
            this.createSupplierToolStripMenuItem.Name = "createSupplierToolStripMenuItem";
            this.createSupplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createSupplierToolStripMenuItem.Text = "Create supplier";
            this.createSupplierToolStripMenuItem.Click += new System.EventHandler(this.createSupplierToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.dbStatusLabel);
            this.panel1.Controls.Add(this.ConnectionLabel);
            this.panel1.Controls.Add(this.PB_dbConnectionStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 22);
            this.panel1.TabIndex = 1;
            // 
            // dbStatusLabel
            // 
            this.dbStatusLabel.AutoSize = true;
            this.dbStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbStatusLabel.ForeColor = System.Drawing.Color.Lime;
            this.dbStatusLabel.Location = new System.Drawing.Point(197, 3);
            this.dbStatusLabel.Name = "dbStatusLabel";
            this.dbStatusLabel.Size = new System.Drawing.Size(60, 16);
            this.dbStatusLabel.TabIndex = 2;
            this.dbStatusLabel.Text = "{status}";
            this.dbStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.AutoSize = true;
            this.ConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionLabel.ForeColor = System.Drawing.Color.White;
            this.ConnectionLabel.Location = new System.Drawing.Point(20, 3);
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(180, 16);
            this.ConnectionLabel.TabIndex = 1;
            this.ConnectionLabel.Text = "Database Connection Status:";
            this.ConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_dbConnectionStatus
            // 
            this.PB_dbConnectionStatus.Image = global::StorageManager.Properties.Resources.dbConnected;
            this.PB_dbConnectionStatus.Location = new System.Drawing.Point(3, 3);
            this.PB_dbConnectionStatus.Name = "PB_dbConnectionStatus";
            this.PB_dbConnectionStatus.Size = new System.Drawing.Size(16, 16);
            this.PB_dbConnectionStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_dbConnectionStatus.TabIndex = 0;
            this.PB_dbConnectionStatus.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_dbConnectionStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox PB_dbConnectionStatus;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSupplierToolStripMenuItem;
        private System.Windows.Forms.Label dbStatusLabel;
        private System.Windows.Forms.Label ConnectionLabel;
    }
}

