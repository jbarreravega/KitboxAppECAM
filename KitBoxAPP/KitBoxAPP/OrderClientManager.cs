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
        List<Order> order_list;
        
        private SQLiteConnection db;

        public OrderClientManager(SQLiteConnection db)
        {
            this.db = db;
        }


        //Adds order to DB and reserves it
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

        public List<Order> List(Status status)
        {
            SQLiteCommand cmd;


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

        public bool Valid(Order order)
        {
            return false;
        }

        public bool ChangeStatus(string code_order, Status status)
        {
            return false;
        }
    }
}
