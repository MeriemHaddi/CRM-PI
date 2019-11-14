namespace pi.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class marion123456 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Conversations", "created_at", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Conversations", "created_at");
        }
    }
}
