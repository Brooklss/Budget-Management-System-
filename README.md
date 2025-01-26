# Budget Tracking System

A budget tracking system built with C# and .NET to help users manage their income and expenses. The application uses an MS SQL database for data storage.

---

## Features
- Track income and expenses.
- Categorize transactions.
- View summaries and reports.

---

## Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/) or any C# IDE (optional)

---

## Setup Instructions

### 1. Clone the Repository
```bash
git clone https://github.com/your-username/budget-tracking-system.git
cd Budget-Management-System
. Update the Connection String
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your-server-name;Database=BudgetTrackerDb;User Id=your-username;Password=your-password;"
  }
}
