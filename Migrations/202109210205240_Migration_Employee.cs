namespace PTB1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_Employee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeNow = c.String(nullable: false, maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.EmployeeNow);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
