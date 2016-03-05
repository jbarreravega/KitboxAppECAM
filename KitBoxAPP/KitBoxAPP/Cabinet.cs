using System;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public class Cabinet
	{
		private double width;
		private double height;
		private double depth;
		private Piece[] batten;
		private Piece[] back_sleeper;
		private Piece[] front_sleeper;
		private Piece[] side_sleeper;
		private Piece[] updown_panel;
		private Piece[] side_panel;
		private Piece back_panel;
		private Piece[] doors;
		private Piece[] handle;

		public Cabinet ()
		{
			width = 0.0;
			height = 0.0;
			depth = 0.0;
			batten = new Piece[4];
			back_sleeper = new Piece[2];
			front_sleeper = new Piece[2];
			side_sleeper = new Piece[2];
			updown_panel = new Piece[2];
			side_panel = new Piece[2];
			back_panel = null;
			doors = new Piece[2];
			handle = new Piece[2];
		}

		// Properties

		public double Price
		{
			get
			{
				double price = 0.0;

				foreach (Piece p in this.Pieces)
				{
					price += p.PriceClient;
				}

				return price;
			}
		}


		public List<Piece> Pieces
		{
			get
			{
				List<Piece> res = new List<Piece> ();
				foreach (Piece p in batten)
				{
					res.Add (p);
				}
				foreach (Piece p in back_sleeper)
				{
					res.Add (p);
				}
				foreach (Piece p in front_sleeper)
				{
					res.Add (p);
				}
				foreach (Piece p in side_sleeper)
				{
					res.Add (p);
				}
				foreach (Piece p in updown_panel)
				{
					res.Add (p);
				}
				foreach (Piece p in side_panel)
				{
					res.Add (p);
				}
				foreach (Piece p in doors)
				{
					res.Add (p);
				}
				foreach (Piece p in handle)
				{
					res.Add (p);
				}
				res.Add (back_panel);
				return res;
			}
		}

		public double Width
		{
			get;
			set;
		}

		public double Height
		{
			get;
			set;
		}

		public double Depth
		{
			get;
			set;
		}

		public Piece[] Batten
		{
			get;
			set;
		}

		public Piece[] BackSleeper
		{
			get;
			set;
		}

		public Piece[] FrontSleeper
		{
			get;
			set;
		}

		public Piece[] SideSleeper
		{
			get;
			set;
		}

		public Piece[] UpdownPanel
		{
			get;
			set;
		}

		public Piece[] SidePanel
		{
			get;
			set;
		}

		public Piece BackPanel
		{
			get;
			set;
		}

		public Piece[] Doors
		{
			get;
			set;
		}

		public Piece[] Handle
		{
			get;
			set;
		}
	}
}

