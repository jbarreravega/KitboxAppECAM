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
		/// Add order to DB and reserve it.
		/// </summary>
		/// <param name="order">The Order to reserve.</param>
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
        /// with a specific status
        /// </summary>
		/// <param name="status">A Status.</param>
        /// <returns>A List of orders</returns>
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
		/// Mark an order as valid and remove its pieces from the database.
		/// </summary>
		/// <param name="order">The Order to validate.</param>
        public bool Valid(Order order)
        {
			// Not implemented yet
            return false;
        }

		/// <summary>
		/// Changes the status of a given order with the given status.
		/// </summary>
		/// <param name="code_order">The id of the order.</param>
		/// <param name="status">The new Status.</param>
        /// <returns>True if changed, else false</returns>
        public bool ChangeStatus(string code_order, Status status)
        {
			// Not implemented yet
            return false;
        }
    }
}
