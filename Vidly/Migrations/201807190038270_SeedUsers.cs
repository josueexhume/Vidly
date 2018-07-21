namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2e0bb5d9-6e0f-4695-8312-d759cadbc5f7', N'admin@vidly.com', 0, N'AMMVNZVetnO8bpX9sR0oK5Ccg+NYCGUowFN5N9fky2iqNfglTwOM0Ne9eccY+Ex/xA==', N'8ab19be2-5333-4d24-a87a-abd7f4810371', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'53505b84-85ee-41b7-8db6-00ba27be96a6', N'guest@vidly.com', 0, N'ALOboDcO8nV7mvQNdQnffatSGxR0Onjqut9bnv5CCNi35OfRfgt+JFgDkBjIm+bwFA==', N'21513bf6-8fa7-4d75-aedb-8298d41346a0', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c52e7589-88d9-456d-843f-393d1ad301d9', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2e0bb5d9-6e0f-4695-8312-d759cadbc5f7', N'c52e7589-88d9-456d-843f-393d1ad301d9')");
        }
        
        public override void Down()
        {
        }
    }
}
