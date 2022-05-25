namespace DMS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_new_table_ads : DbMigration
    {
        public override void Up()
        {
            Sql(@"create table ads(
                adsID int primary key,
                adsname varchar(50) not null,
                adscategory varchar(50) not null,
                adsprice nvarchar(20) not null,
                adspic_path nvarchar(255) not null,
                adspic_name nvarchar(255) not null
                );");
        }
        
        public override void Down()
        {
        }
    }
}
