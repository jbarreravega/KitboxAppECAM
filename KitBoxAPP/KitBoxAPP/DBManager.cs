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

		/// <summary>
		/// Initializes a new instance of the <see cref="KitBoxAPP.DBManager"/> class.
		/// </summary>
		/// <param name="debug">If set to <c>true</c> use the debug database 
		/// instead of the production one.</param>
		public DBManager(bool debug) : 
			this(debug ? "KitBox.sqlite" : "KitBoxTest.sqilte")
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="KitBoxAPP.DBManager"/> class.
		/// </summary>
		/// <param name="db_name">The name of the database file.</param>
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
	}
}

