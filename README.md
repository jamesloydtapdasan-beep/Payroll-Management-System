# Payroll Management System

A desktop **Company Payroll System** built with **VB.NET (WinForms)** and **MySQL**, designed to handle end-to-end employee and payroll management — from employee records and attendance tracking to payroll computation, payslip generation, and an employee self-service portal.

Deductions are computed following **Philippine payroll standards** (SSS, PhilHealth, Pag-IBIG).

---

## ✨ Features

### Admin Side

**Main Admin Dashboard**
Central hub for managing employees, attendance, payroll, payslips, and complaints.

![Admin Main Menu](Images\admin.jfif).

**Employee Management**
Search, add, edit, and delete employee records. Supports bulk employee import via Excel.

![Employee Management](screenshots/employee-management.jpg)

**Employee Monitoring Panel**
Full employee profile management — personal info, contact details, employment info, and photo/selfie capture.

![Employee Monitoring Panel](screenshots/employee-monitoring-panel.jpg)

**Attendance Management**
Track total days worked, total hours worked, and last attendance date per employee.

![Manage Attendance](screenshots/manage-attendance.jpg)

**Payroll Processing**
Computes gross pay, overtime pay, deductions (SSS, PhilHealth, Pag-IBIG), absences, and net pay. Supports save and approval workflow per pay period.

![Payroll Processing](screenshots/payroll-processing.jpg)

**Payslip Generator**
Generates and downloads individual employee payslips with a breakdown of pay and deductions.

![Payslip Generator](screenshots/payslip-generator.jpg)

**Complaint Dashboard**
Tracks employee-submitted complaints with status updates (Pending, In Progress, Resolved) and remarks.

![Complaint Dashboard](screenshots/complaint-dashboard.jpg)

### Employee Self-Service

**Employee Dashboard**
Employees can log morning/afternoon time in-out, view total hours worked and overtime, check their latest payslip, view payslip history, and submit complaints.

![Employee Self-Service Dashboard](screenshots/employee-self-service-dashboard.jpg)

---

## 🛠️ Tech Stack

- **Language / Framework:** VB.NET (Windows Forms, .NET Framework)
- **Database:** MySQL
- **Libraries:**
  - `MySql.Data.MySqlClient` — MySQL connectivity
  - `BCrypt.Net` — secure password hashing
  - `ExcelDataReader` — bulk employee import from Excel files

---

## 📋 Prerequisites

- Visual Studio 2019 or later (with VB.NET / .NET Framework support)
- MySQL Server (e.g. via XAMPP, WAMP, or standalone MySQL installation)
- MySQL Connector/NET (for `MySql.Data.MySqlClient`)

---

## 🚀 Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/payroll-management-system.git
   ```

2. **Set up the database**
   - Create a MySQL database named `payrolldb`
   - Import the schema from `Database/payrolldb.sql`

3. **Configure the connection string**
   In the project source, update the connection string to match your local MySQL setup:
   ```vb
   Private connectionString As String = "server=localhost; user id=root; password=; database=payrolldb"
   ```

4. **Open and run**
   - Open `JamesLoyd.sln` in Visual Studio
   - Restore NuGet packages if prompted
   - Build and run the solution

---

## 📁 Project Structure

```
payroll-management-system/
├── JamesLoyd.sln
├── JamesLoyd/
│   ├── Forms/
│   ├── Modules/
│   ├── My Project/
│   └── JamesLoyd.vbproj
├── Database/
│   └── payrolldb.sql
├── screenshots/
├── .gitignore
└── README.md
```

---

## 🔒 Notes

- Passwords are hashed using BCrypt before being stored.
- This project was built as a learning/portfolio project. Update the connection string and secure any real credentials before deploying beyond local use.

---

## 📄 License

This project is open for personal and educational use. Add a license (e.g. MIT) if you plan to accept contributions or want to formalize usage terms.
