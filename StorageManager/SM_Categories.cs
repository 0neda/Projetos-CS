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
    public partial class SM_Categories : Form
    {
        public SM_Categories()
        {
            InitializeComponent();
            this.Load += SM_Categories_Load;
        }

        private void SM_Categories_Load(object sender, EventArgs e)
        {
            categoriesTable.DataSource = Database.GetCategories();
            categoriesTable.Columns["CategoryID"].HeaderText = "ID";
            categoriesTable.Columns["CategoryID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            categoriesTable.Columns["CategoryName"].HeaderText = "Name";
            categoriesTable.Columns["CategoryName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void createCategoryButton_Click(object sender, EventArgs e)
        {
            string categoryName = categoryNameTB.Text;
            Database.CreateCategory(categoryName);
            Database.RefreshCategories(categoriesTable);
        }

        private void SM_Categories_Load_1(object sender, EventArgs e)
        {

        }
    }
}