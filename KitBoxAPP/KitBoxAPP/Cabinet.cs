using System;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public class Cabinet
	{
		private double width;
		private double height;
		private double depth;
		private Piece batten; // 4
		private Piece back_sleeper; // 2
		private Piece front_sleeper; // 2
		private Piece side_sleeper; // 2
		private Piece updown_panel; // 2
		private Piece side_panel; // 2
		private Piece back_panel; // 1
		private Piece doors; // 0-2
		private Piece handle; // 0-2

		public Cabinet ()
		{
			width = 0.0;
			depth = 0.0;
			batten = null;
			back_sleeper = null;
			front_sleeper = null;
			side_sleeper = null;
			updown_panel = null;
			side_panel = null;
			back_panel = null;
			doors = null;
			handle = null;
		}

		// Properties

		public double Price
		{
			get
			{
				double price = 0.0;

				foreach (Piece p in this.Pieces)
				{
					price += p.TotalPriceClient ();
				}

				return price;
			}
		}


		public List<Piece> Pieces
		{
			get
			{
				List<Piece> res = new List<Piece> ();
				res.Add (batten);
				res.Add (back_sleeper);
				res.Add (front_sleeper);
				res.Add (side_sleeper);
				res.Add (updown_panel);
				res.Add (side_panel);
				res.Add (doors);
				res.Add (handle);
				res.Add (back_panel);
				return res;
			}
		}
		
		public double Height
		{
			get
			{
				return batten.Height + 2 * 2;
			}
		}

		public double Width
		{
			get;
			set;
		}

		public double Depth
		{
			get;
			set;
		}

		public Piece Batten
		{
			get;
			set;
		}

		public Piece BackSleeper
		{
			get;
			set;
		}

		public Piece FrontSleeper
		{
			get;
			set;
		}

		public Piece SideSleeper
		{
			get;
			set;
		}

		public Piece UpdownPanel
		{
			get;
			set;
		}

		public Piece SidePanel
		{
			get;
			set;
		}

		public Piece BackPanel
		{
			get;
			set;
		}

		public Piece Doors
		{
			get;
			set;
		}

		public Piece Handle
		{
			get;
			set;
		}
	}
}

