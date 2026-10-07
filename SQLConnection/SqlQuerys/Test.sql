Select CONCAT(FirstName,' ',LastName) as FullName,EmployeeId,Workplan.PlanId as PlanId ,WorkShift.ShiftDate as ShiftDate ,
WorkShift.StartTime as StartTime , WorkShift.EndTime as EndTime from Employee 
inner join WorkPlan on WorkPlan.PlanId = WorkShift.ShiftId
inner join WorkShift on WorkShift.ShiftId = WorkShift.ShiftId

select WorkShift.EmployeeId as EmployeeId, CONCAT(FirstName,' ',LastName) As FullName , WorkShift.ShiftDate as ShiftDate
, CONCAT(WorkShift.StartTime,'-',WorkShift.EndTime) As StartEnd from Employee
join WorkShift on Employee.EmployeeId = WorkShift.EmployeeId
where WorkShift.ShiftDate between GETDATE() and DateAdd(WEEK, 1 , GETDATE())
order by ShiftDate ASC