namespace pi.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class comment2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Adress = c.String(nullable: false, maxLength: 20),
                        PhoneNumber = c.Int(nullable: false),
                        CIN = c.String(maxLength: 8),
                        Email = c.String(),
                        Password = c.String(),
                        UserName = c.String(),
                        Salary = c.Int(),
                        Position = c.String(),
                        PointOfSaleId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Comment_CommentId = c.Int(),
                        Post_PostId = c.Int(),
                        TeleProspection_TeleProspectionId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Comments", t => t.Comment_CommentId)
                .ForeignKey("dbo.Posts", t => t.Post_PostId)
                .ForeignKey("dbo.PointOfSales", t => t.PointOfSaleId, cascadeDelete: true)
                .ForeignKey("dbo.TeleProspections", t => t.TeleProspection_TeleProspectionId)
                .Index(t => t.PointOfSaleId)
                .Index(t => t.Comment_CommentId)
                .Index(t => t.Post_PostId)
                .Index(t => t.TeleProspection_TeleProspectionId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        ClientId = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
                        Client_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Users", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Client_UserId)
                .Index(t => t.ClientId)
                .Index(t => t.PostId)
                .Index(t => t.Client_UserId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        State = c.String(),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PostId)
                .ForeignKey("dbo.Users", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Reactions",
                c => new
                    {
                        ReactionId = c.Int(nullable: false, identity: true),
                        nblike = c.Int(nullable: false),
                        nbdislike = c.Int(nullable: false),
                        PostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReactionId)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.PointOfSales",
                c => new
                    {
                        PointOfSaleId = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        State = c.String(),
                        Name = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PointOfSaleId);
            
            CreateTable(
                "dbo.Resources",
                c => new
                    {
                        ResourcesId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        EmployeeId = c.Int(nullable: false),
                        PointOfSaleId = c.Int(nullable: false),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.ResourcesId)
                .ForeignKey("dbo.Users", t => t.EmployeeId)
                .ForeignKey("dbo.PointOfSales", t => t.PointOfSaleId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.PointOfSaleId);
            
            CreateTable(
                "dbo.factdevs",
                c => new
                    {
                        FactdevId = c.Int(nullable: false, identity: true),
                        reference = c.Int(nullable: false),
                        prix = c.Int(nullable: false),
                        date = c.DateTime(nullable: false),
                        etat = c.Int(nullable: false),
                        UserId_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.FactdevId)
                .ForeignKey("dbo.Users", t => t.UserId_UserId)
                .Index(t => t.UserId_UserId);
            
            CreateTable(
                "dbo.lignecmds",
                c => new
                    {
                        LignecmdId = c.Int(nullable: false, identity: true),
                        id_factdev = c.Int(nullable: false),
                        id_user = c.Int(nullable: false),
                        quantite = c.Int(nullable: false),
                        prix = c.Single(nullable: false),
                        etat = c.Int(nullable: false),
                        idProduct_idProduct = c.Int(),
                    })
                .PrimaryKey(t => t.LignecmdId)
                .ForeignKey("dbo.Products", t => t.idProduct_idProduct)
                .Index(t => t.idProduct_idProduct);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        idProduct = c.Int(nullable: false, identity: true),
                        Product_Name = c.String(maxLength: 25),
                        Price = c.Single(nullable: false),
                        Picture = c.String(),
                        Stock_Id_Stock = c.Int(),
                    })
                .PrimaryKey(t => t.idProduct)
                .ForeignKey("dbo.Stocks", t => t.Stock_Id_Stock)
                .Index(t => t.Stock_Id_Stock);
            
            CreateTable(
                "dbo.Offres",
                c => new
                    {
                        Id_Offre = c.String(nullable: false, maxLength: 128),
                        Titre = c.String(nullable: false, maxLength: 20),
                        Description = c.String(nullable: false),
                        PrixHorsPack = c.Single(),
                        Total = c.Single(),
                        Prix = c.Single(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Pack_Id_Pack = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id_Offre)
                .ForeignKey("dbo.Packs", t => t.Pack_Id_Pack)
                .Index(t => t.Pack_Id_Pack);
            
            CreateTable(
                "dbo.Packs",
                c => new
                    {
                        Id_Pack = c.String(nullable: false, maxLength: 128),
                        Titre = c.String(nullable: false, maxLength: 20),
                        Description = c.String(nullable: false),
                        Periode_Engagement = c.Int(nullable: false),
                        Prix = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Pack);
            
            CreateTable(
                "dbo.Reclamations",
                c => new
                    {
                        idReclamation = c.Int(nullable: false, identity: true),
                        Titre = c.String(),
                        contenu = c.String(),
                        etat = c.String(),
                        UserId_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.idReclamation)
                .ForeignKey("dbo.Users", t => t.UserId_UserId)
                .Index(t => t.UserId_UserId);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        id_Shop = c.Int(nullable: false, identity: true),
                        shop_name = c.String(),
                        Shop_Location = c.String(),
                        Opening_Time = c.Time(nullable: false, precision: 7),
                        closing_Time = c.Time(nullable: false, precision: 7),
                        Service = c.String(),
                        Shop_id_Shop = c.Int(),
                    })
                .PrimaryKey(t => t.id_Shop)
                .ForeignKey("dbo.Shops", t => t.Shop_id_Shop)
                .Index(t => t.Shop_id_Shop);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id_Stock = c.Int(nullable: false, identity: true),
                        In_Quantity = c.Int(nullable: false),
                        Out_Quantity = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        id_Shop_id_Shop = c.Int(),
                        idProduct_idProduct = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Stock)
                .ForeignKey("dbo.Shops", t => t.id_Shop_id_Shop)
                .ForeignKey("dbo.Products", t => t.idProduct_idProduct)
                .Index(t => t.id_Shop_id_Shop)
                .Index(t => t.idProduct_idProduct);
            
            CreateTable(
                "dbo.TeleProspections",
                c => new
                    {
                        TeleProspectionId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        State = c.String(),
                        Description = c.String(),
                        Priority = c.String(),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeleProspectionId)
                .ForeignKey("dbo.Users", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "TeleProspection_TeleProspectionId", "dbo.TeleProspections");
            DropForeignKey("dbo.TeleProspections", "ClientId", "dbo.Users");
            DropForeignKey("dbo.Products", "Stock_Id_Stock", "dbo.Stocks");
            DropForeignKey("dbo.Stocks", "idProduct_idProduct", "dbo.Products");
            DropForeignKey("dbo.Stocks", "id_Shop_id_Shop", "dbo.Shops");
            DropForeignKey("dbo.Shops", "Shop_id_Shop", "dbo.Shops");
            DropForeignKey("dbo.Reclamations", "UserId_UserId", "dbo.Users");
            DropForeignKey("dbo.Offres", "Pack_Id_Pack", "dbo.Packs");
            DropForeignKey("dbo.lignecmds", "idProduct_idProduct", "dbo.Products");
            DropForeignKey("dbo.factdevs", "UserId_UserId", "dbo.Users");
            DropForeignKey("dbo.Resources", "PointOfSaleId", "dbo.PointOfSales");
            DropForeignKey("dbo.Resources", "EmployeeId", "dbo.Users");
            DropForeignKey("dbo.Users", "PointOfSaleId", "dbo.PointOfSales");
            DropForeignKey("dbo.Comments", "Client_UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Reactions", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Users", "Post_PostId", "dbo.Posts");
            DropForeignKey("dbo.Posts", "ClientId", "dbo.Users");
            DropForeignKey("dbo.Users", "Comment_CommentId", "dbo.Comments");
            DropForeignKey("dbo.Comments", "ClientId", "dbo.Users");
            DropIndex("dbo.TeleProspections", new[] { "ClientId" });
            DropIndex("dbo.Stocks", new[] { "idProduct_idProduct" });
            DropIndex("dbo.Stocks", new[] { "id_Shop_id_Shop" });
            DropIndex("dbo.Shops", new[] { "Shop_id_Shop" });
            DropIndex("dbo.Reclamations", new[] { "UserId_UserId" });
            DropIndex("dbo.Offres", new[] { "Pack_Id_Pack" });
            DropIndex("dbo.Products", new[] { "Stock_Id_Stock" });
            DropIndex("dbo.lignecmds", new[] { "idProduct_idProduct" });
            DropIndex("dbo.factdevs", new[] { "UserId_UserId" });
            DropIndex("dbo.Resources", new[] { "PointOfSaleId" });
            DropIndex("dbo.Resources", new[] { "EmployeeId" });
            DropIndex("dbo.Reactions", new[] { "PostId" });
            DropIndex("dbo.Posts", new[] { "ClientId" });
            DropIndex("dbo.Comments", new[] { "Client_UserId" });
            DropIndex("dbo.Comments", new[] { "PostId" });
            DropIndex("dbo.Comments", new[] { "ClientId" });
            DropIndex("dbo.Users", new[] { "TeleProspection_TeleProspectionId" });
            DropIndex("dbo.Users", new[] { "Post_PostId" });
            DropIndex("dbo.Users", new[] { "Comment_CommentId" });
            DropIndex("dbo.Users", new[] { "PointOfSaleId" });
            DropTable("dbo.TeleProspections");
            DropTable("dbo.Stocks");
            DropTable("dbo.Shops");
            DropTable("dbo.Reclamations");
            DropTable("dbo.Packs");
            DropTable("dbo.Offres");
            DropTable("dbo.Products");
            DropTable("dbo.lignecmds");
            DropTable("dbo.factdevs");
            DropTable("dbo.Resources");
            DropTable("dbo.PointOfSales");
            DropTable("dbo.Reactions");
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
            DropTable("dbo.Users");
        }
    }
}
