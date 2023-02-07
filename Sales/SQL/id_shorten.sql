SELECT 
REPLACE(Managers.Id,SUBSTRING(CONVERT(NVARCHAR(70), Managers.Id), 6, 26), '...'),
Departments.Name, Managers.Name
FROM Managers INNER JOIN Departments ON Managers.Id_main_dep = Departments.Id