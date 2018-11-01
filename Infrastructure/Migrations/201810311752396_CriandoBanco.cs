namespace Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriandoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBL_Jogador",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        PrimeiroNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        UltimoNome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email_Endereco = c.String(nullable: false, maxLength: 200, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .Index(t => t.Email_Endereco, unique: true, name: "UK_JOGADOR_EMAIL");
            
            CreateTable(
                "dbo.Plataforma",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.TBL_Jogador", "UK_JOGADOR_EMAIL");
            DropTable("dbo.Plataforma");
            DropTable("dbo.TBL_Jogador");
        }
    }
}
