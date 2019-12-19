namespace ClassroomBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ClassroomcRooms", newName: "cRoomClassrooms");
            DropPrimaryKey("dbo.cRoomClassrooms");
            AddPrimaryKey("dbo.cRoomClassrooms", new[] { "cRoom_cRoomID", "Classroom_ClassroomID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.cRoomClassrooms");
            AddPrimaryKey("dbo.cRoomClassrooms", new[] { "Classroom_ClassroomID", "cRoom_cRoomID" });
            RenameTable(name: "dbo.cRoomClassrooms", newName: "ClassroomcRooms");
        }
    }
}
