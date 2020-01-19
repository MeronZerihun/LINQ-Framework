namespace TestApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("public.Quote", "authorName", c => c.String(nullable: false));
            AlterColumn("public.Quote", "body", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("public.Quote", "body", c => c.String());
            AlterColumn("public.Quote", "authorName", c => c.String());
        }
    }
}
