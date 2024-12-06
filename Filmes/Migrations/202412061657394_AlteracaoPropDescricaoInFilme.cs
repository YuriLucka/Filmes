namespace Filmes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoPropDescricaoInFilme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Filmes", "Sinopse", c => c.String());
            DropColumn("dbo.Filmes", "Descricao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Filmes", "Descricao", c => c.String());
            DropColumn("dbo.Filmes", "Sinopse");
        }
    }
}
