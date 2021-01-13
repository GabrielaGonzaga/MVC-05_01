using System.Collections.Generic;
using System.IO;

namespace MVC___05_01.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/Produto.csv";

        public Produto(){
            string pasta = PATH.Split("/")[0];
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
        }

        public List<Produto> Ler(){
            
            List<Produto> produtos = new List<Produto>();

            //Pegar as Informações do csv
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string item in linhas){

            //Seprar atributos pelo ;
            string[] atributos = item.Split(";");

            //Criamos um produto vazio para poder colocar na lista final de produtos
            Produto prod = new Produto();
            prod.Codigo  = int.Parse( atributos[0] );
            prod.Nome = atributos[1];
            prod.Preco = float.Parse( atributos[2] );

            produtos.Add(prod);

            }
            return produtos;

            
        }
    }
}