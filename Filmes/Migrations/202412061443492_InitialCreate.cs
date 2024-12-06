namespace Filmes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filmes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Descricao = c.String(),
                        UrlImage = c.String(),
                        Avaliacao = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Categoria = c.Int(nullable: false),
                        Direcao = c.String(),
                        Duracao = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Filmes");
        }
    }
}
