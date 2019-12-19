namespace ClassroomBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updte : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.cRooms", "studentEmail", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.cRooms", "studentEmail", c => c.String(nullable: false));
        }
    }
}
