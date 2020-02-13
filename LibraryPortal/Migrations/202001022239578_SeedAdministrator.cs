namespace LibraryPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdministrator : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'409b10c0-30b1-4efa-9f62-f0ea56ef371b', N'admin@portal.com', 0, N'AJyCXdtmOvP4tNPbsi2yOrwCoI5A/MC3rv6x3LkhmvHBJyK5zQrqKkHz2DOU6KjLHg==', N'75d6c759-f6a2-464b-a9ff-4baeabc210c2', NULL, 0, 0, NULL, 1, 0, N'admin@portal.com')
INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'517eb94f-48de-4c47-bdfd-5e2ab8a25ba7', N'guestuser@portal.com', 0, N'AHKVcFSM9t0zVIMfiRYq5S7R77f7JdOOQvYHdLI5PeW/H5cOicykZ8+WgYygeJCSRg==', N'4463e430-6bf5-44e3-8c6f-a308f65d9556', NULL, 0, 0, NULL, 1, 0, N'guestuser@portal.com');
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4edcee5b-b372-4c3d-be5e-7b516ee8ab7e', N'Administrator')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'409b10c0-30b1-4efa-9f62-f0ea56ef371b', N'4edcee5b-b372-4c3d-be5e-7b516ee8ab7e')
");
        }
        
        public override void Down()
        {
        }
    }
}
