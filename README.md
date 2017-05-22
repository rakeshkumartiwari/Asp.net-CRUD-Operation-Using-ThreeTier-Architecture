# Asp.net-CRUD-Operation-Using-ThreeTier-Architecture


Create strored procedure for this application:-


create proc sp_Employee
@EmployeeId     nvarchar(50)=null,
@FirstName      nvarchar(50)=null,
@LastName		nvarchar(50)=null,
@Designation	nvarchar(50)=null,
@DateOfJoining	nvarchar(50)=null,
@Gender			nvarchar(50)=null,
@Qualification	nvarchar(50)=null,
@State			nvarchar(50)=null,
@Action			nvarchar(50)
As
Begin
if @Action='Insert' 
insert into tblEmployee values(@EmployeeId,@FirstName,@LastName,@Designation,@DateOfJoining,@Gender,@Qualification,@State)
if @Action='Update' 
update tblEmployee set FirstName=@FirstName,LastName=@LastName,Designation=@Designation,DateOfJoining=@DateOfJoining,Gender=@Gender,Qualification=@Qualification,State=@State where EmployeeId=@EmployeeId
if @Action='Delete'
delete tblEmployee where EmployeeId=@EmployeeId
if @Action='GetAllEmp'
select * from tblEmployee
if @Action='GetEmp'
select * from tblEmployee where EmployeeId=@EmployeeId
end
