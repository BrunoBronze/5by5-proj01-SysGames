using SysGames.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;

namespace SysGames.Dal
{
    public class SysGamesInitializer : DropCreateDatabaseIfModelChanges<SysGamesContext>
    {
        protected override void Seed(SysGamesContext context)
        {
            var clientes = new List<Cliente>()
            {
                new Cliente()
                {
                    ClienteID = 1,
                    CPF = "11111111111",
                    Nome = "Andressa",
                    Email = "andressa@gmail.com",
                    Senha = "1234",
                    Logradouro = "Rua das flores",
                    Numero = "1234",
                    Bairro = "Jardim das flores",
                    Complemento = "Casa",
                    CEP = "11222333",
                    Localidade = "Araraquara",
                    UF = "SP",
                    DataNascimento = DateTime.Now,
                    Telefone = "16123456789"
                }
            };

            var videogames = new List<Videogame>()
            {
                new Videogame()
                {
                    ProdutoID = 1,
                    Nome = "Playstation 5",
                    Descricao = "HD 1TB, SSD 120GB",
                    Valor = 5999.90f,
                    QtdEstoque = 5,
                    Marca = "Sony",
                    Modelo = "Edição com disco"
                }
            };

            var jogos = new List<Jogo>()
            {
                new Jogo()
                {
                    ProdutoID = 2,
                    Nome = "The last of us 2",
                    Descricao = "Jogo foda",
                    Valor = 399.90f,
                    QtdEstoque = 7,
                    Genero = "Suspense"
                }
            };
            
            var acessorios = new List<Acessorio>()
            {
                new Acessorio()
                {
                    ProdutoID = 3,
                    Nome = "Controle PS5",
                    Descricao = "Funciona bem",
                    Valor = 599.90f,
                    QtdEstoque = 7,
                    Tipo = "PS5"
                }
            };

            var vendas = new List<Venda>()
            {
                new Venda()
                {
                    VendaID = 1,
                    DataHora = DateTime.Now,
                    Previsao = DateTime.ParseExact("2021/03/30", "yyyy/MM/dd", CultureInfo.InvariantCulture),
                    Pagamento = new Pagamento ()
                    {
                        Carrinho = new Carrinho()
                        {
                            CarrinhoID = 1,
                            Produto = videogames[0],
                            Cliente = clientes[0],
                        },
                    },
                }
            };
            clientes.ForEach(c => context.Clientes.Add(c));
            videogames.ForEach(v => context.Videogames.Add(v));
            jogos.ForEach(j => context.Jogos.Add(j));
            acessorios.ForEach(a => context.Acessorios.Add(a));
            vendas.ForEach(v => context.Vendas.Add(v));
            context.SaveChanges();
        }
    }
}