namespace pi.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "vue", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "vue");
        }
    }
}
