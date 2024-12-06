namespace Filmes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AplicadoRequiredInFilme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Filmes", "Titulo", c => c.String(nullable: false));
            AlterColumn("dbo.Filmes", "Sinopse", c => c.String(nullable: false));
            AlterColumn("dbo.Filmes", "UrlImagem", c => c.String(nullable: false));
            AlterColumn("dbo.Filmes", "UrlVideo", c => c.String(nullable: false));
            AlterColumn("dbo.Filmes", "Avaliacao", c => c.String(nullable: false));
            AlterColumn("dbo.Filmes", "Direcao", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Filmes", "Direcao", c => c.String());
            AlterColumn("dbo.Filmes", "Avaliacao", c => c.String());
            AlterColumn("dbo.Filmes", "UrlVideo", c => c.String());
            AlterColumn("dbo.Filmes", "UrlImagem", c => c.String());
            AlterColumn("dbo.Filmes", "Sinopse", c => c.String());
            AlterColumn("dbo.Filmes", "Titulo", c => c.String());
        }
    }
}
