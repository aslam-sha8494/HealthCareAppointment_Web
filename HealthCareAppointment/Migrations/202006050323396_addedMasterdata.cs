namespace HealthCareAppointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addedMasterdata : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into dbo.UserRoles(RoleName) values('Admin');" +
              "Insert Into dbo.UserRoles(RoleName) values('Doctor');" +
              "Insert Into dbo.UserRoles(RoleName) values('Patient');" +


              "Insert into States (StateName) values ('TamilNadu');" +
               "Insert into States (StateName) values ('Karnataka');" +
               "Insert into States (StateName) values ('Delhi');" +
               "Insert into States (StateName) values ('Mumbai');" +

               "Insert into Locations (LocationName, StateId) values ('Chennai','1')" +
               "Insert into Locations (LocationName, StateId) values ('Madurai','1')" +
               "Insert into Locations (LocationName, StateId) values ('Trichy','1')" +
               "Insert into Locations (LocationName, StateId) values ('Coimbatore','1')" +

               "Insert into TimeSlots (SlotTime) values ('10:00 AM - 11:00 AM');" +
               "Insert into TimeSlots (SlotTime) values ('11:00 AM - 12:00 PM');" +
               "Insert into TimeSlots (SlotTime) values ('12:00 AM - 01:00 PM');" +
               "Insert into TimeSlots (SlotTime) values ('02:00 AM - 03:00 PM');" +
               "Insert into TimeSlots (SlotTime) values ('03:00 AM - 04:00 PM');" +
               "Insert into TimeSlots (SlotTime) values ('04:00 AM - 05:00 PM');" +

               "Insert into specializations (SpecializationName) values ('Anesthesiologists')" +
               "Insert into specializations (SpecializationName) values ('Cardiologists')" +
               "Insert into specializations (SpecializationName) values ('Gastroenterologists')" +
               "Insert into specializations (SpecializationName) values ('Dermatologists')" +
               "Insert into specializations (SpecializationName) values ('Neurologists')" +

               "Insert into Doctors (DoctorName, stateId, LocationId, specializationId, Gender, Experience, PhoneNumber, Email, IsAvailable,Address) values('Aswin', '1', '1', '1', '1', '10','aswin@gmail.com', '9876542345', '1', 'Taramani,chennai'); " +
               "Insert into Doctors (DoctorName, stateId, LocationId, specializationId, Gender, Experience, PhoneNumber, Email, IsAvailable,Address)values('Rajesh', '1', '1', '2', '1', '12', 'rajesh@gmail.com','9876546712', '1', 'Taramani,chennai'); " +
               "Insert into Doctors (DoctorName, stateId, LocationId, specializationId, Gender, Experience, PhoneNumber, Email, IsAvailable,Address)values('Prabu', '1', '1', '3', '1', '14', 'prabu@gmail.com','9887641765', '1', 'Taramani,chennai'); " +
               "Insert into Doctors (DoctorName, stateId, LocationId, specializationId, Gender, Experience, PhoneNumber, Email, IsAvailable,Address) values('Mythili', '1', '1', '4', '2', '11','mythili@gmail.com', '7867541234', '1', 'Taramani,chennai'); " +
               "Insert into Doctors (DoctorName, stateId, LocationId, specializationId, Gender, Experience, PhoneNumber, Email, IsAvailable,Address) values('Logesh', '1', '1', '5', '1', '8', 'logesh@gmail.com','8765678976', '1', 'Taramani,chennai'); " +


               "Insert into Patients (PatientName,Sex,BirthDate,Phone,StateId,LocationId,Address,Datetime)values('Bhaskar','1','08APR1994','9876234561','1','1','Velachery',Getdate())" +
               "Insert into Patients (PatientName,Sex,BirthDate,Phone,StateId,LocationId,Address,Datetime)values('Lekha','2','27JUN1993','9870034561','1','1','Velachery',Getdate())" +
               "Insert into Patients (PatientName,Sex,BirthDate,Phone,StateId,LocationId,Address,Datetime)values('Sakthi','1','08APR1990','9876123561','1','1','Velachery',Getdate())" +
               "Insert into Patients (PatientName,Sex,BirthDate,Phone,StateId,LocationId,Address,Datetime)values('Vaishnavi','2','09AUG1980','9876238761','1','1','Velachery',Getdate())" +
               "Insert into Patients (PatientName,Sex,BirthDate,Phone,StateId,LocationId,Address,Datetime)values('Logeshwari','2','19APR1994','9876234098','1','1','Velachery',Getdate())" +
               "Insert into Patients (PatientName,Sex,BirthDate,Phone,StateId,LocationId,Address,Datetime)values('Vishnu','1','01JUN2005','9876230961','1','1','Velachery',Getdate())");
        }

        public override void Down()
        {
        }
    }
}
