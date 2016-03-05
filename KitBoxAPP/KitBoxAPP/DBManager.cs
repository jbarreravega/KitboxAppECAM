using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public class DBManager
	{
		private SQLiteConnection db;
		private StockManager stock;

		public DBManager ()
		{
			db = new SQLiteConnection ("Data Source=KitBox.sqlite;Version=3;");
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

