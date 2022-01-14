namespace ClassExampleNET4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStudentAge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "age");
        }
    }
}
