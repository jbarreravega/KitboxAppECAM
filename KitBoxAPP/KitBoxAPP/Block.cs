using System;
using System.Collections.Generic;

namespace KitBoxAPP
{
	public interface Block
	{
		double Price { get; }
		List<Piece> Pieces { get; }
		double Height { get; set; }
		double Width { get; set; }
		double Depth { get; set; }
	}
}

