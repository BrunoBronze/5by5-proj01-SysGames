using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SysGames.Dal
{
    public class SysGamesInitializer : DropCreateDatabaseIfModelChanges<SysGamesContext>
    {
        protected override void Seed(SysGamesContext context)
        {
            var cliente = new List<Cliente>()
            {
                Id = 1,
                CPF = 11111111111,
                Nome = "Andressa",
                Email = "andressa@gmail.com",
                Senha = "1234",
                Logradouro = "Rua das flores",
                Numero = "1234",
                Bairro = "Jardim das flores",
                Complemento = "Casa",
                CEP = "11222333",
                Localidade = "Araraquara",
                UF = "SP"
            };

            var videogames = new List<Videogame>()
            {
                new Videogame()
                {
                    Id = "1",
                    Nome = "Playstation 5",
                    Descricao = "HD 1TB, SSD 120GB",
                    Valor = 5999.90,
                    QtdEstoque = 5,
                    Marca = "Sony",
                    Modelo = "Edição com disco"
                }
            };

            var jogos = new List<Jogo>()
            {
                new Jogo()
                {
                    Id = "1",
                    Nome = "The last of us 2",
                    Descricao = "Jogo foda",
                    Valor = 399.90,
                    QtdEstoque = 7,
                    Genero = "Suspense"
                }
            };
            
            var acessorios = new List<Acessorio>()
            {
                new Acessorio()
                {
                    Id = "1",
                    Nome = "Controle PS5",
                    Descricao = "Jogo foda",
                    Valor = 399.90,
                    QtdEstoque = 7,
                    Tipo = "PS5"
                }
            };
        }
    }
}