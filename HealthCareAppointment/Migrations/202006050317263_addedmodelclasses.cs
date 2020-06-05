namespace HealthCareAppointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmodelclasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.AspNetRoles",
               c => new
               {
                   Id = c.String(nullable: false, maxLength: 128),
                   Name = c.String(nullable: false, maxLength: 256),
               })
               .PrimaryKey(t => t.Id)
               .Index(t => t.Name, unique: true, name: "RoleNameIndex");

            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                {
                    UserId = c.String(nullable: false, maxLength: 128),
                    RoleId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);

            CreateTable(
                "dbo.AspNetUsers",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(),
                    IsActive = c.Boolean(),
                    Email = c.String(maxLength: 256),
                    EmailConfirmed = c.Boolean(nullable: false),
                    PasswordHash = c.String(),
                    SecurityStamp = c.String(),
                    PhoneNumber = c.String(),
                    PhoneNumberConfirmed = c.Boolean(nullable: false),
                    TwoFactorEnabled = c.Boolean(nullable: false),
                    LockoutEndDateUtc = c.DateTime(),
                    LockoutEnabled = c.Boolean(nullable: false),
                    AccessFailedCount = c.Int(nullable: false),
                    UserName = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");

            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserId = c.String(nullable: false, maxLength: 128),
                    ClaimType = c.String(),
                    ClaimValue = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                {
                    LoginProvider = c.String(nullable: false, maxLength: 128),
                    ProviderKey = c.String(nullable: false, maxLength: 128),
                    UserId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);


            CreateTable(
                "dbo.UserRoles",
                c => new
                {
                    RoleId = c.Int(nullable: false, identity: true),
                    RoleName = c.String(),
                })
                .PrimaryKey(t => t.RoleId);

            CreateTable(
                "dbo.UserRegisters",
                c => new
                {
                    RegisterId = c.Int(nullable: false, identity: true),
                    UserName = c.String(nullable: false),
                    FullName = c.String(nullable: false, maxLength: 100),
                    Password = c.String(nullable: false, maxLength: 100),
                    PhoneNumber = c.String(nullable: false, maxLength: 10),
                    RoleId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.RegisterId)
                .ForeignKey("dbo.UserRoles", t => t.RoleId)
                .Index(t => t.RoleId);

            CreateTable(
                "dbo.States",
                c => new
                {
                    StateId = c.Int(nullable: false, identity: true),
                    StateName = c.String(nullable: false),
                })
                .PrimaryKey(t => t.StateId);

            CreateTable(
                "dbo.Locations",
                c => new
                {
                    LocationId = c.Int(nullable: false, identity: true),
                    LocationName = c.String(nullable: false),
                    StateId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.LocationId)
                .ForeignKey("dbo.States", t => t.StateId)
                .Index(t => t.StateId);

            CreateTable(
                "dbo.Specializations",
                c => new
                {
                    SpecializationId = c.Int(nullable: false, identity: true),
                    SpecializationName = c.String(),
                })
                .PrimaryKey(t => t.SpecializationId);

            CreateTable(
                "dbo.TimeSlots",
                c => new
                {
                    TimeSlotId = c.Int(nullable: false, identity: true),
                    SlotTime = c.String(nullable: false),
                })
                .PrimaryKey(t => t.TimeSlotId);

            CreateTable(
               "dbo.Doctors",
               c => new
               {
                   DoctorId = c.Int(nullable: false, identity: true),
                   DoctorName = c.String(),
                   StateId = c.Int(nullable: false),
                   LocationId = c.Int(nullable: false),
                   SpecializationId = c.Int(nullable: false),
                   Gender = c.Int(nullable: false),
                   Experience = c.Int(nullable: false),
                   PhoneNumber = c.String(),
                   Email = c.String(),
                   IsAvailable = c.Boolean(nullable: false),
                   Address = c.String(),
               })
               .PrimaryKey(t => t.DoctorId)
               .ForeignKey("dbo.Locations", t => t.LocationId)
               .ForeignKey("dbo.Specializations", t => t.SpecializationId)
               .ForeignKey("dbo.States", t => t.StateId)
               .Index(t => t.StateId)
               .Index(t => t.LocationId)
               .Index(t => t.SpecializationId);

            CreateTable(
                "dbo.Patients",
                c => new
                {
                    PatientId = c.Int(nullable: false, identity: true),
                    PatientName = c.String(),
                    Sex = c.Int(nullable: false),
                    BirthDate = c.DateTime(nullable: false),
                    Phone = c.String(),
                    StateId = c.Int(nullable: false),
                    LocationId = c.Int(nullable: false),
                    Address = c.String(),
                    DateTime = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.PatientId)
                .ForeignKey("dbo.Locations", t => t.LocationId)
                .ForeignKey("dbo.States", t => t.StateId)
                .Index(t => t.StateId)
                .Index(t => t.LocationId);

            CreateTable(
                 "dbo.Appointments",
                 c => new
                 {
                     AppointmentId = c.Int(nullable: false, identity: true),
                     AppointmentDate = c.DateTime(nullable: false),
                     Status = c.Int(nullable: false),
                     StateId = c.Int(nullable: false),
                     LocationId = c.Int(nullable: false),
                     DoctorId = c.Int(nullable: false),
                     TimeSlotId = c.Int(nullable: false),
                     SpecializationId = c.Int(nullable: false),
                     RegisterId = c.Int(nullable: false),
                 })
                 .PrimaryKey(t => t.AppointmentId)
                 .ForeignKey("dbo.Doctors", t => t.DoctorId)
                 .ForeignKey("dbo.Locations", t => t.LocationId)
                 .ForeignKey("dbo.Specializations", t => t.SpecializationId)
                 .ForeignKey("dbo.States", t => t.StateId)
                 .ForeignKey("dbo.TimeSlots", t => t.TimeSlotId)
                 .ForeignKey("dbo.UserRegisters", t => t.RegisterId)
                 .Index(t => t.StateId)
                 .Index(t => t.LocationId)
                 .Index(t => t.DoctorId)
                 .Index(t => t.TimeSlotId)
                 .Index(t => t.SpecializationId)
                 .Index(t => t.RegisterId);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Patients", "StateId", "dbo.States");
            DropForeignKey("dbo.Patients", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Appointments", "RegisterId", "dbo.UserRegisters");
            DropForeignKey("dbo.UserRegisters", "RoleId", "dbo.UserRoles");
            DropForeignKey("dbo.Appointments", "TimeSlotId", "dbo.TimeSlots");
            DropForeignKey("dbo.Appointments", "StateId", "dbo.States");
            DropForeignKey("dbo.Appointments", "SpecializationId", "dbo.Specializations");
            DropForeignKey("dbo.Appointments", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Appointments", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "StateId", "dbo.States");
            DropForeignKey("dbo.Doctors", "SpecializationId", "dbo.Specializations");
            DropForeignKey("dbo.Doctors", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Locations", "StateId", "dbo.States");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Patients", new[] { "LocationId" });
            DropIndex("dbo.Patients", new[] { "StateId" });
            DropIndex("dbo.UserRegisters", new[] { "RoleId" });
            DropIndex("dbo.Locations", new[] { "StateId" });
            DropIndex("dbo.Doctors", new[] { "SpecializationId" });
            DropIndex("dbo.Doctors", new[] { "LocationId" });
            DropIndex("dbo.Doctors", new[] { "StateId" });
            DropIndex("dbo.Appointments", new[] { "RegisterId" });
            DropIndex("dbo.Appointments", new[] { "SpecializationId" });
            DropIndex("dbo.Appointments", new[] { "TimeSlotId" });
            DropIndex("dbo.Appointments", new[] { "DoctorId" });
            DropIndex("dbo.Appointments", new[] { "LocationId" });
            DropIndex("dbo.Appointments", new[] { "StateId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Patients");
            DropTable("dbo.UserRoles");
            DropTable("dbo.UserRegisters");
            DropTable("dbo.TimeSlots");
            DropTable("dbo.Specializations");
            DropTable("dbo.States");
            DropTable("dbo.Locations");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}
