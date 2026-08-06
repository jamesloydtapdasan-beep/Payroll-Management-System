Public Module SalaryData
    Public Function CalculateHourlyRate(monthlySalary As Decimal) As Decimal
        Return monthlySalary / (22D * 8D)
    End Function

    Public Function CalculateOvertimePay(overtimeHours As Decimal, ratePerHour As Decimal) As Decimal
        Dim overtimeMultiplier As Decimal = 1.25D ' You can adjust this
        Return overtimeHours * ratePerHour * overtimeMultiplier
    End Function



    Public SalaryDict As New Dictionary(Of String, Dictionary(Of String, Decimal)) From {
        {"HR", New Dictionary(Of String, Decimal) From {
            {"HR Manager", 40000D},
            {"Recruiter", 28000D},
            {"HR Assistant", 24000D},
            {"Training Specialist", 30000D},
            {"Compensation Analyst", 32000D}
        }},
        {"IT", New Dictionary(Of String, Decimal) From {
            {"Programmer", 35000D},
            {"IT Support", 27000D},
            {"System Analyst", 38000D},
            {"Software Engineer", 42000D},
            {"Network Administrator", 36000D},
            {"Database Administrator", 39000D}
        }},
        {"Finance", New Dictionary(Of String, Decimal) From {
            {"Accountant", 34000D},
            {"Finance Manager", 45000D},
            {"Payroll Clerk", 26000D},
            {"Budget Analyst", 37000D},
            {"Auditor", 40000D},
            {"Bookkeeper", 25000D}
        }},
        {"Admin", New Dictionary(Of String, Decimal) From {
            {"Admin Officer", 28000D},
            {"Executive Assistant", 32000D},
            {"Office Clerk", 22000D},
            {"Data Encoder", 23000D},
            {"Receptionist", 21000D}
        }},
        {"Marketing", New Dictionary(Of String, Decimal) From {
            {"Marketing Manager", 43000D},
            {"SEO Specialist", 32000D},
            {"Content Creator", 30000D},
            {"Social Media Manager", 31000D},
            {"Market Research Analyst", 34000D}
        }},
        {"Sales", New Dictionary(Of String, Decimal) From {
            {"Sales Executive", 33000D},
            {"Sales Manager", 44000D},
            {"Account Executive", 35000D},
            {"Customer Service Rep", 25000D},
            {"Lead Generator", 26000D}
        }},
        {"Operations", New Dictionary(Of String, Decimal) From {
            {"Operations Manager", 45000D},
            {"Inventory Coordinator", 28000D},
            {"Logistics Officer", 33000D},
            {"Warehouse Supervisor", 31000D},
            {"Production Worker", 24000D}
        }},
        {"Legal", New Dictionary(Of String, Decimal) From {
            {"Legal Officer", 42000D},
            {"Compliance Officer", 40000D},
            {"Paralegal", 35000D},
            {"Contract Analyst", 38000D}
        }},
        {"Engineering", New Dictionary(Of String, Decimal) From {
            {"Mechanical Engineer", 46000D},
            {"Electrical Engineer", 47000D},
            {"Project Engineer", 44000D},
            {"CAD Operator", 32000D},
            {"Site Supervisor", 39000D}
        }},
        {"Maintenance", New Dictionary(Of String, Decimal) From {
            {"Maintenance Supervisor", 30000D},
            {"Janitor", 18000D},
            {"Electrician", 25000D},
            {"Plumber", 24000D},
            {"Facilities Technician", 26000D}
        }}
    }
End Module
