namespace pi.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class conversation1234567 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Conversations", "created_at");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Conversations", "created_at", c => c.DateTime(nullable: false));
        }
    }
}
