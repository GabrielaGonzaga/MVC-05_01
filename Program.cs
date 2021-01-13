using System;
using MVC___05_01.Controllers;
using MVC___05_01.Models;

namespace MVC___05_01
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoController produtoController = new ProdutoController();
           produtoController.MostrarProdutos();
        }
    }
}
