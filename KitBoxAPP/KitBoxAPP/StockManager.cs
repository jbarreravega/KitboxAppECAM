using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public class StockManager
	{
		private SQLiteConnection db;

		public StockManager (SQLiteConnection db)
		{
			this.db = db;
		}

		public bool Save (Piece piece)
		{
			// Not implemented yet
			return true;
		}

		private bool Update (Piece piece)
		{
			// Not implemented yet
			return true;
		}

		private bool Add (Piece piece)
		{
			// Not implemented yet
			return true;
		}

		public bool Delete (string piece_code)
		{
			// Not implemented yet
			return true;
		}

		public List<Piece> List ()
		{
			// Not implemented yet
			return null;
		}
	}
}

