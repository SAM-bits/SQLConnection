

--Creating Tables 

Create table Supervisor(
	SupervisorId int Primary Key IDENTITY,
	FirstName VarChar(50),
	LastName VarChar(50),
	PhoneNumber VarChar(11),
	Email VarChar(50),
	Hire_Date Date,
	HourlyPay Decimal (5,2)



);




Create table Employee(
	EmployeeId int Primary Key IDENTITY,
	FirstName VarChar(50),
	LastName VarChar(50),
	PhoneNumber VarChar(11),
	Email VarChar(50),
	Hire_Date Date,
	HourlyPay Decimal (5,2)


);


Create table WorkPlan(
	PlanId int Primary Key IDENTITY, 
	PlanDate Date


);


Create table WorkShift(
	ShiftId int Primary Key IDENTITY ,
	ShiftDate Date,
	StartTime Time(0),
	EndTime Time(0),
	SupervisorId int FOREIGN KEY (SupervisorId) references Supervisor(SupervisorId) NOT NULL ,
	EmployeeId int FOREIGN KEY (EmployeeId) references Employee(EmployeeId),
	PlanId int FOREIGN KEY (PlanId) references WorkPlan(PlanId) 

);


--Deleting tables 
DROP table Employee
--Deleting tables 
DROP table Supervisor
--Deleting tables 
DROP table WorkPlan
--Deleting tables 
DROP table WorkShift


--Creating new WorkPlan 
select * from workplan
Insert into WorkPlan (PlanDate)
Values ('2028-01-01');


-- Creating new Workshift 
Select * from Workshift
Insert into WorkShift (ShiftDate,StartTime,EndTime,SupervisorId,EmployeeId,PlanId)
Values ('2028-01-01' , '09:00:00', '14:00:00',1,2,262);

--Edit or update 
UPDATE WorkShift 
SET StartTime = '09:10:00' , EndTime ='14:10:00' 
Where Workshift.ShiftId = 1045














-- dette er fra ChatGPT som har automatisk generet dem 
INSERT INTO Employee (FirstName, LastName, PhoneNumber, Email, Hire_Date, HourlyPay)
VALUES

('Noora', 'Madie', '34553455', 'NooraM@firma.dk', '2024-01-15', 250.00),
('Lars', 'Nielsen', '22112233', 'lars@firma.dk', '2024-01-15', 150.00),
('Sofie', 'Andersen', '33114455', 'sofie@firma.dk', '2024-02-20', 155.00),
('Jonas', 'Pedersen', '44556677', 'jonas@firma.dk', '2023-08-01', 160.00),
('Emma', 'Madsen', '55667788', 'emma@firma.dk', '2025-01-10', 150.00),
('Noah', 'Christensen', '66778899', 'noah@firma.dk', '2025-02-05', 145.00),
('Freja', 'Larsen', '77889900', 'freja@firma.dk', '2024-06-12', 155.00),
('Saif', 'Madie', '22112233', 'saifmadie@firma.dk', '2024-01-15', 260.00),
('Mohammed', 'AlGassan', '34342342', 'MG@firma.dk', '2024-02-20', 199.00),
('Ali', 'Hansen', '77663322', 'AliG@firma.dk', '2023-08-01', 180.00),
('Hamza', 'Madie', '32455544', 'hamzaM@firma.dk', '2025-01-10', 350.00),
('Noah', 'Christensen', '66778899', 'noah@firma.dk', '2025-02-05', 145.00),
('Warda', 'AlMadie', '77889900', 'WardaWarda@firma.dk', '2024-06-12', 140.00);

select * from Employee

INSERT INTO Supervisor (FirstName, LastName, PhoneNumber, Email, Hire_Date, HourlyPay)
VALUES

('Hayat', 'Madie', '34553455', 'NooraM@firma.dk', '2024-01-15', 250.00),
('Noor', 'Nielsen', '22112233', 'lars@firma.dk', '2024-01-15', 150.00);