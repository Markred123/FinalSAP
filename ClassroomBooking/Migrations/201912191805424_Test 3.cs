namespace ClassroomBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.cRooms", "studentEmail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.cRooms", "studentEmail");
        }
    }
}
