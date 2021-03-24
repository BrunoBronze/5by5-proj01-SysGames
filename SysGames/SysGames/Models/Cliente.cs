using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Cliente
	{
		public int ClienteID { get; set; }
		public string CPF { get; set; }
		public string Nome { get; set; }
		public DateTime DataNascimento { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }
		public string Senha { get; set; }
		public string Logradouro { get; set; }
		public string Bairro { get; set; }
		public string Localidade { get; set; }
		public string UF { get; set; }
		public string CEP { get; set; }
		public string Complemento { get; set; }
		public string Numero { get; set; }

	}
}