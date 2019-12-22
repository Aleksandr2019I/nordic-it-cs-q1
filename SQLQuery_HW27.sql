CREATE TABLE MessageStatus(
    [Id] INT NOT NULL,
    [NameId] INT NOT NULL,
    [Message] NVARCHAR(4000) NOT NULL,
    [Status] NVARCHAR(100) NOT NULL,
    [DateTime] DATETIME2 NOT NULL,
    PRIMARY KEY CLUSTERED ([Id]) 
);
--ALTER TABLE MessageStatus
--ADD CONSTRAINT pk_MessageStatus PRIMARY KEY CLUSTERED (Id);
CREATE TABLE Employee(
    [Id] INT NOT NULL,
    [Name] NVARCHAR(100) NOT NULL
    PRIMARY KEY CLUSTERED ([Id])
);
--ALTER TABLE Empolyee
--ADD CONSTRAINT pk_Empolyee PRIMARY KEY CLUSTERED (Id);
GO

-- Тут связываю таблицу MessageStatus(колонка NameId) с главной таблицей Employee(колонка Id)
ALTER TABLE MessageStatus 
    ADD CONSTRAINT FK_Id_Employee FOREIGN KEY (NameId)
    REFERENCES Employee (Id)
    ON DELETE NO ACTION
    ON UPDATE CASCADE;




SELECT * FROM MessageStatus;
SELECT * FROM Employee;

DROP TABLE MessageStatus;
DROP TABLE Employee;



