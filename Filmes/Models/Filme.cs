using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Filmes.Models
{
    public enum Categoria
    {
        Ação,
        Aventura,
        Comédia,
        Drama,
        FicçãoCientífica,
        Fantasia,
        Terror,
        Mistério,
        Romance,
        Suspense,
        Documentário,
        Animação,
        Musical,
        Thriller,
        História
    }

    public class Filme
    {
        public int ID { get; set; }
        [Display(Name = "Título")]
        [Required]
        public string Titulo { get; set; }
        [Display(Name = "Sinopse")]
        [Required]
        public string Sinopse { get; set; }
        [Display(Name = "URL da Imagem")]
        [Required]
        public string UrlImagem { get; set; }
        [Display(Name = "URL do Trailer")]
        [Required]
        public string UrlVideo { get; set; }
        [Display(Name = "Avaliação IMDb")]
        [Required]
        public string Avaliacao { get; set; }
        [Required]
        public Categoria Categoria { get; set; }
        [Display(Name = "Direção")]
        [Required]
        public string Direcao { get; set; }
        [Display(Name = "Duração")]
        [Required]
        public TimeSpan Duracao { get; set; }
    }
}