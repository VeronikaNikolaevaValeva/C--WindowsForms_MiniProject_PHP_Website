using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    class DBMediatorProductStatistics : DBMediator
    {
        public DBMediatorProductStatistics(DatabaseType databaseType) : base(databaseType) { }

        public Dictionary<Product, int> GetTenMostSoldProductsQuantity()
        {
            string sqlStatement =   "SELECT p.*, sum(r.quantity) as quantity FROM `mb_receipt_line` AS r " +
                                    "INNER JOIN `mb_product` AS p " +
                                    "ON p.pNum = r.productid " +
                                    "group by p.pNum " +
                                    "ORDER BY sum(r.quantity) desc " +
                                    "limit 10";
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
                        (int)reader["amount_in_store"], (int)reader["amount_in_warehouse"], (int)reader["minimum_amount_in_store"], (string)reader["supplier_phone_number"], (string)reader["supplier_email"]), Convert.ToInt32(reader["quantity"]));
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

        public Dictionary<Product, double> GetTenMostSoldProductsProfit()
        {
            string sqlStatement = "SELECT p.*, sum(r.unitprice) as profit FROM `mb_receipt_line` AS r " +
                                    "INNER JOIN `mb_product` AS p " +
                                    "ON p.pNum = r.productid " +
                                    "group by p.pNum " +
                                    "ORDER BY sum(r.unitprice) desc " +
                                    "limit 10";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            Dictionary<Product, double> p = new Dictionary<Product, double>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    p.Add(new Product((int)reader["pNum"], (string)reader["brand"], (string)reader["type"], (string)reader["model"],
                        (string)reader["description"], (string)reader["barcode"], (decimal)reader["cost_price"], (decimal)reader["sales_price"],
                        (int)reader["amount_in_store"], (int)reader["amount_in_warehouse"], (int)reader["minimum_amount_in_store"], (string)reader["supplier_phone_number"], (string)reader["supplier_email"]), Convert.ToDouble(reader["profit"]));
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
