# APU Printing Services Management System

## Project Overview
This C# project is a comprehensive Printing Services Management System developed for Asia Pacific University (APU) as a assignment. The system provides a digital platform for managing printing and binding services for APU students.

## Disclaimer
⚠️ **IMPORTANT**: This project may not have full functionality. The system is not fully maintained, and some features may be incomplete or not fully tested. 

## Key Features
The application supports four user roles with distinct functionalities:

### 1. Customer
- Log in with username and password
- View available services with fees, discounts, and surcharges
- Check status of previous requests
- Submit service requests (single or multiple services)
- View request list and total amount before confirmation

### 2. Worker
- Log in with username and password
- View assigned requests
- Update request status (New → Work In Progress → Completed)

### 3. Manager
- Log in with username and password
- View all request statuses
- Assign new jobs to workers
- Automatically update job status when assigned

### 4. Admin
- Log in with username and password
- Register new users
- Update user profiles
- Generate and view comprehensive reports

## Services Offered
1. Printing A4 - Black and White (0.80 RM/page)
2. Printing A4 - Color (2.50 RM/page)
3. Binding - Comb Binding (5.50 RM/book)
4. Binding - Thick Cover (9.30 RM/book)
5. Printing - Poster A0, A1 (6.00 RM/page)
6. Printing - Poster A2, A3 (3.00 RM/page)

### Special Notes
- 10% discount for over 100 pages on certain services
- 30% surcharge for urgent requests

## Database Setup
The system uses Microsoft SQL Server with the database schema detailed in `APU Printing Service Database Schematics.sql`. The database includes the following tables:
- Credential (User Management)
- RequestIDs
- RequestList
- AcceptRequest
- WorkerMenu

### Database Installation Steps
1. Open Microsoft SQL Server Management Studio
2. Execute the `APU Printing Service Database Schematics.sql` script
3. Verify database creation and initial data insertion

## Prerequisites
- Visual Studio
- .NET Framework
- Microsoft SQL Server
- C# Knowledge

## Installation and Setup
1. Clone the repository
2. Open the solution in Visual Studio
3. Update the SQL connection string in the source code to match your SQL Server configuration
   // Example connection string (modify as per your setup)
   string connectionString = "Server=yourServerName;Database=Users;User Id=yourUsername;Password=yourPassword;";
   ```
4. Build the solution
5. Run the application

## Highlights
- Developed using Object-Oriented Programming concepts
- Includes input validation
- Follows coding style guidelines with proper indentation and comments

## Contributions
This is a group assignment completed by a team of 4 members, with each member contributing to different system features and documentation. 

If you encounter any issues, bugs, or have suggestions for improvement, please contact me. 
Contributions and feedback are welcome.

## Known Limitations
- Some features may not be fully implemented
- Potential bugs or incomplete functionality
- Requires thorough testing and validation

**Note**: This project was developed as part of an academic assignment and may not be suitable for production use without further development and testing.