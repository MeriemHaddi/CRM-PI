namespace pi.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class posts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Comment_CommentId", c => c.Int());
            CreateIndex("dbo.Posts", "Comment_CommentId");
            AddForeignKey("dbo.Posts", "Comment_CommentId", "dbo.Comments", "CommentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Comment_CommentId", "dbo.Comments");
            DropIndex("dbo.Posts", new[] { "Comment_CommentId" });
            DropColumn("dbo.Posts", "Comment_CommentId");
        }
    }
}
