
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
	StartTime Time,
	EndTime Time,
	SupervisorId int FOREIGN KEY (SupervisorId) references Supervisor(SupervisorId) NOT NULL ,
	EmployeeId int FOREIGN KEY (EmployeeId) references Employee(EmployeeId),
	PlanId int FOREIGN KEY (PlanId) references WorkPlan(PlanId) 

);

Delete Supervisor


SELECT * FROM Employee 
SELECT * FROM Supervisor 
SELECT * FROM WorkPlan
SELECT * FROM WorkShift


-- dette er fra ChatGPT som har automatisk generet dem 
INSERT INTO Supervisor (FirstName, LastName, PhoneNumber, Email, Hire_Date, HourlyPay)
VALUES
('Peter', 'Hansen', '20112233', 'peter@firma.dk', '2023-01-10', 250.00),
('Maria', 'Jensen', '30445566', 'maria@firma.dk', '2024-03-15', 260.00);


-- dette er fra ChatGPT som har automatisk generet dem 
INSERT INTO Employee (FirstName, LastName, PhoneNumber, Email, Hire_Date, HourlyPay)
VALUES
('Lars', 'Nielsen', '22112233', 'lars@firma.dk', '2024-01-15', 150.00),
('Sofie', 'Andersen', '33114455', 'sofie@firma.dk', '2024-02-20', 155.00),
('Jonas', 'Pedersen', '44556677', 'jonas@firma.dk', '2023-08-01', 160.00),
('Emma', 'Madsen', '55667788', 'emma@firma.dk', '2025-01-10', 150.00),
('Noah', 'Christensen', '66778899', 'noah@firma.dk', '2025-02-05', 145.00),
('Freja', 'Larsen', '77889900', 'freja@firma.dk', '2024-06-12', 155.00);

-- dette er fra ChatGPT som har automatisk generet dem 
INSERT INTO WorkPlan (PlanDate)
VALUES
('2026-10-01'),
('2026-10-02'),
('2026-10-03'),
('2026-10-04'),
('2026-10-05'),
('2026-10-06'),
('2026-10-07'),
('2026-10-08'),
('2026-10-09'),
('2026-10-10'),
('2026-10-11'),
('2026-10-12'),
('2026-10-13'),
('2026-10-14'),
('2026-10-15'),
('2026-10-16'),
('2026-10-17'),
('2026-10-18'),
('2026-10-19'),
('2026-10-20'),
('2026-10-21'),
('2026-10-22'),
('2026-10-23'),
('2026-10-24'),
('2026-10-25'),
('2026-10-26'),
('2026-10-27'),
('2026-10-28'),
('2026-10-29'),
('2026-10-30'),
('2026-10-31');

-- dette er fra ChatGPT som har automatisk generet dem 
INSERT INTO WorkShift
    (ShiftDate, StartTime, EndTime, SupervisorId, EmployeeId, PlanId)
VALUES

-- 01-10
('2026-10-01', '09:00', '14:00', 4, 13, 1),
('2026-10-01', '09:00', '14:00', 4, 14, 1),
('2026-10-01', '14:00', '19:00', 5, 15, 1),
('2026-10-01', '14:00', '19:00', 5, 16, 1),

-- 02-10
('2026-10-02', '09:00', '14:00', 5, 17, 2),
('2026-10-02', '09:00', '14:00', 5, 18, 2),
('2026-10-02', '14:00', '19:00', 4, 13, 2),
('2026-10-02', '14:00', '19:00', 4, 15, 2),

-- 03-10
('2026-10-03', '09:00', '14:00', 4, 14, 3),
('2026-10-03', '09:00', '14:00', 4, 16, 3),
('2026-10-03', '14:00', '19:00', 5, 17, 3),
('2026-10-03', '14:00', '19:00', 5, 18, 3),

-- 04-10
('2026-10-04', '09:00', '14:00', 5, 13, 4),
('2026-10-04', '09:00', '14:00', 5, 14, 4),
('2026-10-04', '14:00', '19:00', 4, 15, 4),
('2026-10-04', '14:00', '19:00', 4, 17, 4),

-- 05-10
('2026-10-05', '09:00', '14:00', 4, 16, 5),
('2026-10-05', '09:00', '14:00', 4, 18, 5),
('2026-10-05', '14:00', '19:00', 5, 13, 5),
('2026-10-05', '14:00', '19:00', 5, 14, 5),

-- 06-10
('2026-10-06', '09:00', '14:00', 5, 15, 6),
('2026-10-06', '09:00', '14:00', 5, 17, 6),
('2026-10-06', '14:00', '19:00', 4, 16, 6),
('2026-10-06', '14:00', '19:00', 4, 18, 6),

-- 07-10
('2026-10-07', '09:00', '14:00', 4, 13, 7),
('2026-10-07', '09:00', '14:00', 4, 15, 7),
('2026-10-07', '14:00', '19:00', 5, 14, 7),
('2026-10-07', '14:00', '19:00', 5, 17, 7),

-- 08-10
('2026-10-08', '09:00', '14:00', 5, 16, 8),
('2026-10-08', '09:00', '14:00', 5, 18, 8),
('2026-10-08', '14:00', '19:00', 4, 13, 8),
('2026-10-08', '14:00', '19:00', 4, 15, 8),

-- 09-10
('2026-10-09', '09:00', '14:00', 4, 14, 9),
('2026-10-09', '09:00', '14:00', 4, 16, 9),
('2026-10-09', '14:00', '19:00', 5, 17, 9),
('2026-10-09', '14:00', '19:00', 5, 18, 9),

-- 10-10
('2026-10-10', '09:00', '14:00', 5, 13, 10),
('2026-10-10', '09:00', '14:00', 5, 15, 10),
('2026-10-10', '14:00', '19:00', 4, 14, 10),
('2026-10-10', '14:00', '19:00', 4, 16, 10),

-- 11-10
('2026-10-11', '09:00', '14:00', 4, 17, 11),
('2026-10-11', '09:00', '14:00', 4, 18, 11),
('2026-10-11', '14:00', '19:00', 5, 13, 11),
('2026-10-11', '14:00', '19:00', 5, 15, 11),

-- 12-10
('2026-10-12', '09:00', '14:00', 5, 14, 12),
('2026-10-12', '09:00', '14:00', 5, 16, 12),
('2026-10-12', '14:00', '19:00', 4, 17, 12),
('2026-10-12', '14:00', '19:00', 4, 18, 12),

-- 13-10
('2026-10-13', '09:00', '14:00', 4, 13, 13),
('2026-10-13', '09:00', '14:00', 4, 14, 13),
('2026-10-13', '14:00', '19:00', 5, 15, 13),
('2026-10-13', '14:00', '19:00', 5, 16, 13),

-- 14-10
('2026-10-14', '09:00', '14:00', 4, 17, 14),
('2026-10-14', '09:00', '14:00', 4, 18, 14),
('2026-10-14', '14:00', '19:00', 4, 13, 14),
('2026-10-14', '14:00', '19:00', 4, 14, 14),

-- 15-10
('2026-10-15', '09:00', '14:00', 4, 15, 15),
('2026-10-15', '09:00', '14:00', 4, 17, 15),
('2026-10-15', '14:00', '19:00', 5, 16, 15),
('2026-10-15', '14:00', '19:00', 5, 18, 15),

-- 16-10
('2026-10-16', '09:00', '14:00', 5, 13, 16),
('2026-10-16', '09:00', '14:00', 5, 14, 16),
('2026-10-16', '14:00', '19:00', 4, 15, 16),
('2026-10-16', '14:00', '19:00', 4, 17, 16),

-- 17-10
('2026-10-17', '09:00', '14:00', 4, 16, 17),
('2026-10-17', '09:00', '14:00', 4, 18, 17),
('2026-10-17', '14:00', '19:00', 5, 13, 17),
('2026-10-17', '14:00', '19:00', 5, 14, 17),

-- 18-10
('2026-10-18', '09:00', '14:00', 5, 15, 18),
('2026-10-18', '09:00', '14:00', 5, 16, 18),
('2026-10-18', '14:00', '19:00', 4, 17, 18),
('2026-10-18', '14:00', '19:00', 4, 18, 18),

-- 19-10
('2026-10-19', '09:00', '14:00', 5, 13, 19),
('2026-10-19', '09:00', '14:00', 5, 15, 19),
('2026-10-19', '14:00', '19:00', 5, 14, 19),
('2026-10-19', '14:00', '19:00', 5, 16, 19),

-- 20-10
('2026-10-20', '09:00', '14:00', 5, 17, 20),
('2026-10-20', '09:00', '14:00', 5, 18, 20),
('2026-10-20', '14:00', '19:00', 4, 13, 20),
('2026-10-20', '14:00', '19:00', 4, 15, 20),

-- 21-10
('2026-10-21', '09:00', '14:00', 4, 14, 21),
('2026-10-21', '09:00', '14:00', 4, 17, 21),
('2026-10-21', '14:00', '19:00', 5, 16, 21),
('2026-10-21', '14:00', '19:00', 5, 18, 21),

-- 22-10
('2026-10-22', '09:00', '14:00', 5, 13, 22),
('2026-10-22', '09:00', '14:00', 5, 15, 22),
('2026-10-22', '14:00', '19:00', 4, 14, 22),
('2026-10-22', '14:00', '19:00', 4, 17, 22),

-- 23-10
('2026-10-23', '09:00', '14:00', 4, 16, 23),
('2026-10-23', '09:00', '14:00', 4, 18, 23),
('2026-10-23', '14:00', '19:00', 5, 13, 23),
('2026-10-23', '14:00', '19:00', 5, 15, 23),

-- 24-10
('2026-10-24', '09:00', '14:00', 4, 14, 24),
('2026-10-24', '09:00', '14:00', 4, 17, 24),
('2026-10-24', '14:00', '19:00', 4, 16, 24),
('2026-10-24', '14:00', '19:00', 4, 18, 24),

-- 25-10
('2026-10-25', '09:00', '14:00', 4, 13, 25),
('2026-10-25', '09:00', '14:00', 4, 14, 25),
('2026-10-25', '14:00', '19:00', 5, 15, 25),
('2026-10-25', '14:00', '19:00', 5, 17, 25),

-- 26-10
('2026-10-26', '09:00', '14:00', 5, 16, 26),
('2026-10-26', '09:00', '14:00', 5, 18, 26),
('2026-10-26', '14:00', '19:00', 4, 13, 26),
('2026-10-26', '14:00', '19:00', 4, 14, 26),

-- 27-10
('2026-10-27', '09:00', '14:00', 4, 15, 27),
('2026-10-27', '09:00', '14:00', 4, 16, 27),
('2026-10-27', '14:00', '19:00', 5, 17, 27),
('2026-10-27', '14:00', '19:00', 5, 18, 27),

-- 28-10
('2026-10-28', '09:00', '14:00', 5, 13, 28),
('2026-10-28', '09:00', '14:00', 5, 15, 28),
('2026-10-28', '14:00', '19:00', 4, 16, 28),
('2026-10-28', '14:00', '19:00', 4, 17, 28),

-- 29-10
('2026-10-29', '09:00', '14:00', 4, 14, 29),
('2026-10-29', '09:00', '14:00', 4, 18, 29),
('2026-10-29', '14:00', '19:00', 5, 13, 29),
('2026-10-29', '14:00', '19:00', 5, 15, 29),

-- 30-10
('2026-10-30', '09:00', '14:00', 5, 16, 30),
('2026-10-30', '09:00', '14:00', 5, 17, 30),
('2026-10-30', '14:00', '19:00', 5, 14, 30),
('2026-10-30', '14:00', '19:00', 5, 18, 30),

-- 31-10
('2026-10-31', '09:00', '14:00', 4, 13, 31),
('2026-10-31', '09:00', '14:00', 4, 15, 31),
('2026-10-31', '14:00', '19:00', 5, 16, 31),
('2026-10-31', '14:00', '19:00', 5, 17, 31);


Select WorkShift.ShiftDate, WorkShift.StartTime,WorkShift.EndTime,Employee.FirstName As EmployeeName,Supervisor.FirstName as SupervisorName from WorkShift
inner join Employee
On.WorkShift.EmployeeId = Employee.EmployeeId
inner join Supervisor
On.WorkShift.SupervisorId = Supervisor.SupervisorId
order by ShiftDate asc 


Select WorkShift.ShiftDate, WorkShift.StartTime,WorkShift.EndTime,Employee.FirstName As EmployeeName,Supervisor.FirstName as SupervisorName
from WorkShift
inner join Employee
On.WorkShift.EmployeeId = Employee.EmployeeId
inner join Supervisor
On.WorkShift.SupervisorId = Supervisor.SupervisorId
--where Employee.EmployeeId = 15
where Supervisor.supervisorid = 4






SELECT Sum(DATEDIFF(Hour,Workshift.StartTime,WorkShift.EndTime)) AS totalHour , Employee.FirstName as EmployeeName , Supervisor.FirstName as SupervisorName
From WorkShift
inner join Employee
On.WorkShift.EmployeeId = Employee.EmployeeId
inner join Supervisor
On.WorkShift.SupervisorId = Supervisor.SupervisorId
--where EmployeeId = 15
where WorkShift.SupervisorId = 4
group by Supervisor.FirstName , Employee.FirstName


-- Payment total for Supervoicers
SELECT SUM(DATEDIFF(HOUR,WorkShift.StartTime,WorkShift.EndTime)) As TotalHour, Sum(DATEDIFF(HOUR,WorkShift.StartTime,WorkShift.EndTime)*Supervisor.HourlyPay) AS totalPay
, Supervisor.FirstName
From WorkShift
inner join Supervisor
On.WorkShift.SupervisorId = Supervisor.SupervisorId
where WorkShift.SupervisorId = 4
group by Supervisor.FirstName

-- Payment total for Employee
SELECT SUM(DATEDIFF(HOUR,WorkShift.StartTime,WorkShift.EndTime)) As TotalHour, Sum(DATEDIFF(HOUR,WorkShift.StartTime,WorkShift.EndTime)*Employee.HourlyPay) AS totalPay
, Employee.FirstName as EmployeName 
From WorkShift
inner join Employee
On.WorkShift.EmployeeId = Employee.EmployeeId
where WorkShift.EmployeeId = 15
group by Employee.FirstName


select * from Employee