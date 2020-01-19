namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Quote",
                c => new
                    {
                        QuoteId = c.Int(nullable: false, identity: true),
                        authorName = c.String(),
                        body = c.String(),
                        entryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.QuoteId);
            
        }
        
        public override void Down()
        {
            DropTable("public.Quote");
        }
    }
}
