namespace CiderAndCode.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makefactrequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AppleFacts", "Fact", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AppleFacts", "Fact", c => c.String());
        }
    }
}
