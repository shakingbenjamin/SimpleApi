namespace SimpleApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameOrNumber = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        Province = c.String(),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Mobile = c.String(),
                        AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Address", t => t.AddressID, cascadeDelete: true)
                .Index(t => t.AddressID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contact", "AddressID", "dbo.Address");
            DropIndex("dbo.Contact", new[] { "AddressID" });
            DropTable("dbo.Contact");
            DropTable("dbo.Address");
        }
    }
}
