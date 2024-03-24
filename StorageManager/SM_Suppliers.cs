using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager
{
    public partial class SM_Suppliers : Form
    {
        public SM_Suppliers()
        {
            InitializeComponent();
            this.Load += SM_Suppliers_Load;
        }

        private void SM_Suppliers_Load(object sender, EventArgs e)
        {
            suppliersTable.DataSource = Database.GetSuppliers();
            suppliersTable.Columns["SupplierID"].HeaderText = "ID";
            suppliersTable.Columns["SupplierID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            suppliersTable.Columns["SupplierName"].HeaderText = "Supplier";
            suppliersTable.Columns["SupplierName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void createSupplierButton_Click(object sender, EventArgs e)
        {
            string supplierName = supplierNameTB.Text;
            Database.CreateSupplier(supplierName);
            Database.RefreshSuppliers(suppliersTable);
        }
    }
}
