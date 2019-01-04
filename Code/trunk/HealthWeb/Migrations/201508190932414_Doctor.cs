namespace HealthWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Doctor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "Speciality", c => c.String(maxLength: 16));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Doctors", "Speciality", c => c.String(maxLength: 8));
        }
    }
}
