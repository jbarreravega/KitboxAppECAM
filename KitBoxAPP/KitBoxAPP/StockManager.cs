using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace KitBoxAPP
{
    public class StockManager
    {
        private SQLiteConnection db;
        private List<Piece> pieces;

        /// <summary>
        /// Initializes a new instance of the <see cref="KitBoxAPP.StockManager"/> class.
        /// </summary>
        /// <param name="db">The Db.</param>
        public StockManager (SQLiteConnection db) : this (db, true) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="KitBoxAPP.StockManager"/> class.
        /// </summary>
        /// <param name="db">The Db.</param>
        /// <param name="create_list">If set to <c>true</c> import all the pieces
        /// from the database in a List attribute of this class.</param>
        public StockManager(SQLiteConnection db, bool create_list)
        {
            this.db = db;
            if (create_list)
            {
                pieces = List ();
            } else
            {
                pieces = new List<Piece> ();
            }
        }

        /// <summary>
        /// Reload the list of pieces from the database.
        /// </summary>
        public void Reload ()
        {
            pieces = List ();
        }

        /// <summary>
        /// Save the specified piece in the database.
        /// </summary>
        /// <param name="piece">Piece.</param>
        public bool Save(Piece piece)
        {
            if (IsNew(piece.Code))
            {
                return Add(piece);
            }
            else
            {
                return Update(piece);
            }
        }

        /// <summary>
        /// Determines whether this instance is new in the database.
        /// </summary>
        /// <returns><c>true</c> if this instance is new in the database; 
        /// otherwise, <c>false</c>.</returns>
        /// <param name="code">Code.</param>
        private bool IsNew(string code)
        {
            bool is_new = true;
            SQLiteCommand cmd;
            SQLiteDataReader rd;

            string sql = "SELECT code FROM Stock";

            db.Open();

            cmd = new SQLiteCommand(sql, db);
            rd = cmd.ExecuteReader();

            Console.WriteLine("Begin request : " + sql);

            while (rd.Read() && is_new)
            {
                is_new = !code.Equals(rd["code"]);
            }

            Console.WriteLine("End request : " + sql);

            db.Close();

            return is_new;
        }

        /// <summary>
        /// Add the specified piece in the database
        /// </summary>
        /// <param name="piece">Piece.</param>
        private bool Add(Piece piece)
        {
            bool success = false;
            SQLiteCommand cmd;

            if (piece.Code.Equals(""))
                return false;

            string sql = "INSERT INTO Stock (" +
                "code, name, height, depth, width, " +
                "quantity, min_quantity, reserved_quantity, " +
                "price_client, code_color" +
                ") VALUES (" +
                piece.Code.ToString() + ", " +
                piece.Name.ToString() + ", " +
                piece.Height.ToString() + ", " +
                piece.Depth.ToString() + ", " +
                piece.Width.ToString() + ", " +
                piece.StockQuantity.ToString() + ", " +
                piece.MinQuantity.ToString() + ", " +
                piece.ReservedQuantity.ToString() + ", " +
                piece.PriceClient.ToString() + ", " +
                piece.Color.Code.ToString() + ")";

            db.Open();

            cmd = new SQLiteCommand(sql, db);

            Console.WriteLine("Begin request : " + sql);

            success = cmd.ExecuteNonQuery() > 0;

            Console.WriteLine("End request : " + sql);

            db.Close();

            return success;
        }

        /// <summary>
        /// Update the specified piece in the database.
        /// </summary>
        /// <param name="piece">Piece.</param>
        private bool Update(Piece piece)
        {
            bool success = false;
            SQLiteCommand cmd;

            if (piece.Code.Equals(""))
                return false;

            string sql = "UPDATE Stock " +
                "SET " +
                "name = \"" + piece.Name.ToString() + "\", " +
                "height = \"" + piece.Height.ToString() + "\", " +
                "depth = \"" + piece.Depth.ToString() + "\", " +
                "width = \"" + piece.Width.ToString() + "\", " +
                "quantity = \"" + piece.StockQuantity.ToString() + "\", " +
                "min_quantity = \"" + piece.MinQuantity.ToString() + "\", " +
                "reserved_quantity = \"" + piece.ReservedQuantity.ToString() + "\", " +
                "price_client = \"" + piece.PriceClient.ToString() + "\", " +
                "code_color = \"" + piece.Color.Code.ToString() + "\" " +
                "WHERE code = \"" + piece.Code.ToString() + "\"";

            db.Open();

            Console.WriteLine("Begin request : " + sql);

            cmd = new SQLiteCommand(sql, db);

            success = cmd.ExecuteNonQuery() > 0;

            Console.WriteLine("End request : " + sql);

            db.Close();

            return success;
        }

        /// <summary>
        /// Delete the specified piece_code from the database.
        /// </summary>
        /// <param name="piece_code">Piece_code.</param>
        public bool Delete(string piece_code)
        {
            bool success = false;
            SQLiteCommand cmd;

            if (piece_code.Equals(""))
                return false;

            string sql = "DELETE FROM Stock " +
                "WHERE code = \"" + piece_code + "\"";

            db.Open();

            Console.WriteLine("Begin request : " + sql);

            cmd = new SQLiteCommand(sql, db);

            success = cmd.ExecuteNonQuery() > 0;

            Console.WriteLine("End request : " + sql);

            db.Close();

            return success;
        }

        /// <summary>
        /// Get the specified Piece from the giving code.
        /// </summary>
        /// <param name="code">Code.</param>
        public Piece Get(string code)
        {
            Piece piece;

            SQLiteCommand cmd;
            SQLiteDataReader rd;

            string sql = "SELECT " +
                "Stock.code, " +
                "Stock.name, " +
                "height, " +
                "depth, " +
                "width, " +
                "quantity, " +
                "min_quantity, " +
                "reserved_quantity, " +
                "price_client, " +
                "Stock.code_color, " +
                "Color.name AS color_name " +
                "FROM Stock " +
                "INNER JOIN Color ON code_color = Color.code " +
                "WHERE Stock.code = \"" + code + "\"";

            db.Open();

            Console.WriteLine("Begin request : " + sql);

            cmd = new SQLiteCommand(sql, db);
            rd = cmd.ExecuteReader();

            rd.Read();
            piece = CreateObject(rd);

            Console.WriteLine("End request : " + sql);

            db.Close();

            return piece;
        }

        /// <summary>
        /// List the Piece stored in the database.
        /// </summary>
        public List<Piece> List()
        {
            List<Piece> lt = new List<Piece>();

            SQLiteCommand cmd;
            SQLiteDataReader rd;

            string sql = "SELECT " +
                "Stock.code, " +
                "Stock.name, " +
                "height, " +
                "depth, " +
                "width, " +
                "quantity, " +
                "min_quantity, " +
                "reserved_quantity, " +
                "price_client, " +
                "Stock.code_color, " +
                "Color.name AS color_name " +
                "FROM Stock " +
                "INNER JOIN Color ON code_color = Color.code";

            db.Open();

            Console.WriteLine("Begin request : " + sql);

            cmd = new SQLiteCommand(sql, db);
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                lt.Add(CreateObject(rd));
            }

            Console.WriteLine("End request : " + sql);

            db.Close();

            return lt;
        }

        /// <summary>
        /// Creates an object from the result of a SQL comand.
        /// </summary>
        /// <returns>The object.</returns>
        /// <param name="rd">Rd.</param>
        private Piece CreateObject(SQLiteDataReader rd)
        {
            Color color = new Color(rd.GetInt32(rd.GetOrdinal("code_color")),
                                     rd.GetString(rd.GetOrdinal("color_name")));
            List<PriceSupplier> price_suppliers = GetPriceSuppliers(
                (string)rd["code"]
            );
            Piece p = new Piece((string)rd["code"], (string)rd["name"], color,
                                 (double)rd["width"], (double)rd["depth"],
                                 (double)rd["height"], 1,
                                 rd.GetInt32(rd.GetOrdinal("min_quantity")),
                                 rd.GetInt32(rd.GetOrdinal("quantity")),
                                 rd.GetInt32(rd.GetOrdinal("reserved_quantity")),
                                 (double)rd["price_client"], price_suppliers);

            return p;
        }

        /// <summary>
        /// Gets the list of PriceSupplier for a given piece.
        /// </summary>
        /// <returns>The list of the PriceSupplier.</returns>
        /// <param name="code_piece">Code_piece.</param>
        private List<PriceSupplier> GetPriceSuppliers(string code_piece)
        {
            List<PriceSupplier> lt = new List<PriceSupplier>();

            SQLiteCommand cmd;
            SQLiteDataReader rd;

            string sql = "SELECT code_supplier, price_supplier, " +
                "time_delivery, name, address " +
                "FROM StockSupplier " +
                "INNER JOIN Supplier ON code_supplier = Supplier.code " +
                "WHERE code_stock = \"" + code_piece + "\"";

            Console.WriteLine("Begin request : " + sql);

            // Database already opened in another function
            cmd = new SQLiteCommand(sql, db);
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                lt.Add(
                    new PriceSupplier(
                        new Supplier(rd.GetInt32(rd.GetOrdinal("code_supplier")),
                               (string)rd["name"],
                               (string)rd["address"]
                        ),
                        (double)rd["price_supplier"],
                        rd.GetInt32(rd.GetOrdinal("time_delivery"))
                    )
                );
            }

            Console.WriteLine("End request : " + sql);

            // Database will be closed in another function

            return lt;
        }

        // Properties

        public List<Piece> Pieces
        {
            get {
                return this.pieces;
            }
        }
    }
}
