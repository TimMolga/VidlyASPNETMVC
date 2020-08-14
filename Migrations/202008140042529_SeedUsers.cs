namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'09855732-38ec-4d37-97e7-6ebed444135c', N'guest@vidly.com', 0, N'ABzbVk7Vo9+Mfknf8U/00I5sKbm5G5PZzM8zIqxr2bmcuEMRJ9d4R3dWDBtoprCHVw==', N'be972c05-a97f-4a09-8219-0c11f0cc9b13', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8e5f8d29-f489-468c-a63b-3978de24b66b', N'admin@vidly.com', 0, N'ALtkwba88qULDcKtN0Wa6iyJiix4dDZZ9h3Q0qdVVkqH7GPLJrL4HnQh/tZP5RKmIQ==', N'acfe626b-ba2f-4d28-8b3f-a23b64e5edf3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0b5a7d6a-2401-4e35-90e3-8e3dee92ecef', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8e5f8d29-f489-468c-a63b-3978de24b66b', N'0b5a7d6a-2401-4e35-90e3-8e3dee92ecef')

");


        }
        
        public override void Down()
        {
        }
    }
}
