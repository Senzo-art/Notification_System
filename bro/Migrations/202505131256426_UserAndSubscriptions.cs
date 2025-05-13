namespace bro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAndSubscriptions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        NotifyByEmail = c.Boolean(nullable: false),
                        NotifyBySMS = c.Boolean(nullable: false),
                        NotifyByPush = c.Boolean(nullable: false),
                        DateSubscribed = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(maxLength: 15),
                        Password = c.String(nullable: false, maxLength: 100),
                        NotifyByEmail = c.Boolean(nullable: false),
                        NotifyBySMS = c.Boolean(nullable: false),
                        NotifyByPush = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Subscriptions");
        }
    }
}
