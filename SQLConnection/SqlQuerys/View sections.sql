--Show one month of workplan 
select * from WorkShift
where ShiftDate  between '2026-10-1' and '2026-10-31'

select * from WorkPlan
where PlanDate between '2026-10-1' and '2026-10-31'


-- Show Hour per supervisor (specific date )
SELECT Sum(DATEDIFF(Hour,Workshift.StartTime,WorkShift.EndTime)) AS totalHour , Supervisor.FirstName as SupervisorName
From WorkShift
inner join Supervisor
On.WorkShift.SupervisorId = Supervisor.SupervisorId
where WorkShift.SupervisorId = 1 
group by Supervisor.FirstName



-- Show hour per Employee (specific date )
SELECT Sum(DATEDIFF(Hour,Workshift.StartTime,WorkShift.EndTime)) AS totalHour , Employee.FirstName as EmployeeName
From WorkShift
inner join Employee
On.WorkShift.EmployeeId = Employee.EmployeeId
where WorkShift.EmployeeId = 1 
group by Employee.FirstName



-- View of workshift from ShiftDate as ASC. 
Select WorkShift.ShiftDate, WorkShift.StartTime,WorkShift.EndTime,Employee.FirstName As EmployeeName,Supervisor.FirstName as SupervisorName from WorkShift
inner join Employee
On.WorkShift.EmployeeId = Employee.EmployeeId
inner join Supervisor
On.WorkShift.SupervisorId = Supervisor.SupervisorId
order by ShiftDate asc --Or DESC 





-- Supervisors WorkShift with the employees and DateTime. 
Select WorkShift.ShiftDate, WorkShift.StartTime,WorkShift.EndTime,Employee.FirstName As EmployeeName,Supervisor.FirstName as SupervisorName
from WorkShift
inner join Employee
On.WorkShift.EmployeeId = Employee.EmployeeId
inner join Supervisor
On.WorkShift.SupervisorId = Supervisor.SupervisorId
where Supervisor.supervisorid = 1



--Employee Total hour : 
SELECT Sum(DATEDIFF(Hour,Workshift.StartTime,WorkShift.EndTime)) AS totalHour , Employee.FirstName as EmployeeName
From WorkShift
inner join Employee
On.WorkShift.EmployeeId = Employee.EmployeeId
where Employee.EmployeeId = 1
group by Employee.FirstName

--Employee Total hour from specific Date : 
SELECT Sum(DATEDIFF(Hour,Workshift.StartTime,WorkShift.EndTime)) AS totalHour , Employee.FirstName as EmployeeName
From WorkShift
inner join Employee
On.WorkShift.EmployeeId = Employee.EmployeeId
where Employee.EmployeeId = 1 and WorkShift.ShiftDate between '2026-10-1' and '2027-01-01'
group by Employee.FirstName





--Supervisor Total Hour 
SELECT Sum(DATEDIFF(Hour,Workshift.StartTime,WorkShift.EndTime)) AS totalHour , Supervisor.FirstName as SuperVisorName
From WorkShift
inner join Supervisor
On.WorkShift.SupervisorId = Supervisor.SupervisorId
where Supervisor.SupervisorId = 1
group by Supervisor.FirstName

--Supervisor Total Hour From Specefic tiem 
SELECT Sum(DATEDIFF(Hour,Workshift.StartTime,WorkShift.EndTime)) AS totalHour , Supervisor.FirstName as SuperVisorName
From WorkShift
inner join Supervisor
On.WorkShift.SupervisorId = Supervisor.SupervisorId
where Supervisor.SupervisorId = 1 and WorkShift.ShiftDate between '2026-10-1' and '2027-01-01'
group by Supervisor.FirstName





-- Shows one week of workshift  .
select WorkShift.EmployeeId as EmployeeId, CONCAT(FirstName,' ',LastName) As FullName , WorkShift.ShiftDate as ShiftDate
, CONCAT(WorkShift.StartTime,'-',WorkShift.EndTime) As StartEnd from Employee
join WorkShift on Employee.EmployeeId = WorkShift.EmployeeId
where WorkShift.ShiftDate between GETDATE() and DateAdd(WEEK, 1 , GETDATE())
order by ShiftDate ASC

-- Shows one week of workshift for a specific FirstName 
select WorkShift.EmployeeId as EmployeeId, CONCAT(FirstName,' ',LastName) As FullName , WorkShift.ShiftDate as ShiftDate
, CONCAT(WorkShift.StartTime,'-',WorkShift.EndTime) As StartEnd from Employee
join WorkShift on Employee.EmployeeId = WorkShift.EmployeeId
where Employee.FirstName='Saif'and WorkShift.ShiftDate between GETDATE() and DateAdd(WEEK, 1 , GETDATE()) 
order by ShiftDate ASC


-- Show amount of shift per Employee (from now date to a specifik date. )
Select WorkShift.EmployeeId as Employeeid ,Count(WorkShift.ShiftId) As AmountOfShift , CONCAT(FirstName,' ',LastName) As FullName
from Employee	
inner join WorkShift
on Employee.EmployeeId = WorkShift.EmployeeId
where WorkShift.ShiftDate between GetDate() and DateAdd(MONTH,7,GETDATE())
GROUP BY WorkShift.EmployeeId,FirstName,LastName





select * from employee

select * from Supervisor

delete from Supervisor
where SupervisorId = 3

delete from Employee
where Employee.EmployeeId=14