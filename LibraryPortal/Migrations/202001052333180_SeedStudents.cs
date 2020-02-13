namespace LibraryPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStudents : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3f7e7517-04be-486d-bb2e-933c44d8a31f', N'student01@portal.com', 0, N'ADlVh8XfdaWRB527mShVFquJ+aGij+4YA4rD8pJpTh2dix88rJzouhTXtyjDhN0LHA==', N'0520375f-8762-4b3a-a440-a3c62b18c9b3', NULL, 0, 0, NULL, 1, 0, N'student01@portal.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'409b10c0-30b1-4efa-9f62-f0ea56ef371b', N'admin@portal.com', 0, N'AJyCXdtmOvP4tNPbsi2yOrwCoI5A/MC3rv6x3LkhmvHBJyK5zQrqKkHz2DOU6KjLHg==', N'75d6c759-f6a2-464b-a9ff-4baeabc210c2', NULL, 0, 0, NULL, 1, 0, N'admin@portal.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'438322e1-fdba-4c72-b883-9c880efedb5a', N'librarian@portal.com', 0, N'AE/uVdOE+4unbPA0+WO1SRGnAf4RdNvPmownC2SJMyG20bBApI+x2B9GOL1G5XhjHQ==', N'ac3fb9a1-46c5-4e20-9b2b-184fb64cc40b', NULL, 0, 0, NULL, 1, 0, N'librarian@portal.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'517eb94f-48de-4c47-bdfd-5e2ab8a25ba7', N'guestuser@portal.com', 0, N'AHKVcFSM9t0zVIMfiRYq5S7R77f7JdOOQvYHdLI5PeW/H5cOicykZ8+WgYygeJCSRg==', N'4463e430-6bf5-44e3-8c6f-a308f65d9556', NULL, 0, 0, NULL, 1, 0, N'guestuser@portal.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4edcee5b-b372-4c3d-be5e-7b516ee8ab7e', N'Administrator')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a93f611a-0037-4211-9cc0-037bdcc8d9ff', N'Librarian')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'409b10c0-30b1-4efa-9f62-f0ea56ef371b', N'4edcee5b-b372-4c3d-be5e-7b516ee8ab7e')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3f7e7517-04be-486d-bb2e-933c44d8a31f', N'a530072f-7f7c-413e-a68e-c2e1394f1138')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'438322e1-fdba-4c72-b883-9c880efedb5a', N'a93f611a-0037-4211-9cc0-037bdcc8d9ff')
");
        }
        
        public override void Down()
        {
        }
    }
}
