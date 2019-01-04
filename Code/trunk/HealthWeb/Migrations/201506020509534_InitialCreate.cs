namespace HealthWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(maxLength: 100),
                        ContactNo = c.String(nullable: false, maxLength: 10),
                        AlternateContactNo = c.String(maxLength: 10),
                        Speciality = c.String(maxLength: 8),
                        QualificationSummary = c.String(maxLength: 100),
                        Patient_PatientId = c.Int(),
                    })
                .PrimaryKey(t => t.DoctorId)
                .ForeignKey("dbo.Patients", t => t.Patient_PatientId)
                .Index(t => t.Patient_PatientId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(maxLength: 100),
                        ContactPerson = c.String(nullable: false, maxLength: 20),
                        EmergencyContactNo = c.String(nullable: false, maxLength: 10),
                        AdmissionDate = c.DateTime(nullable: false),
                        DoctorId = c.String(nullable: false),
                        HealthSummary = c.String(),
                    })
                .PrimaryKey(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Doctors", new[] { "Patient_PatientId" });
            DropForeignKey("dbo.Doctors", "Patient_PatientId", "dbo.Patients");
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
        }
    }
}
