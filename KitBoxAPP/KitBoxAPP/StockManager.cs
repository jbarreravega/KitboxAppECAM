using System;
using Mono.Data.Sqlite;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public class StockManager
	{
		private SqliteConnection db;

		public StockManager (SqliteConnection db)
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
			List<Piece> lt = new List<Piece> ();

			SqliteCommand cmd;
			SqliteDataReader rd;

			string sql = "SELECT Stock.code, Stock.name, height, depth, width, " +
				"quantity, min_quantity, reserved_quantity, " +
				"price_client, Stock.code_color, Color.name AS color_name " +
				"FROM Stock " +
				"INNER JOIN Color ON code_color = Color.code";

			db.Open ();

			cmd = new SqliteCommand (sql, db);
			rd = cmd.ExecuteReader ();

			Console.WriteLine ("Begin request : " + sql);

			while (rd.Read ())
			{
				lt.Add (CreateObject (rd));
			}

			Console.WriteLine ("End request : " + sql);

			foreach (Piece p in lt)
			{
				Console.WriteLine (p.ToString ());
			}

			db.Close ();
			
			return lt;
		}

		private Piece CreateObject(SqliteDataReader rd)
		{
			Color color = new Color (rd.GetInt32 (rd.GetOrdinal ("code_color")),
			                         rd.GetString (rd.GetOrdinal ("color_name")));
			List<PriceSupplier> price_suppliers = GetPriceSupplier (
				(string) rd ["code"]
			);
			Piece p = new Piece ((string) rd["code"], (string) rd["name"], color, 
			                     (double) rd["width"], (double) rd["depth"], 
			                     (double) rd["height"], 1,
			                     rd.GetInt32 (rd.GetOrdinal ("min_quantity")), 
			                     rd.GetInt32 (rd.GetOrdinal ("quantity")),
					             rd.GetInt32 (rd.GetOrdinal ("reserved_quantity")),
			                     (double) rd["price_client"], price_suppliers);

			return p;
		}

		private List<PriceSupplier> GetPriceSupplier (string code_piece)
		{
			List<PriceSupplier> lt = new List<PriceSupplier> ();

			SqliteCommand cmd;
			SqliteDataReader rd;

			string sql = "SELECT code_supplier, price_supplier, " +
				"time_delivery, name, address " +
				"FROM StockSupplier " +
				"INNER JOIN Supplier ON code_supplier = Supplier.code";

			// Database already opened in another function
			cmd = new SqliteCommand (sql, db);
			rd = cmd.ExecuteReader ();

			while (rd.Read ())
			{
				lt.Add (
					new PriceSupplier (
						new Supplier (rd.GetInt32 (rd.GetOrdinal ("code_supplier")), 
				               (string) rd ["name"], 
				               (string) rd ["address"]
						),
						(double) rd ["price_supplier"],
						rd.GetInt32 (rd.GetOrdinal ("time_delivery"))
					)
				);
			}

			// Database will be closed in another function

			return lt;
		}
	}
}

