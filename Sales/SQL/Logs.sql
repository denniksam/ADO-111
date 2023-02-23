--  Log(String message, LogLevel level, String className, String methodName, object? info);
CREATE TABLE Logs (
	[id]		 UNIQUEIDENTIFIER DEFAULT NEWID(),
	[logDT]      DATETIME,
	[message]    NVARCHAR(max),
	[level]      CHAR(1),
	[className]  NVARCHAR(max),
	[methodName] NVARCHAR(max),
	[info]       NVARCHAR(max),

	PRIMARY KEY(id)
)