using SistemaDeRestaurantes.Models;
using System.Collections.Generic;

namespace SistemaDeRestaurantes.Ct
{
    public class Inicializador : System.Data.Entity.DropCreateDatabaseIfModelChanges<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var restaurantes = new List<Restaurante>
                {
                    new Restaurante {Id = 1, Nome = "Restaurante Bona Massa"},
                    new Restaurante {Id = 2, Nome = "Restaurante Comida Mineira"},
                    new Restaurante {Id = 3, Nome = "Restaurante Oriental"}
                };
            restaurantes.ForEach(m => contexto.Restaurantes.Add(m));
            contexto.SaveChanges();

            var pratos = new List<Prato>()
                {
                    new Prato {Id = 1, RestauranteId = 1, Nome = "Macarronada", Preco = "19,90"},
                    new Prato {Id = 2, RestauranteId = 1, Nome = "Lasanha", Preco = "32,90"},
                    new Prato {Id = 3, RestauranteId = 1, Nome = "Canelone", Preco = "21,90"},
                    new Prato {Id = 4, RestauranteId = 2, Nome = "Feijão Tropeiro", Preco = "18,90"},
                    new Prato {Id = 5, RestauranteId = 2, Nome = "Frango Caipira", Preco = "26,90"},
                    new Prato {Id = 6, RestauranteId = 2, Nome = "Mingau", Preco = "12,90"},
                    new Prato {Id = 7, RestauranteId = 3, Nome = "Sushi", Preco = "33,90"},
                    new Prato {Id = 8, RestauranteId = 3, Nome = "Yakissoba", Preco = "25,90"},
                    new Prato {Id = 9, RestauranteId = 3, Nome = "Temaki", Preco = "21,90"}
                };
            pratos.ForEach(m => contexto.Pratos.Add(m));
            contexto.SaveChanges();
        }
    }
}