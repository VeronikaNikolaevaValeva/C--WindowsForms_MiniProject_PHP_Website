using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    class DBMediatorProduct : DBMediator
    {
        public DBMediatorProduct(DatabaseType databaseType) : base(databaseType) { }

        //TAKE ALL PRODUCTS
        public List<Product> GetProducts()
        {
            string sqlStatement = "SELECT * FROM mb_product";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            List<Product> p = new List<Product>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    p.Add(new Product((int)reader["pNum"], (string)reader["brand"], (string)reader["type"], (string)reader["model"],
                        (string)reader["description"], (string)reader["barcode"], (decimal)reader["cost_price"], (decimal)reader["sales_price"],
                        (int)reader["amount_in_store"], (int)reader["amount_in_warehouse"], (int)reader["minimum_amount_in_store"], (string)reader["supplier_phone_number"], (string)reader["supplier_email"]));
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

        

        //ADD PRODUCT
        public bool AddProduct(Product newProd)
        {
            string sqlStatement = "INSERT INTO mb_product (brand, type, model, description,barcode, cost_price, " +
                "sales_price, amount_in_store, amount_in_warehouse, minimum_amount_in_store, supplier_phone_number, supplier_email) VALUES (@br, @ty, @mo, @de,@ba, @cp, @sp, @as, @aw, @ma, @spn, @se)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);

            sqlCommand.Parameters.AddWithValue("@br", newProd.Brand);
            sqlCommand.Parameters.AddWithValue("@ty", newProd.Type);
            sqlCommand.Parameters.AddWithValue("@mo", newProd.Model);
            sqlCommand.Parameters.AddWithValue("@de", newProd.Description);
            sqlCommand.Parameters.AddWithValue("@ba", newProd.Barcode);
            sqlCommand.Parameters.AddWithValue("@cp", newProd.CostPrice);
            sqlCommand.Parameters.AddWithValue("@sp", newProd.SalePrice);
            sqlCommand.Parameters.AddWithValue("@as", newProd.AmountInStore);
            sqlCommand.Parameters.AddWithValue("@aw", newProd.AmountInWarehouse);
            sqlCommand.Parameters.AddWithValue("@ma", newProd.MinimumAmountInStore);
            sqlCommand.Parameters.AddWithValue("@spn", newProd.SupplierPhoneNumber);
            sqlCommand.Parameters.AddWithValue("@se", newProd.SupplierEmail);

            try
            {
                int n = 0;

                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //DELETE PRODUCT
        public bool DeleteProduct(int id)
        {
            string sqlStatement = "DELETE FROM `mb_product` WHERE pNum=@i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@i", id);
            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
            {
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            catch (Exception e)
            {
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public bool CheckIfExists(string model, string brand)
        {
            //SELECT pNum FROM mb_product WHERE model = 'EasyDrill 1200 12V' AND brand = 'Bosch';
            string sqlStatement = "SELECT pNum FROM mb_product WHERE model = @M AND brand = @B;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@M", model);
            sqlCommand.Parameters.AddWithValue("@B", brand);

            try
            {
                DbConnection.Open();
                Object test = sqlCommand.ExecuteScalar();

                if (test != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (MySqlException e)
            {
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            catch (Exception e)
            {
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public List<Product> GetProductsFromDepartment(int dept_id)
        {
            string sqlStatement = "SELECT * FROM `mb_product` WHERE subcat_id IN (SELECT subcat.id FROM `mb_dept_subcategory` as subcat " +
                "WHERE cat_id IN (SELECT c.id FROM mb_dept_category as c WHERE dept_id = @id))";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@id", dept_id);
            List<Product> p = new List<Product>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    p.Add(new Product((int)reader["pNum"], (string)reader["brand"], (string)reader["type"], (string)reader["model"],
                        (string)reader["description"], (string)reader["barcode"],
                        (decimal)reader["cost_price"], (decimal)reader["sales_price"], (int)reader["amount_in_store"],
                        (int)reader["amount_in_warehouse"], (int)reader["minimum_amount_in_store"], (string)reader["supplier_phone_number"], (string)reader["supplier_email"]));
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

        //GET all products from department category
        public List<Product> GetProductsFromDepartmentCategory(int dept_id, string category)
        {
            string sqlStatement = "SELECT * FROM `mb_product` WHERE subcat_id IN (SELECT subcat.id FROM `mb_dept_subcategory` as subcat " +
                "WHERE cat_id = (SELECT c.id FROM mb_dept_category as c WHERE dept_id = @id AND name = @cat))";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@id", dept_id);
            sqlCommand.Parameters.AddWithValue("@cat", category);
            List<Product> p = new List<Product>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    p.Add(new Product((int)reader["pNum"], (string)reader["brand"], (string)reader["type"], (string)reader["model"],
                        (string)reader["description"], (string)reader["barcode"],
                        (decimal)reader["cost_price"], (decimal)reader["sales_price"], (int)reader["amount_in_store"],
                        (int)reader["amount_in_warehouse"], (int)reader["minimum_amount_in_store"], (string)reader["supplier_phone_number"], (string)reader["supplier_email"]));
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

        //GET all products from department subcategory
        public List<Product> GetProductsFromSubcategory(int dept_id, string category, string subcategory)
        {
            string sqlStatement = "SELECT * FROM `mb_product` WHERE subcat_id = (SELECT s.id FROM `mb_dept_subcategory` as s " +
                "WHERE s.name = @subcat AND s.cat_id = (SELECT c.id FROM mb_dept_category as c WHERE c.dept_id = @id AND name = @cat))";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@id", dept_id);
            sqlCommand.Parameters.AddWithValue("@cat", category);
            sqlCommand.Parameters.AddWithValue("@subcat", subcategory);
            List<Product> p = new List<Product>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    p.Add(new Product((int)reader["pNum"], (string)reader["brand"], (string)reader["type"], (string)reader["model"],
                        (string)reader["description"], (string)reader["barcode"],
                        (decimal)reader["cost_price"], (decimal)reader["sales_price"], (int)reader["amount_in_store"],
                        (int)reader["amount_in_warehouse"], (int)reader["minimum_amount_in_store"], (string)reader["supplier_phone_number"], (string)reader["supplier_email"]));
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

        public Dictionary<Product, int> GetListOfSoldProducts()
        {
            string sqlStatement = "SELECT p.pNum, p.brand, p.type, p.model, p.description, p.barcode, p.subcat_id, p.cost_price, p.sales_price, p.amount_in_store, p.amount_in_warehouse, p.minimum_amount_in_store, p.supplier_phone_number, p.supplier_email, sum(r.quantity) as quantity " +
                                  "FROM `mb_product` AS p " +
                                  "INNER JOIN `mb_receipt_line` AS r " +
                                  "ON r.productid = p.pNum " +
                                  "GROUP by p.pNum";
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

        public void UpdateMinimumAmountOfStockInStore(int pNum, int stock)
        {
            //
            string sqlStatement = "UPDATE `mb_product` SET minimum_amount_in_store = @stock WHERE pNum = @pNum";
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
    }
}
