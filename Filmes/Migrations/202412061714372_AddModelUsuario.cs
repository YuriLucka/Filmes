namespace Filmes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModelUsuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Login = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Filmes", "Usuario_ID", c => c.Int());
            CreateIndex("dbo.Filmes", "Usuario_ID");
            AddForeignKey("dbo.Filmes", "Usuario_ID", "dbo.Usuarios", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Filmes", "Usuario_ID", "dbo.Usuarios");
            DropIndex("dbo.Filmes", new[] { "Usuario_ID" });
            DropColumn("dbo.Filmes", "Usuario_ID");
            DropTable("dbo.Usuarios");
        }
    }
}
