namespace TesteLS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Empresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedors", "Empresa_EmpresaID", c => c.Int());
            CreateIndex("dbo.Fornecedors", "Empresa_EmpresaID");
            AddForeignKey("dbo.Fornecedors", "Empresa_EmpresaID", "dbo.Empresas", "EmpresaID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fornecedors", "Empresa_EmpresaID", "dbo.Empresas");
            DropIndex("dbo.Fornecedors", new[] { "Empresa_EmpresaID" });
            DropColumn("dbo.Fornecedors", "Empresa_EmpresaID");
        }
    }
}
