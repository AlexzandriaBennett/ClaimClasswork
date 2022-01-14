namespace ClassExampleNET4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedStudentFromCourse : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Student", "Course_Id", "dbo.Course");
            DropIndex("dbo.Student", new[] { "Course_Id" });
            AlterColumn("dbo.Student", "Course_Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "Course_Id", c => c.Int());
            CreateIndex("dbo.Student", "Course_Id");
            AddForeignKey("dbo.Student", "Course_Id", "dbo.Course", "Id");
        }
    }
}
