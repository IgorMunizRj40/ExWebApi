using ExemploWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWebApi.Controllers
{
    public class LojaController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        //método para ver os clientes da lista (get) tipo de chamada rest
        //criamos com o mesmo nome (get)para não precisar lançar [HttpGet]
        //em cima do publi 
        public List<Cliente> Get() 
        {
            return clientes; 
        }
        //metodo para fazer a inserção de nomes da lista -- void pois não retorna nada
        //Post pois e o método usado para fazer inserção
        public void Post(string nome) //[frombody] se eu passar através do corpo da solicitação no postman 
        {
            //usamos a lógica para obrigar o usuário a colocar um nome not null
            if(!string.IsNullOrEmpty(nome))
                clientes.Add(new Cliente(nome));

        }

        //utilzamos link+lambda pois e um modo de fazer consultas e operações no c# pois e mais rápido e prático
        //poderia ser for it
        public void Delete(string nome) 
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));

        }

    }
}
