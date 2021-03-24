using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Jogo : Produto
	{
		public string Genero { get; set; }
		public string Classificacao { get; set; }
	}
}