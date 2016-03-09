using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public class DBManager
	{
		private SQLiteConnection db;
		private StockManager stock;

		public DBManager() : this("KitBox.sqlite") {}

		public DBManager(bool debug) : 
			this(debug ? "KitBox.sqlite" : "KitBoxTest.sqilte")
		{
		}

		public DBManager (string db_name)
		{
			// Get the name of the directory where the database is.
			char[] slash = {'/', '\\'};
			string dir = Environment.CurrentDirectory;
			for (int i = 0; i < 4; i++)
			{
				dir = dir.Remove (dir.LastIndexOfAny (slash));
			}
			dir += dir[dir.LastIndexOfAny (slash)];

			Console.WriteLine (
				"Creating connection with database located at :" +
				dir + db_name
			);

			db = new SQLiteConnection (
				"Data Source=" + dir + db_name +";Version=3;"
			);

			// Add other manager
			stock = new StockManager (db);
		}

		// Properties

		public StockManager Stock
		{
			get
			{
				return stock;
			}
		}

		public SQLiteConnection DB
		{
			get
			{
				return db;
			}
		}

        public virtual List<double> Listarea()
        {
            double area = 0;
            string sql = "";
            List<double> listarea = new List<double>();
            SQLiteCommand command = new SQLiteCommand(sql);
            sql = "SELECT depth AND width FROM Stock WHERE name='Panneau HB'";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                area = Convert.ToDouble("depth") * Convert.ToDouble("width");
                listarea.Add(area);
            } 
            return listarea ;
        }
	}
}

