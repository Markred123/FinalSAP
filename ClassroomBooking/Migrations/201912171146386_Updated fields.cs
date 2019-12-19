namespace ClassroomBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatedfields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.cRooms", "cRoomDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.cRooms", "cRoomDate");
        }
    }
}
