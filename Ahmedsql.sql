Create database SampleCRUD;

USE [SampleCRUD]
GO

UPDATE [dbo].[Employees]
   SET [Empname] = <Empname, nvarchar(max),>
      ,[Designation] = <Designation, nvarchar(max),>
      ,[Grade] = <Grade, nvarchar(max),>
      ,[DepId] = <DepId, int,>
      ,[Deptname] = <Deptname, nvarchar(max),>
 WHERE <Search Conditions,,>
GO

