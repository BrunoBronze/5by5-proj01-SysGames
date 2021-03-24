using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SysGames.Dal
{
    public class SysGamesContext : DbContext
    {
        public SysGamesContext() : base("SysGamesContext")
        {
        }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Videogame> Videogames { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Acessorio> Acessorios { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<ItemCarrinho> ItemsCarrinho { get; set; }
    }
}