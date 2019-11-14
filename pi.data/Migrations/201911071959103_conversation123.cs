namespace pi.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class conversation123 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Conversations", "created_at", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Conversations", "created_at", c => c.DateTime(nullable: false));
        }
    }
}
