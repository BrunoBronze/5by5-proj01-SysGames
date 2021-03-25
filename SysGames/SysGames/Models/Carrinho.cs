﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysGames.Models
{
	public class Carrinho
	{
        [Display(Name = "ID do Carrinho")]
        public int CarrinhoID { get; set; }
        /*
        public int ItemID { get; set; }
        public virtual List<ItemCarrinho> Produtos { get; set; }
        */
        public virtual Produto Produto { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}