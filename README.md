# Payroll Management System

## Project Overview

The Payroll Management System is a desktop-based application developed using VB.NET and MySQL to streamline employee and payroll administration within an organization.

The system centralizes employee records, attendance tracking, payroll processing, payslip generation, and employee self-service functions into a single platform. It reduces manual payroll errors, improves record management, and automates the computation of Philippine statutory deductions such as SSS, PhilHealth, and Pag-IBIG.

---

## Features

### Administrator Features

- Employee Management
  - Add, edit, delete, and search employees
  - Import employee records from Excel

- Employee Monitoring
  - Manage employee profiles and employment information
  - Capture and store employee photos

- Attendance Management
  - Track employee attendance records
  - Monitor total hours worked and attendance history

- Payroll Processing
  - Automatic salary computation
  - Overtime calculation
  - Deduction calculation (SSS, PhilHealth, Pag-IBIG)
  - Net pay generation

- Payslip Management
  - Generate employee payslips
  - Download and print payroll records

- Complaint Management
  - View employee-submitted concerns
  - Update complaint status and remarks

### Employee Self-Service Features

- Time In / Time Out Recording
- View Attendance Summary
- View Payslip History
- Submit Complaints
- Monitor Overtime Hours

---

## Tech Stack

| Technology | Purpose |
|------------|---------|
| VB.NET (WinForms) | Desktop application development |
| MySQL | Relational database management |
| MySql.Data.MySqlClient | Database connectivity |
| BCrypt.Net | Password hashing and security |
| ExcelDataReader | Employee data import from Excel |
| Visual Studio | Development environment |

---

## Architecture

```text
+----------------------+
| Employee Dashboard   |
+----------+-----------+
           |
           v
+----------------------+
| Payroll System       |
| (VB.NET WinForms)    |
+----------+-----------+
           |
           v
+----------------------+
| Business Logic Layer |
| Payroll Computation  |
| Attendance Processing|
| Complaint Handling   |
+----------+-----------+
           |
           v
+----------------------+
| MySQL Database       |
| payrolldb            |
+----------------------+
```

The application follows a traditional desktop architecture where the VB.NET client handles user interaction and business logic while MySQL stores operational data.

---

## Project Structure

```text
payroll-management-system/
│
├── JamesLoyd.sln                 # Visual Studio solution
│
├── JamesLoyd/
│   ├── Forms/                    # UI Forms
│   ├── Modules/                  # Business logic modules
│   ├── My Project/               # Project configuration
│   └── JamesLoyd.vbproj          # VB.NET project file
│
├── Database/
│   └── payrolldb.sql             # Database schema
│
├── screenshots/                  # Application screenshots
│
├── .gitignore
└── README.md
```

---

## Installation & Setup

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework support
- MySQL Server
- MySQL Connector/NET

### Clone Repository

```bash
git clone https://github.com/yourusername/payroll-management-system.git
```

### Database Setup

1. Create a database named:

```sql
CREATE DATABASE payrolldb;
```

2. Import:

```text
Database/payrolldb.sql
```

### Configure Connection String

```vb
Private connectionString As String =
"server=localhost;user id=root;password=;database=payrolldb"
```

### Run Application

1. Open `JamesLoyd.sln`
2. Restore NuGet packages
3. Build solution
4. Run project

---

## Usage

### Administrator Workflow

1. Login as Administrator
2. Manage employee records
3. Track attendance
4. Process payroll
5. Generate payslips
6. Review employee complaints

### Employee Workflow

1. Login to Employee Portal
2. Record attendance
3. View hours worked
4. Check payroll history
5. Submit complaints

---

## Screenshots

### Main Dashboard

![Admin Main Menu](screenshots/admin-main-menu.jpg)

### Employee Management

![Employee Management](screenshots/employee-management.jpg)

### Attendance Management

![Attendance](screenshots/manage-attendance.jpg)

### Payroll Processing

![Payroll Processing](screenshots/payroll-processing.jpg)

### Payslip Generator

![Payslip Generator](screenshots/payslip-generator.jpg)

### Employee Self-Service Dashboard

![Employee Dashboard](screenshots/employee-self-service-dashboard.jpg)

---

## Database Design

### Core Tables

- Employees
- Attendance
- Payroll
- Payslip
- Complaints
- Users

These tables are designed to support payroll computation, employee management, attendance tracking, and self-service operations.

---

## Engineering Decisions

### Why MySQL?

MySQL provides a reliable relational database solution with strong support for structured employee and payroll data.

### Why WinForms?

WinForms enables rapid desktop application development and is suitable for internal business systems where web deployment is not required.

### Password Security

Passwords are hashed using BCrypt before storage to improve account security.

### Payroll Computation Design

Payroll calculations are separated from user interface components to simplify maintenance and future enhancements.

---

## Testing

The following areas were manually tested:

- User authentication
- Employee CRUD operations
- Attendance recording
- Payroll computation accuracy
- Deduction calculation
- Payslip generation
- Complaint submission workflow

Testing involved validating expected outputs against manually calculated payroll values.

---

## Limitations

- No biometric attendance integration
- No cloud synchronization
- No automated email notifications
- Single-company deployment only
- Limited reporting and analytics

---

## Future Improvements

- Biometric device integration
- Cloud database deployment
- Email payslip delivery
- Advanced payroll analytics
- Employee leave management
- Multi-company support
- Role-based permission enhancements

---

## License

This project is intended for educational and portfolio purposes.

You may add an MIT License if public contribution and reuse are desired.
