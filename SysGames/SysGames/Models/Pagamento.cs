using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Pagamento
	{
        public int PagamentoID { get; set; }
        public virtual Carrinho Carrinho { get; set; }
	}
}