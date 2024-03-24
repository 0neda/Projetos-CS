using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StorageManager
{
    internal class Database
    {
        private static SQLiteConnection dbConnection;

        private static SQLiteConnection ConnectToDatabase()
        {
            dbConnection = new SQLiteConnection(@"Data Source=..\..\storageDB.sqlite");
            dbConnection.Open();
            return dbConnection;
        }

        public static DataTable GetCategories()
        {
            SQLiteDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();
            try
            {
                using (var dbCommand = ConnectToDatabase().CreateCommand())
                {
                    dbCommand.CommandText = "SELECT * FROM Categories";
                    dataAdapter = new SQLiteDataAdapter(dbCommand.CommandText, ConnectToDatabase());
                    dataAdapter.Fill(dataTable);
                    dbConnection.Close();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                dbConnection.Close();
                throw ex;
            }
        }

        public static void CreateCategory(string categoryName)
        {
            if (categoryName != null && categoryName != "")
            {
                try
                {
                    using (var dbCommand = ConnectToDatabase().CreateCommand())
                    {
                        dbCommand.CommandText = "INSERT INTO Categories (CategoryName) VALUES (@CategoryName)";
                        dbCommand.Parameters.AddWithValue("@CategoryName", categoryName);
                        dbCommand.ExecuteNonQuery();
                        dbConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    dbConnection.Close();
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Invalid category name");
            }
        }

        public static void RefreshCategories(DataGridView categoriesTable)
        {
            categoriesTable.DataSource = null;
            categoriesTable.DataSource = Database.GetCategories();
            categoriesTable.Columns["CategoryID"].HeaderText = "ID";
            categoriesTable.Columns["CategoryID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            categoriesTable.Columns["CategoryName"].HeaderText = "Name";
            categoriesTable.Columns["CategoryName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public static DataTable GetSuppliers()
        {
            SQLiteDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();
            try
            {
                using (var dbCommand = ConnectToDatabase().CreateCommand())
                {
                    dbCommand.CommandText = "SELECT * FROM Suppliers";
                    dataAdapter = new SQLiteDataAdapter(dbCommand.CommandText, ConnectToDatabase());
                    dataAdapter.Fill(dataTable);
                    dbConnection.Close();
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                dbConnection.Close();
                throw ex;
            }
        }

        public static void CreateSupplier(string supplierName)
        {
            if (supplierName != null && supplierName != "")
            {
                try
                {
                    using (var dbCommand = ConnectToDatabase().CreateCommand())
                    {
                        dbCommand.CommandText = "INSERT INTO Suppliers (SupplierName) VALUES (@SupplierName)";
                        dbCommand.Parameters.AddWithValue("@SupplierName", supplierName);
                        dbCommand.ExecuteNonQuery();
                        dbConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    dbConnection.Close();
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Invalid supplier name");
            }
        }

        public static void RefreshSuppliers(DataGridView suppliersTable)
        {
            suppliersTable.DataSource = null;
            suppliersTable.DataSource = Database.GetSuppliers();
            suppliersTable.Columns["SupplierID"].HeaderText = "ID";
            suppliersTable.Columns["SupplierID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            suppliersTable.Columns["SupplierName"].HeaderText = "Supplier";
            suppliersTable.Columns["SupplierName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
