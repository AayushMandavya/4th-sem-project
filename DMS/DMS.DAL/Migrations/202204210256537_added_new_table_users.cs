namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_new_table_users : DbMigration
    {
        public override void Up()
        {
            Sql(@"create table users(
                userID int primary key,
                username varchar(70) not null,
                usermail nvarchar(70) not null,
                userpass nvarchar(70) not null
                );");
        }
        
        public override void Down()
        {
        }
    }
}
