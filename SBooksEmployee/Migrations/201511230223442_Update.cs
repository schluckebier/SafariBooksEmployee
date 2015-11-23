namespace SBooksEmployee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        EmpEmail = c.String(nullable: false),
                        EmpFName = c.String(nullable: false),
                        EmpMI = c.String(),
                        EmpLName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        ZipCode = c.Int(nullable: false),
                        Phone = c.String(nullable: false),
                        EmpActive = c.Boolean(nullable: false),
                        Managers = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
