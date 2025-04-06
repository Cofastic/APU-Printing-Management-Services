-- Create the Users Database
USE master;
GO

-- Drop database if it exists
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'Users')
BEGIN
    ALTER DATABASE Users SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE Users;
END
GO

-- Create the Users database
CREATE DATABASE Users;
GO

-- Use the newly created database
USE Users;
GO

-- Create Credential Table
CREATE TABLE [Credential]
(
    ID NVARCHAR(50) PRIMARY KEY,
    Profile_Name NVARCHAR(50),
    Username NVARCHAR(50),
    Password NVARCHAR(50),
    Phone_Number VARCHAR(50),
    Role NVARCHAR(50)
);
GO

-- Create RequestIDs Table
CREATE TABLE RequestIDs 
(
    RequestID NVARCHAR(10) PRIMARY KEY, -- Add PRIMARY KEY
    RequestStatus NVARCHAR(255),
    CustomerID NVARCHAR(50),
    TotalPrice DECIMAL(10,3),
    RequestDate DATETIME,
    Urgent BIT,
    AssignedWorker NVARCHAR(50)
);
GO

-- Create RequestList Table
CREATE TABLE RequestList
( 
    RequestID NVARCHAR(10),
    ServiceName NVARCHAR(255),
    ServiceQuantity INT,
    ServicePrice DECIMAL(10,3)
);
GO

-- Create AcceptRequest Table
CREATE TABLE AcceptRequest (
    CustomerID NVARCHAR(50) FOREIGN KEY REFERENCES [Credential](ID),
    WorkerID NVARCHAR(50) FOREIGN KEY REFERENCES [Credential](ID),
    RequestID NVARCHAR(50) PRIMARY KEY,
    ServiceName NVARCHAR(255),
    Size NVARCHAR(255),
    Price NVARCHAR(255),
    TotalPrice NVARCHAR(255),
    RequestStatus NVARCHAR(255),
    Urgent BIT,
    RequestDate DATE
);
GO

-- Create WorkerMenu Table
CREATE TABLE WorkerMenu
(
    RequestID NVARCHAR(10), 
    CustomerID NVARCHAR(50),
    WorkerID NVARCHAR(50),
    ServiceName NVARCHAR(255), 
    Quantity INT, 
    TotalPrice DECIMAL(10,3), 
    RequestStatus NVARCHAR(255), 
    RequestDate DATE, 
    UrgentRequest BIT
);
GO

-- Insert initial Credential data
INSERT INTO [Credential] VALUES
('A01', 'Eric', 'admin','123','0123','Admin'),
('W01','Kenji', 'worker', '123','0123','Worker'),
('C01', 'Valen', 'customer', '123','0123','Customer'),
('M01', 'Jones', 'manager', '123', '0123','Manager');
GO

-- Insert data into RequestIDs Table
INSERT INTO RequestIDs (
    RequestID, RequestStatus, CustomerID, TotalPrice, 
    RequestDate, Urgent, AssignedWorker
)
VALUES 
    ('R01', 'Work In Progress', 'C01', 9.30, '2023-10-11', 1, 'W01'),
    ('R02', 'Work In Progress', 'C01', 2.50, '2023-11-01', 0, 'W01'),
    ('R03', 'Completed', 'C01', 0.80, '2024-08-28', 1, 'W01');
GO

-- Insert data into RequestList Table
INSERT INTO RequestList (
    RequestID, ServiceName, ServiceQuantity, ServicePrice
)
VALUES 
    ('R01', 'Binding (Thick Cover)', 1, 9.30),
    ('R02', 'Printing A4 (Color)', 1, 2.50),
    ('R03', 'Printing A4 (Black & White)', 1, 0.80);
GO

-- Insert data into AcceptRequest Table
INSERT INTO AcceptRequest (
    CustomerID, WorkerID, RequestID, ServiceName, Size, Price, 
    TotalPrice, RequestStatus, Urgent, RequestDate
)
VALUES 
    ('C01', 'W01', 'R01', 'Binding (Thick Cover)', 'n/a', '9.30', '9.30', 'Work In Progress', 1, '2023-10-11'),
    ('C01', 'W01', 'R02', 'Printing A4 (Color)', 'A4', '2.50', '2.50', 'Work In Progress', 0, '2023-11-01'),
    ('C01', 'W01', 'R03', 'Printing A4 (Black & White)', 'A4', '0.80', '0.80', 'Completed', 1, '2024-08-28');
GO

-- Create a view for request details
CREATE VIEW vw_RequestDetails AS
SELECT 
    RID.RequestID, 
    RID.TotalPrice, 
    RID.RequestStatus, 
    RID.RequestDate, 
    RID.CustomerID, 
    U.Username, 
    RID.Urgent, 
    RL.ServiceName, 
    RL.ServiceQuantity, 
    RL.ServicePrice AS [Base Price], 
    RID.AssignedWorker
FROM 
    RequestIDs RID
JOIN 
    [Credential] U ON U.ID = RID.CustomerID
JOIN 
    RequestList RL ON RL.RequestID = RID.RequestID;
GO

-- Create a procedure to reset all tables
CREATE PROCEDURE ResetAllTables
AS
BEGIN
    -- Disable foreign key constraints
    EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'

    -- Clear all tables
    DELETE FROM [Credential];
    DELETE FROM AcceptRequest;
    DELETE FROM RequestIDs;
    DELETE FROM RequestList;
    DELETE FROM WorkerMenu;

    -- Re-insert Credential data
    INSERT INTO [Credential] VALUES
    ('A01', 'Eric', 'Admin','123','0123','Admin'),
    ('W01','Kenji', 'Worker', '123','0123','Worker'),
    ('C01', 'Valen', 'Customer', '123','0123','Customer'),
    ('M01', 'Jones', 'Manager', '123', '0123','Manager')

    -- Re-enable foreign key constraints
    EXEC sp_MSforeachtable 'ALTER TABLE ? CHECK CONSTRAINT ALL'
END
GO


-- Select queries
SELECT * FROM AcceptRequest
SELECT * FROM Credential
SELECT * FROM RequestIDs
SELECT * FROM RequestList
SELECT * FROM WorkerMenu