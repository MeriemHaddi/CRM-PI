namespace pi.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class comment4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "Text", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "Text");
        }
    }
}
