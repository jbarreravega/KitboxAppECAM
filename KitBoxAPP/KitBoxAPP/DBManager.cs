using System;
using Mono.Data.Sqlite;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public class DBManager
	{
		private SqliteConnection db;
		private StockManager stock;

		public DBManager ()
		{
			// Name of the database
			string db_name = "KitBox.sqlite";

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

			db = new SqliteConnection (
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
	}
}
