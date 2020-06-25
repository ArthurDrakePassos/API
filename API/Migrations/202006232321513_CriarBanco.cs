namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cachorro",
                c => new
                    {
                        IdCachorro = c.Int(nullable: false, identity: true),
                        NomeCachorro = c.String(),
                        Idade = c.Int(nullable: false),
                        Raca = c.String(),
                        Pesoa = c.Double(nullable: false),
                        Tamanho = c.Double(nullable: false),
                        Doenca = c.String(),
                        Sexo = c.String(),
                        Cor = c.String(),
                        TipoSanguineo = c.String(),
                    })
                .PrimaryKey(t => t.IdCachorro);
            
            CreateTable(
                "dbo.Clinica",
                c => new
                    {
                        IdClinica = c.Int(nullable: false, identity: true),
                        NomeClinica = c.String(),
                        Endereco = c.String(),
                        Cep = c.String(),
                    })
                .PrimaryKey(t => t.IdClinica);
            
            CreateTable(
                "dbo.Doacao",
                c => new
                    {
                        IdDoacao = c.Int(nullable: false, identity: true),
                        IdUsuarioDoador = c.Int(nullable: false),
                        IdCachorroDoador = c.Int(nullable: false),
                        IdUsuarioReceptor = c.Int(nullable: false),
                        IdCachorroReceptor = c.Int(nullable: false),
                        IdClina = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Observacao = c.String(),
                    })
                .PrimaryKey(t => t.IdDoacao);
            
            CreateTable(
                "dbo.Relatorio",
                c => new
                    {
                        IdRelatorio = c.Int(nullable: false, identity: true),
                        IdDoacao = c.Int(nullable: false),
                        IdCachorroDoador = c.Int(nullable: false),
                        IdCachorroReceptor = c.Int(nullable: false),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.IdRelatorio);
            
            CreateTable(
                "dbo.TipoSanguineo",
                c => new
                    {
                        IdTipoSanguineo = c.Int(nullable: false, identity: true),
                        TipoSangue = c.String(),
                    })
                .PrimaryKey(t => t.IdTipoSanguineo);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        idUsuario = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Login = c.String(),
                        Senha = c.String(),
                        Cpf = c.String(),
                        Email = c.String(),
                        Fone = c.String(),
                        PadraoAcesso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idUsuario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
            DropTable("dbo.TipoSanguineo");
            DropTable("dbo.Relatorio");
            DropTable("dbo.Doacao");
            DropTable("dbo.Clinica");
            DropTable("dbo.Cachorro");
        }
    }
}
