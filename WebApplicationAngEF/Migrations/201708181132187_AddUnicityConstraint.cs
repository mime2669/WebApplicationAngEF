namespace WebApplicationAngEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniciteConstraint : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shops", "Address", c => c.String(maxLength: 255));
            AlterColumn("dbo.Products", "Name", c => c.String(maxLength: 150));
            AlterColumn("dbo.Shops", "Name", c => c.String(maxLength: 150));
            CreateIndex("dbo.Products", "Name", unique: true, name: "IX_Unique_Entry");
            CreateIndex("dbo.Shops", new[] { "Name", "Address" }, unique: true, name: "IX_Unique_Entry");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Shops", "IX_Unique_Entry");
            DropIndex("dbo.Products", "IX_Unique_Entry");
            AlterColumn("dbo.Shops", "Name", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            DropColumn("dbo.Shops", "Address");
        }
    }
}
