namespace TesteLS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tipo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fornecedors", "Tipo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fornecedors", "Tipo");
        }
    }
}
