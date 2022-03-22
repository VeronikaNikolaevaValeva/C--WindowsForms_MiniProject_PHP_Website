using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClasses
{
    class DBMediatorSoldProduct : DBMediator
    {
        public DBMediatorSoldProduct(DatabaseType databaseType) : base(databaseType) { }
        public void updateItems(int empID, List<SoldProduct> basket, PaymentType type)
        {
            MySqlTransaction tr = null;

            try
            {
                DbConnection.Open();
                tr = this.DbConnection.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = DbConnection,
                    Transaction = tr,
                };

                //Receipt
                cmd.CommandText = "INSERT INTO `mb_receipt`(`empid`, `paymenttype`, `time`) VALUES (@empID,@type,@time);";
                DateTime time = DateTime.Now;
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.Parameters.AddWithValue("@type", type.ToString());
                cmd.Parameters.AddWithValue("@time", time.ToString("yyyy-MM-dd HH:mm:ss"));
                if (cmd.ExecuteNonQuery() == 0)
                {
                    throw new Exception();
                }

                //ReceiptId
                int receiptId;
                cmd.CommandText = "SELECT MAX(id) FROM mb_receipt";
                object receitIdObject = cmd.ExecuteScalar();
                if (receitIdObject != null)
                {
                    receiptId = Convert.ToInt32(receitIdObject);
                }
                else
                {
                    throw new Exception();
                }

                //Receipt lines
                foreach (SoldProduct soldProduct in basket)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO `mb_receipt_line`(`receiptid`, `productid`, `quantity`, `unitprice`) VALUES (@receiptID,@prodID,@quantity,@unitPrice);";
                    cmd.Parameters.AddWithValue("@receiptID", receiptId);
                    cmd.Parameters.AddWithValue("@prodID", soldProduct.Product.PNumber);
                    cmd.Parameters.AddWithValue("@quantity", soldProduct.Quantity);
                    cmd.Parameters.AddWithValue("@unitPrice", soldProduct.Product.SalePrice);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception();
                    }
                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE `mb_product` SET amount_in_store = @amountInStore WHERE pNum = @pNum";
                    int newQuantity = soldProduct.Product.AmountInStore - soldProduct.Quantity;
                    if (newQuantity<0)
                    {
                        throw new Exception();
                    }
                    cmd.Parameters.AddWithValue("@amountInStore", newQuantity);
                    cmd.Parameters.AddWithValue("@pNum", soldProduct.Product.PNumber);
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception();
                    }
                }

                tr.Commit();
            }
            catch (Exception)
            {
                try
                {
                    tr.Rollback();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.ToString());
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("The database lagged");
                }

                MessageBox.Show("Not enough products in Store");
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public Stack<string> GetSesionInformation(DateTime sesionStartTime, int empId)
        {
            string sqlStatement = " SELECT COUNT(DISTINCT mb_receipt.id) as NumberOrders ,IFNULL(SUM(mb_receipt_line.quantity),0) as NumberProducts, IFNULL(SUM(mb_receipt_line.unitprice*mb_receipt_line.quantity),0) as Total " +
                                    "FROM `mb_receipt_line` INNER JOIN mb_receipt " +
                                    "ON mb_receipt_line.receiptid = mb_receipt.id " +
                                    "WHERE mb_receipt.empid = @empId AND(time BETWEEN @firstdate AND @lastdate)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);

            sqlCommand.Parameters.AddWithValue("@firstdate", sesionStartTime.ToString("yyyy-MM-dd HH:mm:ss"));
            sqlCommand.Parameters.AddWithValue("@lastdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            sqlCommand.Parameters.AddWithValue("@empId", empId);
            Stack<string> sesionInfo = new Stack<string>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    sesionInfo.Push(reader["NumberOrders"].ToString());
                    sesionInfo.Push(reader["NumberProducts"].ToString());
                    sesionInfo.Push(reader["Total"].ToString());
                }
            }
            catch (MySqlException)
            {
                //list conection
            }
            finally
            {
                this.DbConnection.Close();

            }
            return sesionInfo;
        }
    }
}