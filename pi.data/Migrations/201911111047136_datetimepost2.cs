namespace pi.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetimepost2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Date", c => c.DateTime(nullable: false));
        }
    }
}
