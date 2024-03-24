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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SM_Categories categoriesWindow = new SM_Categories();
            categoriesWindow.ShowDialog();
        }

        private void createSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SM_Suppliers suppliersWindow = new SM_Suppliers();
            suppliersWindow.ShowDialog();
        }
    }
}
