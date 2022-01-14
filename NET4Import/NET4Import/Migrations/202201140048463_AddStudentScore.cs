namespace NET4Import.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentScore : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Score", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "Score");
        }
    }
}
