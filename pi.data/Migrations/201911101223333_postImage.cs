namespace pi.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Picture", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Picture");
        }
    }
}
