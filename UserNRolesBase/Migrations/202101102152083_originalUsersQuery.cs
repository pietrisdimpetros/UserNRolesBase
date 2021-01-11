namespace UserNRolesBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class originalUsersQuery : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9e7525ce-9426-450f-83cb-f53cb49fabd4', N'UserNRoles@usernroles.com', 0, N'AEtjksZmeAhZ86pax6te7H3uXlWD6gCVfcOnaovpBySaNv/Nw9k+LCdMKDuiBlPLmA==', N'72276c48-c692-48dc-8f4e-0b63d1cf8287', NULL, 0, 0, NULL, 1, 0, N'UserNRoles@usernroles.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd76c9d60-34f4-48c5-9c49-6559a4822346', N'ApplicationManager@usernroles.com', 0, N'AGvUhkYc9FjSQcCq6U31P3AsQMXUjdzylZeduASH5L6Fk1s4r46ISqWw+Va/O0yR/Q==', N'cc8c0820-0bf1-4b63-b551-408bda21b88c', NULL, 0, 0, NULL, 1, 0, N'ApplicationManager@usernroles.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0f429f0a-62af-4995-acb2-afe5d5b5f345', N'FirstValidatedUser@usernroles.com', 0, N'AI3JK0lRdQlBnN6cbZUtDgDktEaK6DI/Ck2hVGSD5rszgweduKNi2Mb/QVMrFzLAUQ==', N'dbf30e88-f17d-488b-8ca8-47aece4ffa03', NULL, 0, 0, NULL, 1, 0, N'FirstValidatedUser@usernroles.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bfd25793-f62a-46ec-9ea2-832d62cb9c97', N'FirstUnvalidatedUser@usernroles.com', 0, N'AOMaX0CVgAW5LJgRgXwneMIiDDAqfEcAzjFlx2GhyOX2jdTvYTFPr/STeX9uX9mKug==', N'1eafd31a-c09c-402c-be40-c2168895f686', NULL, 0, 0, NULL, 1, 0, N'FirstUnvalidatedUser@usernroles.com')



                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'827a30bb-ae7d-4866-a26e-d9f03004dba2', N'Administrator')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'71efcf05-9d51-41e9-8b6a-00d90a90ad5d', N'Manager')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'610bf9e4-da1d-49a7-9cec-8522d4a3324c', N'Validated User')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'88c6094b-2bd3-4019-988a-301d2f5f39cd', N'Unvalidated User')
                

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9e7525ce-9426-450f-83cb-f53cb49fabd4', N'827a30bb-ae7d-4866-a26e-d9f03004dba2')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd76c9d60-34f4-48c5-9c49-6559a4822346', N'71efcf05-9d51-41e9-8b6a-00d90a90ad5d')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0f429f0a-62af-4995-acb2-afe5d5b5f345', N'610bf9e4-da1d-49a7-9cec-8522d4a3324c')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bfd25793-f62a-46ec-9ea2-832d62cb9c97', N'88c6094b-2bd3-4019-988a-301d2f5f39cd')

");
        }

        public override void Down()
        {
        }
    }
}
