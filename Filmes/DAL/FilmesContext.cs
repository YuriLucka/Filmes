using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Filmes.Models;

namespace Filmes.DAL
{
    public class FilmesContext : DbContext
    {
        public FilmesContext() : base("FilmesContext") { }
        public DbSet<Filme> Filmes { get; set; }
    }
}