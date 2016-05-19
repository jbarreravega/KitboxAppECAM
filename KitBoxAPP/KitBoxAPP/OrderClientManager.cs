using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace KitBoxAPP
{
    class OrderClientManager
    {
        private SQLiteConnection db;
		private List<OrderClient> orders;

        public OrderClientManager(SQLiteConnection db)
        {
            this.db = db;
        }


        /// <summary>
        /// Adds order to DB and reserves it
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool Reserve(OrderClient order)
        {
            bool success = false;
            SQLiteCommand cmd;

            string sql = "INSERT INTO Order (" +
                "code, name_client, address_client," +
                "mail_client, code_status, date, date_removal" +
                ") VALUES (" +
                order.Code + ", " +
                order.NameClient + ", " +
                order.AddressClient + ", " +
                order.Status.Name + ", " +
                order.OrderTime.ToString()+ ", " +
                order.DeliveryTime.ToString() + ");";

            db.Open();

            cmd = new SQLiteCommand(sql, db);

            Console.WriteLine("Begin request : " + sql);
            success = cmd.ExecuteNonQuery() > 0;
            Console.WriteLine("End request : " + sql);

            db.Close();

            return success;
        }

        /// <summary>
        /// /Returns a List containing all the Orders
        ///with a specific status
        /// </summary>
        /// <param name="status"></param>
        /// <returns>order_list</returns>
        public List<Order> List(Status status)
        {
            SQLiteCommand cmd;
			List<Order> order_list = new List<Order> ();

            string sql = "SELECT " +
                "code, " +
                "name_client ," +
                "address_client, " +
                "mail_client, " +
                "code_status, " +
                "date, " +
                "date_removal " +
                "WHERE code_status = " + status.Code + ";";

            db.Open();
            cmd = new SQLiteCommand(sql, db);

            return order_list;
        }

        /// <summary>
        /// Checks if the order is valid or not
        /// </summary>
        /// <param name="order"></param>
        /// <returns>True if valid, else false</returns>
        public bool Valid(Order order)
        {
            return false;
        }

        /// <summary>
        /// Change the status of the order
        /// </summary>
        /// <param name="code_order"></param>
        /// <param name="status"></param>
        /// <returns>True if changed, else false</returns>
        public bool ChangeStatus(string code_order, Status status)
        {
            return false;
        }
    }
}
