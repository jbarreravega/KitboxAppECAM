using System;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public abstract class Order
	{
		private int code;
		private List<Piece> pieces;
		private Status status;

		public Order ()
		{
			pieces = new List<Piece> ();
			status = new Status ();
		}

		public abstract double Price ();

		public void AddPiece (Piece piece)
		{
			pieces.Add (piece);
		}

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

