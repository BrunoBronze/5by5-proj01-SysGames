using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Produto
	{
		[Display(Name = "ID do Produto")]
		//[Range]
		public int ProdutoID { get; set; }
		public string Nome { get; set; }
		[Display(Name = "Descrição")]
		public string Descricao { get; set; }
		public float Valor { get; set; }
		[Display(Name = "Quantidade de Estoque")]
		public int QtdEstoque { get; set; }
        public string Tipo { get; set; }
    }
}