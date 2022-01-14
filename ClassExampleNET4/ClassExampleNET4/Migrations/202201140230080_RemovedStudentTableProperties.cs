namespace ClassExampleNET4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedStudentTableProperties : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student", "Score");
            DropColumn("dbo.Student", "age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "age", c => c.Int(nullable: false));
            AddColumn("dbo.Student", "Score", c => c.Int(nullable: false));
        }
    }
}
