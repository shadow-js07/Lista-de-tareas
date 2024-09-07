create database ListaTareas;
GO

use ListaTareas;
GO

create table Tareas(
tareaID INT PRIMARY KEY IDENTITY (1,1),
titulo NVARCHAR(100),
descripcion NVARCHAR(250),
estado BIT
);

select * from Tareas;