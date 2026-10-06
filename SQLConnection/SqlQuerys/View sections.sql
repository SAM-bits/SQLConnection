--Show one month of workplan 
select * from WorkShift
where ShiftDate  between '2026-10-1' and '2026-10-31'

select * from WorkPlan
where PlanDate between '2026-10-1' and '2026-10-31'


-- Show Hour per supervisor
SELECT Sum(DATEDIFF(Hour,Workshift.StartTime,WorkShift.EndTime)) AS totalHour , Supervisor.FirstName as SupervisorName
From WorkShift
inner join Supervisor
On.WorkShift.SupervisorId = Supervisor.SupervisorId
where WorkShift.SupervisorId = 1
group by Supervisor.FirstName



-- Show hour per Employee
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


select * from employee

delete from Employee
where Employee.EmployeeId=15