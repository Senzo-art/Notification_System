namespace bro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPushToSubscriptions : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subscriptions", "PushDevice", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subscriptions", "PushDevice");
        }
    }
}
