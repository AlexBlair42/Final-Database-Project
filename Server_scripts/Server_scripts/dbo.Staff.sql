CREATE TABLE [dbo].[Staff] (
    [employee_id] INT NOT NULL,
    [fname] NCHAR(30) NULL, 
    [lname] NCHAR(30) NULL, 
    [type_id] INT NULL, 
    PRIMARY KEY CLUSTERED ([employee_id] ASC)
);

