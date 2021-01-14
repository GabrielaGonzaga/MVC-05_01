using System.Collections.Generic;
using MVC___05_01.Models;
using MVC___05_01.Views;

namespace MVC___05_01.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();
         public void MostrarProdutos(){

            List<Produto> todos =  produto.Ler();
            produtoView.ListarTodos(todos);
        }

        public void Cadastrar(){

            produto.Inserir(produtoView.CadastrarProduto());

        }
    }
}