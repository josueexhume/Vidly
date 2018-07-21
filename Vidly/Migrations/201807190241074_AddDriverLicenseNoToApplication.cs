namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDriverLicenseNoToApplication : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DriverLicenseNo", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DriverLicenseNo");
        }
    }
}
