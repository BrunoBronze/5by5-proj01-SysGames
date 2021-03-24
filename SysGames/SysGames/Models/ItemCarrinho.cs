using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class ItemCarrinho
	{
		public Produto Produto { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public float Valor { get; set; }
		public int Qtd { get; set; }
	}
}