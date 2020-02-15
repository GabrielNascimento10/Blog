using Blog.Models.Blog.Autor;
using Blog.Models.Blog.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Blog.Postagem
{
    public class PostagemEntity
    {
        //FQCN => Fully Qualified Class Name
        //Blog.Models.Blog.Postagem.PostagemEntity

        //private string Titulo;
        //protected string Titulo;

        public string Titulo;
        public AutorEntity Autor;
        public CategoriaEntity Categoria;

        public virtual string editar() // Polimorfismo
        {
            return "edição realizada";
        }
    }

        public class PostagemSobreFilmesEntity : PostagemEntity //Herança
    {
        public string Genero; //Encapsolamento

        public override string editar() // Polimorfismo
        {
            return "edição realizada na postagem sobre filmes";
        }
    }
}