using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Venda
	{
		public int Id { get; set; }
		public Pagamento Pagamento { get; set; }
		public DateTime DataHora { get; set; }
		public DateTime Previsao { get; set; }
	}
}