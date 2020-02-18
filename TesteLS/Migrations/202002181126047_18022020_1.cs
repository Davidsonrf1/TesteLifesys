namespace TesteLS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _18022020_1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Fornecedors", name: "EmpresaID_EmpresaID", newName: "Empresa_EmpresaID");
            RenameIndex(table: "dbo.Fornecedors", name: "IX_EmpresaID_EmpresaID", newName: "IX_Empresa_EmpresaID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Fornecedors", name: "IX_Empresa_EmpresaID", newName: "IX_EmpresaID_EmpresaID");
            RenameColumn(table: "dbo.Fornecedors", name: "Empresa_EmpresaID", newName: "EmpresaID_EmpresaID");
        }
    }
}
