    using System;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public abstract class Order
	{
		private int code;
		private List<Piece> pieces;
		private Status status;

        //Constructor
		public Order ()
		{
			pieces = new List<Piece> ();
			status = new Status ();
		}

        //Constructor using a list of pieces
		public Order(List<Piece> pieces) : this ()
		{
			this.pieces = pieces;
		}


		public abstract double Price ();

        //Add a piece to the order
		public void AddPiece (Piece piece)
		{
			this.pieces.Add (piece);
		}

        //Remove a piece from the order
		public Piece RemovePiece (string code_piece)
		{
			// To be implemented
			return null;
		}

		// Properties

		public int Code
		{
			get { return code; }
			set { code = value; }
		}

		public List<Piece> Pieces 
		{
			get { return pieces; }
			set { pieces = value; }
		}

		public Status Status
		{
			get { return status; }
			set { status = value; }
		}
	}
}

