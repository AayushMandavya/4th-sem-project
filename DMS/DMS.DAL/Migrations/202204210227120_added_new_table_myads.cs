namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_new_table_myads : DbMigration
    {
        public override void Up()
        {
            Sql(@"create table myads(
                myadsID int primary key,
                myadsname varchar(70) not null,
                myadscategory varchar(50) not null,
                myadsstatus nvarchar(20) not null,
                myadsprice nvarchar(10) not null
                );");

           
        }
        
        public override void Down()
        {
        }
    }
}