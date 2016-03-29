using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBoxAPP
{
    public class Furniture
    {
		private Piece corners; // 4
		private List<Block> blocks;
		private bool corner_price_supplement;

		public Furniture ()
		{
			corners = null;
			blocks = new List<Block> ();
			corner_price_supplement = false;
		}

		public void FindACorner(string color_name)
		{
			// Not implemented yet
		}

		public void AddBlock (Block block)
		{
			blocks.Add (block);
		}

		public Block DeleteBlock (Block block)
		{
			// Not implemented yet
			// Need to have a comparaison method in the block.
			return null;
		}

		// Properties

		public double Price
		{
			get
			{
				double price = 0.0;

				foreach (Block b in blocks)
				{
					price += b.Price;
				}

				price += corners.TotalPriceClient ();

				return price;
			}
		}

		public double Hieght
		{
			get
			{
				double height = 0.0;
				foreach (Block b in blocks)
				{
					height += b.Height;
				}
				return height - 2;
			}
		}
    }
}
