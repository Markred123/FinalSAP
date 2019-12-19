namespace ClassroomBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.cRooms", "studentName", c => c.String());
            AddColumn("dbo.cRooms", "studentPhone", c => c.Int(nullable: false));
            DropColumn("dbo.cRooms", "cRoomName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.cRooms", "cRoomName", c => c.String());
            DropColumn("dbo.cRooms", "studentPhone");
            DropColumn("dbo.cRooms", "studentName");
        }
    }
}
