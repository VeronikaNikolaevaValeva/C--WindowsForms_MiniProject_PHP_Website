using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    class DBMediatorRestockRequest : DBMediator
    {
        public DBMediatorRestockRequest(DatabaseType databaseType) : base(databaseType) { }


        public void CreateRestockRequest(int pNum, int pQuantity)
        {
            string sqlStatement = "INSERT INTO `mb_restock_request` VALUES(@pNum, @pQuantity)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);

            sqlCommand.Parameters.AddWithValue("@pNum", pNum);
            sqlCommand.Parameters.AddWithValue("@pQuantity", pQuantity);

            try
            {
                int n = 0;

                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public Dictionary<Product, int> GetListOfRequestedProducts()
        {
            string sqlStatement = "SELECT *, r.pQuantity as quantity FROM `mb_product` as p " +
                                  "INNER JOIN `mb_restock_request` as r " +
                                  "ON r.pNum = p.pNum";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            Dictionary<Product, int> p = new Dictionary<Product, int>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    p.Add(new Product((int)reader["pNum"], (string)reader["brand"], (string)reader["type"], (string)reader["model"],
                        (string)reader["description"], (string)reader["barcode"], (decimal)reader["cost_price"], (decimal)reader["sales_price"],
                        (int)reader["amount_in_store"], (int)reader["amount_in_warehouse"], (int)reader["minimum_amount_in_store"], (string)reader["supplier_phone_number"], (string)reader["supplier_email"]), (int)reader["quantity"]);
                }
                return p;
            }
            catch (MySqlException e)
            {
                return p;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public void DeleteRestockRequest(int pNum)
        {
            string sqlStatement = "DELETE FROM `mb_restock_request` WHERE pNum=@i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@i", pNum);
            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public void SendStockToStore(int pNum, int stock, int warehouseStock)
        {
            string sqlStatement = "UPDATE `mb_product` SET amount_in_store=@stock, amount_in_warehouse = @warehouseStock WHERE pNum = @pNum";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);

            sqlCommand.Parameters.AddWithValue("@pNum", pNum);
            sqlCommand.Parameters.AddWithValue("@stock", stock);
            sqlCommand.Parameters.AddWithValue("@warehouseStock", warehouseStock);

            try
            {
                int n = 0;

                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public void RecieveStockInWarehouse(int pNum, int warehouseStock)
        {
            string sqlStatement = "UPDATE `mb_product` SET amount_in_warehouse = @warehouseStock WHERE pNum = @pNum";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);

            sqlCommand.Parameters.AddWithValue("@pNum", pNum);
            sqlCommand.Parameters.AddWithValue("@warehouseStock", warehouseStock);

            try
            {
                int n = 0;

                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
            }
            finally
            {
                DbConnection.Close();
            }
        }


        public void UpdateRequestedQuantity(int pNum, int stock)
        {
            string sqlStatement = "UPDATE `mb_restock_request` SET pQuantity= @stock WHERE pNum = @pNum";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);

            sqlCommand.Parameters.AddWithValue("@pNum", pNum);
            sqlCommand.Parameters.AddWithValue("@stock", stock);

            try
            {
                int n = 0;

                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public void SendSupplierRequest(int pNum, int pQuantity)
        {
            string sqlStatement = "INSERT INTO `mb_supplier_request` VALUES(@pNum, @stock)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);

            sqlCommand.Parameters.AddWithValue("@pNum", pNum);
            sqlCommand.Parameters.AddWithValue("@stock", pQuantity);

            try
            {
                int n = 0;

                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public void DeleteSupplierRequest(int pNum)
        {
            string sqlStatement = "DELETE FROM `mb_supplier_request` WHERE pNum=@i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@i", pNum);
            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                DbConnection.Close();
            }
        }
        public Dictionary<Product, int> GetAllSupplierRequests()
        {
            string sqlStatement = "SELECT *, r.pQuantity as quantity FROM `mb_product` as p " +
                                  "INNER JOIN `mb_supplier_request` as r " +
                                  "ON r.pNum = p.pNum";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            Dictionary<Product, int> p = new Dictionary<Product, int>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    p.Add(new Product((int)reader["pNum"], (string)reader["brand"], (string)reader["type"], (string)reader["model"],
                        (string)reader["description"], (string)reader["barcode"], (decimal)reader["cost_price"], (decimal)reader["sales_price"],
                        (int)reader["amount_in_store"], (int)reader["amount_in_warehouse"], (int)reader["minimum_amount_in_store"], (string)reader["supplier_phone_number"], (string)reader["supplier_email"]), (int)reader["quantity"]);
                }
                return p;
            }
            catch (MySqlException e)
            {
                return p;
            }
            finally
            {
                DbConnection.Close();
            }
        }


    }
}
