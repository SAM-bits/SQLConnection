
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
