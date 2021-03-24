using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Carrinho
	{
		public List<ItemCarrinho> Produtos { get; set; }
		public Cliente Cliente { get; set; }
	}
}