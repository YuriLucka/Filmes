namespace Filmes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsercaoPropVideoInFilme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Filmes", "UrlImagem", c => c.String());
            AddColumn("dbo.Filmes", "UrlVideo", c => c.String());
            DropColumn("dbo.Filmes", "UrlImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Filmes", "UrlImage", c => c.String());
            DropColumn("dbo.Filmes", "UrlVideo");
            DropColumn("dbo.Filmes", "UrlImagem");
        }
    }
}
