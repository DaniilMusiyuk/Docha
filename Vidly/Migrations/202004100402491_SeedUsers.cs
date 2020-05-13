namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2549b460-da1b-42c0-83ba-c51a90c2f628', N'asdasd@gmail.com', 0, N'APmK5BM6JRQF6fq/JCwjEljsTTNMZLuZi3+mRKwgPFTNVmawOaLaucsv1kWCxEBbiQ==', N'e6fe8567-38ea-46f4-83a0-e0292870af04', NULL, 0, 0, NULL, 1, 0, N'asdasd@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ab485482-b502-477e-adea-5beda4938f93', N'admin@vidly.com', 0, N'AAWONsk57pvJPaa/saIbQymRIHWGAs772btGAg0/HRj0Qi9GB90Q0Q7apCZXuyfgKQ==', N'41fd47dd-cf67-46ef-8121-f35c48afbebc', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fb78b12f-3e99-4f5d-9013-17b6932f6f9d', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ab485482-b502-477e-adea-5beda4938f93', N'fb78b12f-3e99-4f5d-9013-17b6932f6f9d')
");
        }
        
        public override void Down()
        {
        }
    }
}
