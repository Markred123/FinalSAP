namespace ClassroomBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test44 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.cRooms", "roomName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.cRooms", "roomName", c => c.String());
        }
    }
}
