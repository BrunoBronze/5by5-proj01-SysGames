using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class ItemCarrinho
	{
		[Key]
        public int ItemID { get; set; }
		public int ProdutoID { get; set; }
        public virtual Produto Produto { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public float Valor { get; set; }
		public int Qtd { get; set; }
	}
}