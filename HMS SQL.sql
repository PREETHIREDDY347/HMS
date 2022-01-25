create database HMS

create table DoctorInfo(DoctId int unique,DoctName varchar(100),DoctType varchar(100) primary key,DoctMaster varchar(100),ConsultFee int)

insert  into DoctorInfo values(1,'Dr.Preethi Reddy','Cardiologist','MBBS',700)
insert  into DoctorInfo values(2,'Dr.Ankitha','General Physician','MBBS',500)
insert  into DoctorInfo values(3,'Dr.Mayuri','Gynaecologist','Obstretics',650)
insert  into DoctorInfo values(4,'Dr.Lavanya','Dentist','BDS',450)
insert  into DoctorInfo values(5,'Dr.Rutuja','Orthopaedician','Orthopedics',750)
insert  into DoctorInfo values(6,'Dr.Himani','Rheumatologist','Rheumatology',1100)

select * from DoctorInfo
truncate table PatientInfo
drop table PatientInfo
create table PatientInfo(PatientId int primary key,
                         PatientName varchar(100),
						 Issue varchar(100) references DoctorInfo(DoctType),
						 ReferralDoctor varchar(100),
						 EmpId int,
                         EmpName varchar(100),
                         PatientStatus varchar(12),
                         PatientPwd varchar(100))
insert into PatientInfo values(1,'Bhavika','Cardiologist','Dr.Akshay',1223,'Aakansha','OPD','Bhavika')

select * from PatientInfo
 
 