namespace FourBlog.Models
{
    public class Postagem
    {

        public int PostagemId { get; set; }

        public string Titulo { get; set; }

        public string Texto { get; set; }

        public DateTime DataCriacao { get; set; }


        public Postagem()
        {

        }

    }
}
